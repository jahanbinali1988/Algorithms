using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Sorts
{
	/// <summary>
	/// Divide and Conquer 
	/// It works by recursively splitting the input array into smaller subarrays and sorting those subarrays, then merging them again to get the sorted array.
	/// Merge sort is fast in the case of a linked list
	/// Size of dataset does not matter, in any size, this algorithm has a good performance 
	/// O(n log n)
	/// </summary>
	public class MergeSort
	{
		public void Sort(int[] givenArray, int leftPoint, int rightPoint)
		{
			if (leftPoint < rightPoint)
			{

				// Find the middle point
				int middlePoint = leftPoint + (rightPoint - leftPoint) / 2;

				// Sort first and second halves
				Sort(givenArray, leftPoint, middlePoint);
				Sort(givenArray, middlePoint + 1, rightPoint);

				// Merge the sorted halves
				Merge(givenArray, leftPoint, middlePoint, rightPoint);
			}
		}

		// Merges two subarrays of givenArray.
		private void Merge(int[] givenArray, int leftPoint, int middlePoint, int rightPoint)
		{
			// Find sizes of two
			// subarrays to be merged
			int n1 = middlePoint - leftPoint + 1;
			int n2 = rightPoint - middlePoint;

			// Create temp arrays
			int[] L = new int[n1];
			int[] R = new int[n2];
			int i, j;

			// Copy data to temp arrays
			for (i = 0; i < n1; ++i)
				L[i] = givenArray[leftPoint + i];
			for (j = 0; j < n2; ++j)
				R[j] = givenArray[middlePoint + 1 + j];

			// Merge the temp arrays

			// Initial indexes of first
			// and second subarrays
			i = 0;
			j = 0;

			// Initial index of merged
			// subarray array
			int k = leftPoint;
			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					givenArray[k] = L[i];
					i++;
				}
				else
				{
					givenArray[k] = R[j];
					j++;
				}
				k++;
			}

			// Copy remaining elements
			// of L[] if any
			while (i < n1)
			{
				givenArray[k] = L[i];
				i++;
				k++;
			}

			// Copy remaining elements
			// of R[] if any
			while (j < n2)
			{
				givenArray[k] = R[j];
				j++;
				k++;
			}
		}

	}
}

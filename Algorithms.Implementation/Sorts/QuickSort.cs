using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Sorts
{
	public class QuickSort
	{
		public void Sort(int[] arr, int low, int high)
		{
			if (low < high)
			{
				// Partitioning index, arr[pivotIndex] is now at the correct position
				int pivotIndex = Partition(arr, low, high);

				// Recursively sort elements before and after the partition
				Sort(arr, low, pivotIndex - 1);
				Sort(arr, pivotIndex + 1, high);
			}
		}

		public int Partition(int[] arr, int low, int high)
		{
			// Choose the rightmost element as the pivot
			int pivot = arr[high];
			int i = low - 1; // Index of smaller element

			for (int j = low; j < high; j++)
			{
				// If current element is smaller than or equal to pivot
				if (arr[j] <= pivot)
				{
					i++;
					// Swap arr[i] and arr[j]
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}

			// Swap arr[i+1] and arr[high] (or pivot)
			int temp2 = arr[i + 1];
			arr[i + 1] = arr[high];
			arr[high] = temp2;

			return i + 1;
		}
	}
}

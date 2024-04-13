using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Searchs
{
	//The most efficient search algorithm
	//O(LogN)
	public class BinarySearch
	{
		public int? Search(int[] givenArray, int target)
		{
			return Search(givenArray, target, 0, givenArray.Length - 1);
		}

		public int? Search(int[] givenArray, int target, int lowerPoint, int upperPoint)
		{
			if (lowerPoint < upperPoint)
			{
				int midPoint = (lowerPoint + upperPoint) / 2;
				if (givenArray[midPoint] < target)
					return Search(givenArray, target, midPoint + 1, givenArray.Length - 1);
				else if (givenArray[midPoint] > target)
					return Search(givenArray, target, lowerPoint, midPoint - 1);
				else
					return midPoint;
			}
			else
				return null;
		}
	}
}

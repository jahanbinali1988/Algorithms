using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Searchs
{
	public class JumpSearch
	{
		public int? Search(int[] givenArray, int target)
		{
			int n = givenArray.Length;

			// Finding block size to be jumped
			int step = (int)Math.Sqrt(n);

			// Finding nearest block to the target
			int prev = 0;
			for (int minStep = Math.Min(step, n) - 1; givenArray[minStep] < target; minStep = Math.Min(step, n) - 1)
			{
				prev = step;
				step += (int)Math.Sqrt(n);
				if (prev >= n)
					return null;
			}

			// Doing a linear 
			while (givenArray[prev] < target)
			{
				prev++;

				if (prev == Math.Min(step, n))
					return null;
			}

			if (givenArray[prev] == target)
				return prev;

			return null;
		}
	}
}

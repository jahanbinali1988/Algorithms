using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Searchs
{
	public class LinearSearch
	{
		public int? Search(int[] givenArray, int target)
		{
            for (int i = 0; i < givenArray.Length; i++)
            {
				if (givenArray[i] == target)
				{
					return givenArray[i];
				}
            }
			return null;
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.Sorts
{
	// in-place comparison sort
    // O(n) - O(n2)
	public class InsertionSort
    {
        public int[] Sort(int[] givenArray)
        {
            for (int i = 1; i < givenArray.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (givenArray[j] < givenArray[j - 1])
                    {
                        int temp = givenArray[j - 1];
                        givenArray[j - 1] = givenArray[j];
                        givenArray[j] = temp;
                    }
                }
            }
            return givenArray;
        }
    }
}

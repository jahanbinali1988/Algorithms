using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
	/// <summary>
	/// https://code-maze.com/csharp-bubble-sort/
	/// </summary>
	public class BubbleSort
	{
		public int[] Sort(int[] givenArray)
		{
            for (int i = 0; i < givenArray.Length; i++)
            {
                for (int j = i; j < givenArray.Length; j++)
                {
					if (givenArray[i] > givenArray[j])
					{
						var tempValue = givenArray[i];
						givenArray[i] = givenArray[j];
						givenArray[j] = tempValue;
					}
                }

            }

            return givenArray;
		}
	}
}

using Algorithms.Implementation.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sorts
{
	public class CombSortTests
	{
		[Fact]
		public void Sort_works_correctly()
		{
			var sort = new CombSort();
			var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			var unsortedArray = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };

			sort.Sort(unsortedArray);

			Assert.Equivalent(unsortedArray, sortedArray);
		}
	}
}

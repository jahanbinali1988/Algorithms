using Algorithms.Implementation.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sorts
{
	public class ShellSortTests
	{
		[Fact]
		public void Sort_works_correctly()
		{
			var sort = new ShellSort();
			var unsortedArray = new int[] { 6, 5, 3, 1, 8, 7, 2, 4, 9 };

			var sortedArray = sort.Sort(unsortedArray);

			Assert.Equivalent(unsortedArray.Order(), sortedArray);
		}
	}
}

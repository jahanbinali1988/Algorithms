using Algorithms.Implementation.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sorts
{
	public class QuickSortTests
	{
		[Fact]
		public void Sort_works_correctly()
		{
			var sort = new QuickSort();
			var actualArray = new int[] { 6, 5, 3, 1, 8, 7, 2, 4, 9 };
			var expectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var low = 0;
			var high = actualArray.Length - 1;

			sort.Sort(actualArray, low, high);

			Assert.Equivalent(actualArray, expectedArray);
		}
	}
}

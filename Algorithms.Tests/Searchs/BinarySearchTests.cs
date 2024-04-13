using Algorithms.Implementation.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Searchs
{
	public class BinarySearchTests
	{
		[Fact]
		public void Search_returns_seaeched_data_correctly()
		{
			var searchedDataIndex = 5;
			var searchedData = 6;
			var actualArray = new int[] { 1, 2, 3, 4, 5, searchedData, 7 };
			BinarySearch search = new BinarySearch();

			var result = search.Search(actualArray, searchedData);

			Assert.Equal(searchedDataIndex, result);
		}


		[Fact]
		public void Search_could_not_find_searchedData()
		{
			var searchedData = 16;
			var actualArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			BinarySearch search = new BinarySearch();

			var result = search.Search(actualArray, searchedData);

			Assert.Null(result);
		}
	}
}

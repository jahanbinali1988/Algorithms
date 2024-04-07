using Algorithms.Implementation.Searchs;

namespace Algorithms.Tests.Searchs
{
	public class LinearSearchTests
	{
		[Fact]
		public void Search_returns_null_if_searched_data_does_not_exist()
		{
			var searchedData = 6;
			var actualArray = new int[] { 1, 2, 3, 4, 5, searchedData };
			LinearSearch search = new LinearSearch();

			var result = search.Search(actualArray, searchedData);

			Assert.Equal(searchedData, result);
		}
		[Fact]
		public void Search_returns_seached_data_correctly()
		{
			var searchedData = 6;
			var actualArray = new int[] { 1, 2 , 3, 4, 5, searchedData};
			LinearSearch search = new LinearSearch();

			var result = search.Search(actualArray, searchedData);

			Assert.Equal(searchedData, result);
		}
	}
}

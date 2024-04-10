using Algorithms.Implementation.Sorts;

namespace Algorithms.Tests.Sorts
{
    public class SelectionSortTests
    {
        [Fact]
        public void Sort_returing_array_has_the_same_Size()
        {
            var sort = new SelectionSort();
            var unsortedArray = new int[] { 1, 2 };

            var sortedArray = sort.Sort(unsortedArray);

            Assert.Equal(unsortedArray.Length, sortedArray.Length);
        }

        [Fact]
        public void Sort_works_correctly()
        {
            var sort = new SelectionSort();
            var unsortedArray = new int[] { 2, 1, 4, 3 };

            var sortedArray = sort.Sort(unsortedArray);

            Assert.Equivalent(unsortedArray.Order(), sortedArray);
        }
    }
}
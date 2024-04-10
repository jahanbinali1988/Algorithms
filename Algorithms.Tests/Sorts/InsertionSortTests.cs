using Algorithms.Implementation.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sorts
{
    public class InsertionSortTests
    {
        [Fact]
        public void Sort_returing_array_has_the_same_Size()
        {
            var sort = new InsertionSort();
            var unsortedArray = new int[] { 1, 2 };

            var sortedArray = sort.Sort(unsortedArray);

            Assert.Equal(unsortedArray.Length, sortedArray.Length);
        }

        [Fact]
        public void Sort_works_correctly()
        {
            var sort = new InsertionSort();
            var unsortedArray = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };

            var sortedArray = sort.Sort(unsortedArray);

            Assert.Equivalent(unsortedArray.Order(), sortedArray);
        }
    }
}

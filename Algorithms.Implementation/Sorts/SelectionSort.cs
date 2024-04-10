namespace Algorithms.Implementation.Sorts
{
    /// <summary>
    /// the aim of this algorithm is finding the minimum value of unsorted list and put in the right place of the listss
    /// </summary>
    public class SelectionSort
    {
        /// <summary>	
        /// We devide a list of number into two parts, sorted and unsorted. 
        /// At each steps we find smallest number from unsorted part and move it to the end of sorted part. 
        /// We continue this process until all numbers in the unsorted part move to sorted part.
        /// </summary>
        /// <param name="givenArray">The array to sort</param>
        /// <returns></returns>
        public int[] Sort(int[] givenArray)
        {
            for (int i = 0; i < givenArray.Length; i++)
            {
                var smallestNumber = givenArray[i];

                for (int j = givenArray.Length - 1; j > i; j--)
                {
                    var comparedNumber = givenArray[j];
                    if (smallestNumber > comparedNumber)
                    {
                        givenArray[i] = givenArray[j];
                        givenArray[j] = smallestNumber;
                    }
                }
            }

            return givenArray;
        }
    }
}

namespace Merge_sort
{
    internal static class ArrayClassFunctions
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] subarray = new T[length];
            Array.Copy(data, index, subarray, 0, length);
            return subarray;
        }

        public static T[] MergeSort<T>(this T[] array) where T : IComparable<T>
        {
            if (array.Length <= 1)
            {
                return array; // Base case: arrays with 0 or 1 element are already sorted
            }

            // Get half length
            int halfLength = array.Length / 2;

            // Split the array into two halves
            T[] firstHalf = array.SubArray(0, halfLength);
            int secondLength = array.Length - halfLength; // Correctly calculate the length of the second half
            T[] secondHalf = array.SubArray(halfLength, secondLength);

            // Recursively sort the two halves
            firstHalf = firstHalf.MergeSort();
            secondHalf = secondHalf.MergeSort();

            // Merge the sorted halves back into the original array
            return Merge(array, firstHalf, secondHalf);
        }

        private static T[] Merge<T>(T[] array, T[] firstHalf, T[] secondHalf) where T : IComparable<T>
        {
            int i = 0, j = 0, k = 0;

            // Merge the two sorted halves into the original array
            while (i < firstHalf.Length && j < secondHalf.Length)
            {
                if (firstHalf[i].CompareTo(secondHalf[j]) <= 0)
                {
                    array[k++] = firstHalf[i++];
                }
                else
                {
                    array[k++] = secondHalf[j++];
                }
            }

            // Copy any remaining elements from firstHalf (if any)
            while (i < firstHalf.Length)
            {
                array[k++] = firstHalf[i++];
            }

            // Copy any remaining elements from secondHalf (if any)
            while (j < secondHalf.Length)
            {
                array[k++] = secondHalf[j++];
            }

            return array;
        }
    }
}

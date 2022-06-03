namespace ArraysSortAppConsole
{
    class CoutingSort : ISorteableArray
    {
        public int[] DoSort(int[] array, out int loopCount)
        {
            loopCount = 0;

            int n = array.Length;
            int max = 0;

            //find largest element in the Array
            for (int i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            //create a freq array to store number of occurrences of 
            //each unique elements in the given array 
            int[] freq = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                freq[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                freq[array[i]]++;
            }

            //sort the given array using freq array
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (freq[i] > 0)
                {
                    array[j] = i;
                    j++;
                    freq[i]--;
                }
            }

            return array;
        }
    }
}

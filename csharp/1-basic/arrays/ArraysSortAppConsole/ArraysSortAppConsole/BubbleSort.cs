namespace ArraysSortAppConsole
{
    class BubbleSort : ISorteableArray
    {
        public int[] DoSort(int[] array, out int loopCount)
        {
            int temp = int.MinValue;
            bool doBreak = true;
            loopCount = 0;

            for (int write = 0; write < array.Length; write++)
            {
                doBreak = true;
                for(int sort = 0; sort < array.Length - 1; sort ++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                        doBreak = false;
                    }
                    loopCount++;
                }

                /*early escape*/
                if (doBreak) { return array; }
            }

            return array;
        }
    }
}

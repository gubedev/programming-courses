namespace ArraysSortAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ISorteableArray sorteable = new BubbleSort();
            int loopCount;

            int[] array = new int[] { 2, 1, 4, 3 };
            var sorted = sorteable.DoSort(array, out loopCount);

            System.Console.WriteLine(loopCount + " Loop count");

            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }

            System.Console.ReadLine();
        }    
    }
}

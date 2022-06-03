namespace ArraysSortAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ISorteableArray sorteable = new CoutingSort();
            int loopCount;

            int[] array = new int[] { 9, 1, 2, 5, 9, 9, 2, 1, 3, 3 };
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

using System;
using System.Collections.Generic;

namespace GenericsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            foreach(string c in cities.Data)
            {
                Console.WriteLine(c);
            }

            foreach (int e in empIds.Data)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}

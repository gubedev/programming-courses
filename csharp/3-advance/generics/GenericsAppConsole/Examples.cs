using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAppConsole
{
    class IntDataStore
    {
        private int[] _data = new int[10];

        public void AddOrUpdate(int index, int item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public int GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(int);
        }

        public int[] Data { get => _data; }
    }

    class StringDataStore
    {
        private string[] _data = new string[10];

        public void AddOrUpdate(int index, string item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public string GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(string);
        }

        public string[] Data { get => _data; }
    }
}

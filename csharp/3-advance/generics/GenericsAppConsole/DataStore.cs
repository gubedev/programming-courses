namespace GenericsAppConsole
{
    class DataStore<M>
    {
        private M[] _data = new M[10];

        public void AddOrUpdate(int index, M item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public M GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(M);
        }

        public M[] Data { get => _data; }
    }
}

using DictionariesConsole.Computing;
using DictionariesConsole.Computing.Handlers;
using System.Collections.Generic;

namespace DictionariesConsole.Computing
{
    class Calculator
    {
        Dictionary<ComputeEnum, ICompute> computesHandler = new Dictionary<ComputeEnum, ICompute>();
        public Calculator()
        {
            computesHandler.Add(ComputeEnum.ADDITION, new Addition());
            computesHandler.Add(ComputeEnum.SUBTRACTION, new Subtraction());
        }

        public bool TryGetHandler(ComputeEnum compute, out ICompute handler)
        {
           return computesHandler.TryGetValue(compute, out handler);
        }
    }
}

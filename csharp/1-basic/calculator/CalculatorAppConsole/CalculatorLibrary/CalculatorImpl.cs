using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Calculator implementation
    /// </summary>
    public class CalculatorImpl : ICalculatorImpl
    {
        /// <summary>
        /// Do arithmetic operation
        /// </summary>
        /// <param name="num1">number one</param>
        /// <param name="num2">number two</param>
        /// <param name="op">operatio to do</param>
        /// <returns>Result of the operation</returns>
        public double DoOperation(double num1, double num2, string op)
        {
            // Default value is "not-a-number" if an operation, such as division, could result in an error.
            double result = double.NaN;

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }

    public class CalculatorDer : ICalculatorImpl
    {
        public double DoOperation(double num1, double num2, string op)
        {
            throw new NotImplementedException();
        }
    }
}

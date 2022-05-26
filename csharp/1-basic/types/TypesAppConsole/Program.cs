using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppConsole
{
    class Program
    {
        static string inputText = string.Empty;
        const string CLOSE_SIGNAL = "a";
        const string EXPECTED_TEXT = "BITING";

        static void Main(string[] args)
        {
            do
            {
                inputText = Console.ReadLine();
                string formatted = string.Format("Input text value: {0}", inputText);
                if (inputText == EXPECTED_TEXT)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("GREAT !!");
                    Console.ResetColor();
                }
                Console.WriteLine(formatted);
            }
            while (inputText != CLOSE_SIGNAL);
        }
    }
}

#region Links
// https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022

// https://docs.microsoft.com/es-es/dotnet/framework/get-started/overview

// https://emanuelpeg.blogspot.com/2021/05/common-language-runtime.html 
#endregion

#region Guides

// https://docs.microsoft.com/es-es/dotnet/desktop/winforms/get-started/create-app-visual-studio?view=netdesktop-6.0

#endregion
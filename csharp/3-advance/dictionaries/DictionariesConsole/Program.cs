using DictionariesConsole.Computing;
using System;
using System.Collections.Generic;

namespace DictionariesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            Dictionary<string, string> databaseConfig = new Dictionary<string, string>();

            databaseConfig.Add("host", "SERVER_DB//PROD" );
            databaseConfig.Add("databaseName", "Dispatchs");
            databaseConfig.Add("userName", "usuario");
            databaseConfig.Add("passwor", "secreto!dd");

            /*
             
                llave - lo va indentificar
                valor - es el valor que contiene

                           (llave),  (valor)
                Dictionary<string, string> nombreDiccionario

             */

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");

            string outValue = string.Empty;
            var exists = openWith.TryGetValue("txt", out outValue);

            Console.WriteLine(string.Format("value of {0}: {1}", "txt", outValue));

            outValue = openWith["txt"];

            Console.WriteLine(string.Format("value of {0}: {1}", "txt", outValue));

            if (!openWith.ContainsKey("xlsx")) 
            {
                openWith.Add("xlsx", "excel.exe");
            }

            Dictionary<string, string>.KeyCollection openWithKeys = openWith.Keys;

            Console.WriteLine("Showing keys...");

            foreach(string key in openWithKeys)
                Console.WriteLine(string.Format("key: {0}", key));

            Console.WriteLine("Showing keys and vlues...");

            foreach (KeyValuePair<string, string> item in openWith)
                Console.WriteLine(string.Format("key: {0}, value: {1}", item.Key, item.Value));

            var calc = new Calculator();

            ICompute handler;

            calc.TryGetHandler(ComputeEnum.ADDITION, out handler);

            var result = handler.DoCompute(10, 20);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

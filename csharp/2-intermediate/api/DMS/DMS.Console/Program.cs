using DMS.Console.Utils;

namespace DMS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatchService = Container.ResolveDispatchService();

            dispatchService.DoDispatchNotification();

            System.Console.ReadLine();
        }
    }
}

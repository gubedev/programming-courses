using DMS.Console.Impl;
using DMS.Library;

namespace DMS.Console.Utils
{
    internal class Container
    {
        private static IDataAccess ResolveDataAccess()
        {
            return new DataAccess();
        }

        private static INotificationSender ResolveNotificationSender()
        {
            return new NotificationSender();
        }

        public static DispatchService ResolveDispatchService()
        {
            var dataAccessImple = ResolveDataAccess();
            var notificationSenderImple = ResolveNotificationSender();

            return new DispatchService(dataAccessImple, notificationSenderImple);
        }
    }
}

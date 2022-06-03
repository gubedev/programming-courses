using DMS.Library;

namespace DMS.Console.Impl
{
    class NotificationSender : INotificationSender
    {
        public void DoNotification(string subject, string email, string body)
        {
            System.Console.WriteLine(body);
        }
    }
}

namespace DMS.Library
{
    public interface INotificationSender
    {
        void DoNotification(string subject, string email, string body);
    }
}

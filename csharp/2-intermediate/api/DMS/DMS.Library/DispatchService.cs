using DMS.Library.Domain;
using System;

namespace DMS.Library
{
    public class DispatchService
    {
        private readonly IDataAccess _dataAccess;
        private readonly INotificationSender _notificationSender;

        public DispatchService(IDataAccess dataAccess, INotificationSender notificationSender)
        {
            _dataAccess = dataAccess ?? throw new ArgumentNullException(nameof(dataAccess));
            _notificationSender = notificationSender ?? throw new ArgumentNullException(nameof(notificationSender));
        }

        public void DoDispatchNotification()
        {
            Dispatch[] dispatchs = _dataAccess.FetchToNotificateDispatch();
            if (dispatchs.Length == 0) return;
            foreach(Dispatch d in dispatchs)
            {
                var dispatchCode = d.DispatchCode;
                var subject = d.CustomerFullname;
                var email = d.CustomerEmail;
                var body = $"Estimado/a notificamos que su pedido ha sido despachado.";
                _notificationSender.DoNotification(subject,email, body);
                _dataAccess.MarkDispatchAsNotified(dispatchCode);
            }
        }
    }
}

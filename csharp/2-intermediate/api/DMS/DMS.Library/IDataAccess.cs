using DMS.Library.Domain;

namespace DMS.Library
{
    public interface IDataAccess
    {
        Dispatch[] FetchToNotificateDispatch();
        void MarkDispatchAsNotified(string dispatchCode);
    }
}

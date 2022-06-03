using DMS.Library;
using DMS.Library.Domain;

namespace DMS.Console.Impl
{
    class DataAccess : IDataAccess
    {
        public Dispatch[] FetchToNotificateDispatch()
        {
            var dispatch01 = new Dispatch() 
            { 
                
            };
            
            return new Dispatch[] { dispatch01 };
        }

        public void MarkDispatchAsNotified(string dispatchCode)
        {
            
        }
    }
}

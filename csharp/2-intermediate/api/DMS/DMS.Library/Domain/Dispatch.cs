using System;

namespace DMS.Library.Domain
{
    public class Dispatch
    {
        public string DispatchCode { get; set; }
        public string DeliveryAddress { get; set; }
        public string CustomerFullname { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? NotificatedAt { get; set; }
    }
}

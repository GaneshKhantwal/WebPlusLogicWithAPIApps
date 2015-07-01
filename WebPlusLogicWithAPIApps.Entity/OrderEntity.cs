using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPlusLogicWithAPIApps.Entity
{
    public class OrderEntity
    {
        public string FlowerName { get; set; }
        public string RecipientName { get; set; }
        public string DeliveryStreet { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryPostalCode { get; set; }
        public string Phone { get; set; }
    }
}

using OrderServiceDesign.Domain.BaseDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.Domain.Entities
{
    public class ShippingDetails : BaseEntity
    {
        public string CurrentLocation { get; set; }
        public string CourierCompanyId { get; set; }
        public string CourierCompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ReachDate { get; set; }
    }
}

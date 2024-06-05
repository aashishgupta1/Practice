using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.Domain.DTO
{
    public class AddressDTO
    {
        public string Name { get; set; }
        public string AddressType { get; set; }
        public string ContactNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string AddressLine1 { get; set; }
    }
}

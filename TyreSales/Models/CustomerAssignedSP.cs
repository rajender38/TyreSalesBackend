using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TyreSales.Models
{
    public class CustomerAssignedSP
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string SalesPerson { get; set; }

        public List<CustomerAssignedSP> custAssignSalesPerson = new List<CustomerAssignedSP>();

        public CustomerAssignedSP(CustomerDetails customerDetails, string salesPerson)
        {
            this.FristName = customerDetails.FristName;
            this.LastName = customerDetails.LastName;
            this.SalesPerson = salesPerson;

        }
    }
}

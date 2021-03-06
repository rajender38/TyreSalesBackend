using System.Collections.Generic;
using TyreSales.Interface;

namespace TyreSales.Models
{
    public class CustomerSalesPerson : ICustomerSalesPerson
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string SalesPerson { get; set; }

        public List<CustomerSalesPerson> custAssignSalesPerson = new List<CustomerSalesPerson>();

        public void AssignSalesPerson(CustomerDetails customerDetails, string salesPerson)
        {
            custAssignSalesPerson.Add(new CustomerSalesPerson { FristName = customerDetails.FristName, LastName = customerDetails.LastName, SalesPerson = salesPerson });

        }

        public List<CustomerSalesPerson> GetCustomerSalesPerson()
        {
            return custAssignSalesPerson;
        }
    }
}

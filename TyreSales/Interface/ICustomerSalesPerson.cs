using System.Collections.Generic;
using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface ICustomerSalesPerson
    {
        public void AssignSalesPerson(CustomerDetails customerDetails, string salesPerson);
        public List<CustomerSalesPerson> GetCustomerSalesPerson();
    }
}

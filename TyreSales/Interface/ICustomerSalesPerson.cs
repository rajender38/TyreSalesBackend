using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface ICustomerSalesPerson
    {
        public void AssignSalesPerson(CustomerDetails customerDetails, string salesPerson);
        public List<CustomerSalesPerson> GetCustomerSalesPerson();
    }
}

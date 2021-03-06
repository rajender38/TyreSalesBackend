using System.Collections.Generic;
using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface ISalesPerson
    {

        public List<SalesPerson> LoadSalesPerson();
    }
}

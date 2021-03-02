using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TyreSales.Interface;

namespace TyreSales.Models
{
    public class SalesPerson: ISalesPerson
    {
        public string Name { get; set; }
        public List<string> Groups { get; set; }
        public List<SalesPerson> LoadSalesPerson()
        {
            using (StreamReader r = new StreamReader("../TyreSales/wwwroot/salesperson.json"))
            {
                string json = r.ReadToEnd();
                List<SalesPerson> items = JsonConvert.DeserializeObject<List<SalesPerson>>(json);
                return items;
            }
        }


    }

}

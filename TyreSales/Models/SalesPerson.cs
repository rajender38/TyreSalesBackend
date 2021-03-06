using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TyreSales.Interface;

namespace TyreSales.Models
{
    public class SalesPerson : ISalesPerson
    {
        public string Name { get; set; }
        public List<string> Groups { get; set; }
        public List<SalesPerson> LoadSalesPerson()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\salesperson.json");
            //using (StreamReader r = new StreamReader("../TyreSales/wwwroot/salesperson.json"))
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<SalesPerson> items = JsonConvert.DeserializeObject<List<SalesPerson>>(json);
                return items;
            }
        }


    }

}

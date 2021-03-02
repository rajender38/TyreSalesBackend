using System.Collections.Generic;
using System.Linq;
using TyreSales.Interface;

namespace TyreSales.Models
{
    public class Groups :IGroups
    {
        public IDictionary<string, string> items = new Dictionary<string,string>();
        public Groups()
        {
            items.Add("A", "Speak Greek");
            items.Add("B", "Sports car specialist");
            items.Add("C", "Family car specialist");
            items.Add("D", "Tradie vehicle specialist");
        }
        public string GetGroupByName(string value)
        {
            return items.FirstOrDefault(s => s.Value.Contains(value)).Key;
        }
    }
}

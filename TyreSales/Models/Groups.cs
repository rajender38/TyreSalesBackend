using System.Collections.Generic;
using System.Linq;
using TyreSales.Constants;
using TyreSales.Interface;

namespace TyreSales.Models
{
    public class Groups : IGroups
    {
        public IDictionary<string, GroupDetails> items = new Dictionary<string, GroupDetails>();
        public Groups()
        {
            items.Add("A", new GroupDetails() { Name = "Speak Greek", Type = GroupTypes.Language });
            items.Add("B", new GroupDetails() { Name = "Sports car specialist", Type = GroupTypes.CarType });
            items.Add("C", new GroupDetails() { Name = "Family car specialist", Type = GroupTypes.CarType });
            items.Add("D", new GroupDetails() { Name = "Tradie vehicle specialist", Type = GroupTypes.CarType });
            items.Add("E", new GroupDetails() { Name = "Speak French", Type = GroupTypes.Language });

        }

        public IDictionary<string, GroupDetails> GetGroupByName(string[] groupId)
        {
            return items.Where(s => groupId.Contains(s.Key)).ToDictionary(s => s.Key, r => r.Value);
        }
    }
}

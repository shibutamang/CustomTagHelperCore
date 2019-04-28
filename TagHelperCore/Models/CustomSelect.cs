using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperCore.Models
{
    public class CustomSelect
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class GetValues
    {
        public List<CustomSelect> GetOptions()
        {
            List<CustomSelect> items = new List<CustomSelect>();
            items.Add(new CustomSelect() { Name = "Option1", Value = 1 });
            items.Add(new CustomSelect() { Name = "Option2", Value = 2 });

            return items;
        }
    }

}

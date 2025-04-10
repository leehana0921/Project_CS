using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_CS
{
    public class Inventory
    {
        public List<string> items;

        public Inventory()
        {
            items = new List<string>();
        }

        public void Add(string item)
        {
            items.Add(item);
        }

        public void Remove(string item)
        {
            items.Remove(item);
        }
    }
}

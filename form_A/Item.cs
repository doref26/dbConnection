using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_A
{
    class Item
    {
        string name;
        string description;
        int price;

        public string Name { get { return name; } set {; } }
        public string Description { get { return description; } set {; } }

        public int Price { get { return price; } set {; } }

        public Item(string name, string desc, int price)
        {
            this.name = name;
            this.description = desc;
            this.price = price;
        }
    }
}

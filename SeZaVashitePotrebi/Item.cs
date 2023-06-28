using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeZaVashitePotrebi
{
    internal class Item
    {

        public string Name { get; set; }
        public ItemType Type { get; set; }
        public int Period { get; set; } // Used for rental items, represents the rental period in days
        public decimal Price { get; set; } // Used for items available for purchase

        public Item(string name, ItemType type, int period, decimal price)
        {
            Name = name;
            Type = type;
            Period = period;
            Price = price;
        }
    }

    public enum ItemType
    {
        Rent,
        Buy
    }


}

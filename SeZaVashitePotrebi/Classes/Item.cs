using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeZaVashitePotrebi
{
    public class Item
    {

        public string Name { get; set; }
        public ItemCategory Category { get; set; }
        public ItemType Type { get; set; }
        public int Period { get; set; } // Used for rental items, represents the rental period in days
        public decimal Price { get; set; } // Used for items available for purchase

        public string Image { get; set; }

        public Item(string name, ItemType type, ItemCategory itemCategory, int period, decimal price, string image)
        {
            Name = name;
            Type = type;
            Period = (int)period;
            Price = price;
            Image = image;
            Category = itemCategory;
        }
    }

    public enum ItemType
    {
        Rent,
        Buy
    }

    public enum ItemCategory
    {
        All,
        Electronics,
        Books,
        Clothing,
        Vehicle
    }

}

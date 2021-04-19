using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    class Item
    {
        public string Name { get; set; }

        public int Price { get; set; }

        //public int ItemsRemaining { get; set; }

        public Item(string productName, int price/*, int itemsRemaining*/)
        {
            Name = productName;
            Price = price;
            //ItemsRemaining = itemsRemaining;
        }
    }

}

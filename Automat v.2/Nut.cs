using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    enum NutTypes
    {
        Cashew,
        Almonds,
        ChiliNuts,
        Peanuts
    }
    class Nut : Item
    {
        public NutTypes TypeNut { get; set; }
        public Nut(string productName, int price, NutTypes nuts) : base(productName, price)
        {
            TypeNut = nuts;
        }
    }
}

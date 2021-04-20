using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    enum Flavour
    {
        Cherry,
        Strawberry,
        Original,
        SugarFree
    }
    class Soda : Item
    {
        public Soda(string productName, int price, Flavour flavour): base(productName, price)
        {

        }
    }
}

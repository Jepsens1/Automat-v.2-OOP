using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    enum Candytypes
    {
        MatadorMix,
        ClickMix,
        Dragula

    }
    class Candy : Item
    {
        public Candytypes TypeCandy { get; set; }
        public Candy(string productName, int price, Candytypes type): base(productName, price)
        {
            TypeCandy = type;
        }
    }
}

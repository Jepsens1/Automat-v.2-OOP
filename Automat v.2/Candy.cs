using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    enum Candytype
    {
        MatadorMix,
        ClickMix,
        Dragula

    }
    class Candy : Item
    {
        public Candy(string productName, int price, Candytype type): base(productName, price)
        {

        }
    }
}

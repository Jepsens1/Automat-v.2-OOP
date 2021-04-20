using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    class Human
    {
        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public int Money { get; set; }
        public Human()
        {

        }
        public Human(int _money)
        {
            Money = _money;
            Items = items;
            
        }
    }
}

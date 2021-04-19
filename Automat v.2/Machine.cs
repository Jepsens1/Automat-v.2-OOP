using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    class Machine
    {
        public { get; set; }

        public Machine()
        {
            
        }
        public void ShowBeerSelection()
        {
            Console.WriteLine("Please select a Beer you would like");
            Console.WriteLine("*********************");
            Console.WriteLine("* C - RoyalBeer");
            Console.WriteLine("* B - Carlsberg");
            Console.WriteLine("* A - Tuborg Classic");
            Console.WriteLine("*********************");
        }
        public void MakeBeerSelection(string selection, Human user)
        {
            bool selectionIsValid = false;
            while (!selectionIsValid)
            {
                switch (selection)  
                {
                    case "C":
                        if (user.Money > 5)
                        {
                            Console.WriteLine("Thank you for choosing RoyalBeer");
                            user.BeerList.Add()
                        }
                        break;
                        
                    default:
                        break;
                }
            }
        }
    }
}

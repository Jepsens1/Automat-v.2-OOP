using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    class Machine
    {

        public List<Item> Items { get; set; }


        public Machine()
        {

        }
        public void ShowBeerSelection()
        {
            Console.WriteLine("Please select a item you would like");
            Console.WriteLine("*********************");
            Console.WriteLine("* A - Fanta");
            Console.WriteLine("* B - Cashew nuts");
            Console.WriteLine("* C - Bubblegum");
            Console.WriteLine("* D - Haribo");
            Console.WriteLine("* E - Doritos");
            Console.WriteLine("*********************");
        }
        //public void AddItemsToMachine()
        //{
        //    Items.Add(new Soda("Fanta", 5));
        //    Items.Add(new Nut("Cashew", 8));
        //    Items.Add(new Gum("Bubblegum", 3));
        //    Items.Add(new Candy("Haribo", 8));
        //    Items.Add(new Chip("Doritos", 5));
        //}
        public void MakeSelection(string selection, Human user)
        {
            switch (selection)
            {
                case "a":
                    if (user.Money >= 5)
                    {
                        Console.WriteLine("Thank you for choosing Fanta");
                        Console.WriteLine("Which flavour would you like?");
                        Console.WriteLine("1. Cherry    2. Strawberry   3. Original   4. SugarFree");
                        string userinput = Console.ReadLine();
                        if (userinput == "1")
                        {
                            user.Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.Cherry));
                        }
                        else if (userinput == "2")
                        {
                            user.Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.Strawberry));
                           
                        }
                        else if (userinput == "3")
                        {
                            user.Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.Original));
                            
                        }
                        else if (userinput == "4")
                        {
                            user.Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.SugarFree));
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "b":
                    if (user.Money >= 8)
                    {
                        Console.WriteLine("Thank you for choosing Cashew");
                        user.Money -= 8;
                        user.Items.Add(new Nut("Cashew", 8));
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "c":
                    if (user.Money >= 3)
                    {
                        Console.WriteLine("Thank you for choosing Bubblegum");
                        user.Money -= 3;
                        user.Items.Add(new Gum("Bubblegum", 3));
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "d":
                    if (user.Money >= 8)
                    {
                        Console.WriteLine("Thank you for choosing Haribo");
                        user.Money -= 8;
                        user.Items.Add(new Candy("Haribo", 8));
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "e":
                    if (user.Money >= 5)
                    {
                        Console.WriteLine("Thank you for choosing Doritos");
                        user.Money -= 5;
                        user.Items.Add(new Chip("Doritos", 5));
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}


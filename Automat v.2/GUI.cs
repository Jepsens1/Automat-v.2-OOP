using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    class GUI
    {
        Machine machine = new Machine();
        Human human = new Human(20);
        public void StartMenu()
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
        public void MainMenu()
        {
            StartMenu();
            string userinput = Console.ReadLine();
            machine.MakeSelection(userinput, human);


        }
    }
}

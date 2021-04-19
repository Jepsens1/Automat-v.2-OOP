using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_v._2
{
    class GUI
    {
        public void StartMenu()
        {
            Console.WriteLine("Select which beer you would like");
            Console.WriteLine("1. Tuborg Classic");
            Console.WriteLine("2. Carlsberg");
            Console.WriteLine("3. Royal Beer");
        }
        public void MainMenu()
        {
            StartMenu();
            int userinput = Convert.ToInt32(Console.ReadLine());


        }
    }
}

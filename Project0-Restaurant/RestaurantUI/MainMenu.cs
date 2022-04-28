using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Restaurant Reviews!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press <2> to Search Restaurants");
            Console.WriteLine("Press <1> to Join the App");
            Console.WriteLine("Press <0> to Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "Join the App";
                case"2":
                    return "Search Restaurants";
                default:
                    Console.WriteLine("Please select a valid option");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";

            }
        }
    }
}

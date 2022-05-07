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
            Console.WriteLine("Welcome To Restaurant Reviews!");
            Console.WriteLine("Please View And Select From The Options Below");
            Console.WriteLine("Press <1> To Join The App");
            Console.WriteLine("Press <2> To Add A Restaurant");
            Console.WriteLine("Press <3> To Review A Restaurant");
            Console.WriteLine("Press <4> To Search All Restaurants");
            Console.WriteLine("Press <5> If You Are An *Admin*");
            Console.WriteLine("Press <0> To Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "Join The App";
                case "2":
                    return "Add Restaurant";
                case "3":
                    return "Review Restaurant";
                case "4":
                    return "Search Restaurants";
                case "5":
                    return "Admin Login";
                default:
                    Console.WriteLine("Please select a valid option");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";

            }
        }
    }
}

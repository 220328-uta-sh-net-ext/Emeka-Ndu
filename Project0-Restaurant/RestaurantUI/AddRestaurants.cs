using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBL;
using RestaurantModels;


namespace RestaurantUI
{
    internal class AddRestaurants : IMenu
    {
        //private static Restuarant newRestaurant = new restaurant();

        //private IRepository _repository = new Repository(); //UpCasting
        //private IRestaurantLogic _repository = new RestaurantLogic();
        public void Display()
        {
            Console.WriteLine("Enter Restaurant Information");
            Console.WriteLine("<3> Rate Restaurant");
            //Console.WriteLine("<2> Name - " + newRestaurant.Name);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                   /* try
                    {
                        Log.Information("Adding a restaurant - " + newRestaurant.Name);
                        _repository.AddRestaurant(newRestaurant);
                        Log.Information("Restaurant added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add restaurant");
                        Console.WriteLine(ex.Message);

                    }*/
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter a level ");
                    //newRestaurant.Level = Convert.ToInt32(Console.ReadLine());
                    return "AddRestaurant";
                case "3":
                    Console.Write("Please enter a name! ");
                   // newRestaurant.Name = Console.ReadLine();
                    return "AddRestaurant";
                /// Add more cases for any other attributes of restarant
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddRestaurant";
            }
        }
    }
}
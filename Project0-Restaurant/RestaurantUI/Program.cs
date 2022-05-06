﻿using RestaurantUI;
using RestaurantBL;
using RestaurantDL;
using RestaurantModels;
using Serilog;

bool repeat = true;
IMenu menu = new MainMenu();

string connectionStringFilePath = "../../../../RestaurantDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

//string connectionStringFilePath = "../../../../Confidential-string.txt";
//string connectionString = File.ReadAllText(connectionStringFilePath);

//string connectionStrringFilePath = "C:/Users/nduag/OneDrive/Repos/Emeka-Ndu/Project0-Restaurant/RestaurantDL/connection-string.txt";
//string connectionStrring = File.ReadAllText(connectionStrringFilePath);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Users/nduag/OneDrive/Repos/Emeka-Ndu/Project0-Restaurant/RestaurantUI/Log.txt")
    .CreateLogger();



while (repeat)
{
    menu.Display();
    string input = menu.UserChoice();

    switch (input)
    {
        case "Join The App":
            //call join app method
            Console.WriteLine("Joing the app method under implementation...");
            break;
        case "Add Restaurant":
            //call add restaurant method
            Console.WriteLine("Add new Restaurant method under implementation...");
            break;
        case "Review Restaurant":
            Console.WriteLine("Review restaurant method under implementation...");
            break;
        case "Search Restaurants":
            Console.WriteLine("Search restaurants database under implementation...");
            break;
        case "Admin Login":
            Console.WriteLine("Admin Login method is under implementation...");
            break;
        case "MainMenu":
            menu=new MainMenu();
            break;
        case "Exit":
            repeat=false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}


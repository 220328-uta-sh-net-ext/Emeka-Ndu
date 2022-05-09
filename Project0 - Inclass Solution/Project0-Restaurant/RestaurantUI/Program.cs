using RestaurantUI;
using RestaurantBL;
using RestaurantDL;
using RestaurantModels;
using Serilog;

bool repeat = true;
IMenu menu = new MainMenu();



/*Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Users/nduag/OneDrive/Repos/Emeka-Ndu/Project0-Restaurant/RestaurantUI/Log.txt")
    .CreateLogger();*/



while (repeat)
{
    menu.Display();
    string input = menu.UserChoice();

    switch (input)
    {
        case "Join The App":
            Console.WriteLine("Join method under implementation...");
            //call user model
            break;
        case "Add Restaurant":
            //call restaurant model
            Console.WriteLine("Add new Restaurant method under implementation...");
            break;
        case "Review Restaurant":
            //call review model
            Console.WriteLine("Review restaurant method under implementation...");
            break;
        case "Search Restaurants":
            // call restaurant model
            //menu = new SearchRestaurantMenu();
            Console.WriteLine("Search restaurants database under implementation...");
            break;
        case "Admin Login":
            // call admin model
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
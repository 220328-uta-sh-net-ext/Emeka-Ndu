using RestaurantUI;

bool repeat = true;
IMenu menu = new MainMenu();

string connectionStringFilePath = "../../../../RestaurantDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);



while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
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


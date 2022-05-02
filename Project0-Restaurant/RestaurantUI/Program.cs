using RestaurantUI;

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "Join The App":
            //call join app method
            Console.WriteLine("Joing working...");
            break;
        case "Add Restaurant":
            //call add restaurant method
            Console.WriteLine("Add working...");
            break;
        case "Review Restaurant":
            Console.WriteLine("Review working...");
            break;
        case "Search Restaurants":
            Console.WriteLine("Search working...");
            break;
        case "Admin Login":
            Console.WriteLine("Admin Login working...");
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


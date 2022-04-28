using RestaurantUI;

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "Join the App":
            break;
        case "Search Restaurants":
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


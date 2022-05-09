namespace RestaurantModels;

  public class Restaurant
{
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }

    public Restaurant()
    {
        Name = string.Empty;
        City = string.Empty;
        State = string.Empty;
        Zipcode = string.Empty;
    }
}






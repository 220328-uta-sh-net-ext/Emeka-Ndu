namespace RestaurantModels
{
  public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string Location { get; set; }
        
        public User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;   
            Password = string.Empty;
            Location = string.Empty;
        }
    }
   
        

}
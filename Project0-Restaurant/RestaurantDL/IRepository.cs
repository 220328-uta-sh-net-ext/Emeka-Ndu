using System.Collections.Generic;
using RestaurantModels;

namespace RestaurantDL
{
    public interface IRepository
    {
        /// <summary>
        /// Add a user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>The user added</returns>
        Users GetUsername(Users user);
        /// <summary>
        /// This method returns all the restaurants from the database
        /// </summary>
        /// <returns>Returns a collection of restaurants as Generic List</returns>
        /// 
        /// <summary>
        /// Adds a resturant to the database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant rest);
        /// <summary>
        /// The method returns all restaurants from the database
        /// </summary>
        /// <returns></returns>
        List<Restaurant> GetRestaurantInfo();


        Review AddReview(Review reviewToAdd);

        List<Review> GetReviewInfo();
        List<Review> SearchRestaurants(string searchTerm);
        bool IsDuplicate(Restaurant restaurant);

        User AddUser(User user);
        List<User> GetUsersInfo();
        List<Review> GetAverage();

    }
}


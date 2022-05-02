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
        List<Restuarants> GetAllRestaurants();

    }
}


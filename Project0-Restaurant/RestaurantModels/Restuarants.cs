using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModels
{
    public class Restuarant
    {
        public string Restaurantname { get; set; }
        public string Restaurantcity { get; set; }
        public int Restaurantid { get; set; }
        public int Restaurantzipcode { get; set; }

    }

    public class RestuarantReviews 
    {
        public string Review { get; set; }
        public int Rating { get; set; }
        public int Reviewdate { get; set; }
        
    }



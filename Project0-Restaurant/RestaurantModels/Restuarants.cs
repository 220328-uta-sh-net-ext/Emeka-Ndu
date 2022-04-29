using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModels
{
    internal class Restuarants
    {
        public string Restaurantname { get; set; }
        public string Restaurantcity { get; set; }
        public int Restaurantid { get; set; }
        public int Resuarantzipcode { get; set; }

    }

    internal class RestuarantReviews 
    {
        public string Review { get; set; }
        public int Rating { get; set; }
        public int Reviewdate { get; set; }
        
    }
}

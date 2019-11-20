using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkpoin2.core.Services;
using CheckPoint2.core.Models;
using Checkpoin2.Infrastructure.Data;


namespace CheckPoint2.core.Services
{

    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepo _restaurantContext;

        public RestaurantService(IRestaurantRepo RestaurantContext)
        {
            _restaurantContext = RestaurantContext;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantContext.GetAll();

        }
        public Restaurant Get(int id)
        {
            return _restaurantContext.Get(id);
        }
        public Restaurant Add(Restaurant restaurant)
        {
            
            return _restaurantContext.Add(restaurant);
        }
        public Restaurant Update(Restaurant updatedRestaurant)
        {
            
            return _restaurantContext.Update(updatedRestaurant);
        }
        public void Remove(Restaurant restaurant)
        {
            _restaurantContext.Remove(restaurant);

        }

    }
}

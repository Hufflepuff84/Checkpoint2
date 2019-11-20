using System.Collections.Generic;
using CheckPoint2.core.Models;

namespace CheckPoint2.Infrastructure.Data
{
    public interface IRestaurantRepo
    {
        Restaurant Add(Restaurant restaurant);
        Restaurant Get(int id);
        IEnumerable<Restaurant> GetAll();
        void Remove(Restaurant restaurant);
        Restaurant Update(Restaurant updatedRestaurant);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckPoint2.core.Models;

namespace Checkpoin2.core.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
        void Remove(Restaurant restaurant); // (variable type)
    }
}
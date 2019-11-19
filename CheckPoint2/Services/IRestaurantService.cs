using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApi.Models;

namespace BookApi.Services
{
    public interface IBookService
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
        void Remove(Restaurant restaurant); // (variable type)
    }
}
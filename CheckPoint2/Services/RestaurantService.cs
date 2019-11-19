using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApi.Data;
using RestaurantApi.Models;

namespace RestaurantApi.Services
{

    public class BookService : IRestaurantService
    {
        private readonly RestaurantContext _restaurantContext;

        public BookService(RestaurantContext bookContext)
        {
            _restaurantContext = bookContext;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantContext.Books.ToList();

        }
        public Restaurant Get(int id)
        {
            return _restaurantContext.Books.FirstOrDefault(b => b.Id == id);
        }
        public Restaurant Add(Restaurant restaurant)
        {
            _restaurantContext.Books.Add(restaurant);
            _restaurantContext.SaveChanges();
            return restaurant;
        }
        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var currentRestaurant = _restaurantContext.Restaurants.FirstOrDefault(b => b.Id == updatedRestaurant.Id);
            if (currentRestaurant == null) return null;
            _restaurantContext.Entry(currentRestaurant).CurrentValues
                .SetValues(updatedRestaurant);
            _restaurantContext.Books.Update(currentRestaurant);
            _restaurantContext.SaveChanges();
            return currentRestaurant;
        }
        public void Remove(Restaurant restaurant)
        {
            _restaurantContext.Books.Remove(restaurant);
            _restaurantContext.SaveChanges();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Services;
using RestaurantApi.Models;

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/values
        private readonly IRestaurantService _restaurantService;
        public BooksController(IRestaurant restaurantService)
        {
            _restaurantService = restaurantService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_restaurantService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var restaurant = _restaurantService.Get(id);
            if (restaurant == null) return NotFound();
            return Ok(restaurant);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Restaurant newRestaurant)
        {
            var restaurant = _restaurantService.Add(newRestaurant);
            if (restaurant == null) return BadRequest();
            return CreatedAtAction("Get", new { id = newRestaurant.Id }, newRestaurant);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Restaurant updatedRestaurant)
        {
            var book = _restaurantService.Update(updatedRestaurant);
            if (book == null) return BadRequest();
            return Ok(book);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var restaurant = _restaurantService.Get(id);
            if (restaurant == null) return NotFound();
            _restaurantService.Remove(restaurant);
            return NoContent();

        }
    }
}
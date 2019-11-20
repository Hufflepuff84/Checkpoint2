using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheckPoint2.core.Services;
using CheckPoint2.core.Models;
using Checkpoin2.core.Services;

namespace Checkpoint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        // GET api/values
        private readonly IRestaurantService _restaurantService;
        public RestaurantsController(IRestaurantService restaurantService)
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
            var restaurant = _restaurantService.Update(updatedRestaurant);
            if (restaurant == null) return BadRequest();
            return Ok(restaurant);
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
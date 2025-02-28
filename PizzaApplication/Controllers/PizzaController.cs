using Microsoft.AspNetCore.Mvc;
 
using PizzaApplication.Models;
using System.Collections.Generic;

namespace PizzaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        // This is the in-memory list of pizzas
        private static readonly List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Margherita", Description = "Classic pizza with mozzarella and tomato sauce", Price = 8.99m },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Pizza topped with pepperoni slices", Price = 9.99m }
        };

        // Get all pizzas
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> GetPizzas()
        {
            return Ok(Pizzas);
        }

        // Get a specific pizza by id
        [HttpGet("{id}")]
        public ActionResult<Pizza> GetPizza(int id)
        {
            var pizza = Pizzas.Find(p => p.Id == id);
            if (pizza == null)
            {
                return NotFound();
            }
            return Ok(pizza);
        }

        // Add a new pizza
        [HttpPost]
        public ActionResult<Pizza> PostPizza(Pizza pizza)
        {
            pizza.Id = Pizzas.Count + 1; // Auto-generate ID for the new pizza
            Pizzas.Add(pizza);
            return CreatedAtAction(nameof(GetPizza), new { id = pizza.Id }, pizza);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;


namespace PizzaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly Services.IPizzaService _pizzaService;

        public PizzasController(Services.IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        // Get all pizzas
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> GetPizzas()
        {
            var pizzas = _pizzaService.GetAllPizzas();
            return Ok(pizzas);
        }

        // Get a specific pizza by id
        [HttpGet("{id}")]
        public ActionResult<Pizza> GetPizza(int id)
        {
            var pizza = _pizzaService.GetPizzaById(id);
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
            if (string.IsNullOrEmpty(pizza.Size))
            {
                return BadRequest("Pizza size must be provided.");
            }

            var createdPizza = _pizzaService.AddPizza(pizza);
            return CreatedAtAction(nameof(GetPizza), new { id = createdPizza.Id }, createdPizza);
        }
    }
}

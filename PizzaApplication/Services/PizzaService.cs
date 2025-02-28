 
using PizzaApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApplication.Services
{
    public interface IPizzaService
    {
        IEnumerable<Pizza> GetAllPizzas();
        Pizza GetPizzaById(int id);
        Pizza AddPizza(Pizza pizza);
    }

    public class PizzaService : IPizzaService
    {
        private static readonly List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Margherita", Description = "Classic pizza with mozzarella and tomato sauce", Price = 8.99m },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Pizza topped with pepperoni slices", Price = 9.99m }
        };

        public IEnumerable<Pizza> GetAllPizzas()
        {
            return Pizzas;
        }

        public Pizza GetPizzaById(int id)
        {
            return Pizzas.FirstOrDefault(p => p.Id == id);
        }

        public Pizza AddPizza(Pizza pizza)
        {
            pizza.Id = Pizzas.Count + 1;  // Auto-generate ID for the new pizza
            Pizzas.Add(pizza);
            return pizza;
        }
    }
}

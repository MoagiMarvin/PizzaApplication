
using PizzaApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services
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
            // Margherita pizza in all sizes
            new Pizza { Id = 1, Name = "Margherita", Description = "Classic pizza with mozzarella and tomato sauce", Price = 8.99m, Size = "Small" },
            new Pizza { Id = 2, Name = "Margherita", Description = "Classic pizza with mozzarella and tomato sauce", Price = 10.49m, Size = "Medium" },
            new Pizza { Id = 3, Name = "Margherita", Description = "Classic pizza with mozzarella and tomato sauce", Price = 12.99m, Size = "Large" },
            
            // Pepperoni pizza in all sizes
            new Pizza { Id = 4, Name = "Pepperoni", Description = "Pizza topped with pepperoni slices", Price = 9.99m, Size = "Small" },
            new Pizza { Id = 5, Name = "Pepperoni", Description = "Pizza topped with pepperoni slices", Price = 11.49m, Size = "Medium" },
            new Pizza { Id = 6, Name = "Pepperoni", Description = "Pizza topped with pepperoni slices", Price = 13.99m, Size = "Large" },

            // Hawaiian pizza in all sizes
            new Pizza { Id = 7, Name = "Hawaiian", Description = "Ham and pineapple pizza", Price = 10.99m, Size = "Small" },
            new Pizza { Id = 8, Name = "Hawaiian", Description = "Ham and pineapple pizza", Price = 12.49m, Size = "Medium" },
            new Pizza { Id = 9, Name = "Hawaiian", Description = "Ham and pineapple pizza", Price = 14.99m, Size = "Large" },

            // BBQ Chicken pizza in all sizes
            new Pizza { Id = 10, Name = "BBQ Chicken", Description = "Grilled chicken with BBQ sauce", Price = 11.99m, Size = "Small" },
            new Pizza { Id = 11, Name = "BBQ Chicken", Description = "Grilled chicken with BBQ sauce", Price = 13.49m, Size = "Medium" },
            new Pizza { Id = 12, Name = "BBQ Chicken", Description = "Grilled chicken with BBQ sauce", Price = 15.99m, Size = "Large" },

            // Veggie pizza in all sizes
            new Pizza { Id = 13, Name = "Veggie", Description = "Pizza with mushrooms, onions, peppers, and olives", Price = 7.99m, Size = "Small" },
            new Pizza { Id = 14, Name = "Veggie", Description = "Pizza with mushrooms, onions, peppers, and olives", Price = 9.49m, Size = "Medium" },
            new Pizza { Id = 15, Name = "Veggie", Description = "Pizza with mushrooms, onions, peppers, and olives", Price = 11.99m, Size = "Large" },

            // Meat Lovers pizza in all sizes
            new Pizza { Id = 16, Name = "Meat Lovers", Description = "Topped with pepperoni, sausage, bacon, and ground beef", Price = 12.99m, Size = "Small" },
            new Pizza { Id = 17, Name = "Meat Lovers", Description = "Topped with pepperoni, sausage, bacon, and ground beef", Price = 14.49m, Size = "Medium" },
            new Pizza { Id = 18, Name = "Meat Lovers", Description = "Topped with pepperoni, sausage, bacon, and ground beef", Price = 16.99m, Size = "Large" },

            // Four Cheese pizza in all sizes
            new Pizza { Id = 19, Name = "Four Cheese", Description = "Mozzarella, cheddar, parmesan, and goat cheese", Price = 10.49m, Size = "Small" },
            new Pizza { Id = 20, Name = "Four Cheese", Description = "Mozzarella, cheddar, parmesan, and goat cheese", Price = 12.49m, Size = "Medium" },
            new Pizza { Id = 21, Name = "Four Cheese", Description = "Mozzarella, cheddar, parmesan, and goat cheese", Price = 14.99m, Size = "Large" },

            // Supreme pizza in all sizes
            new Pizza { Id = 22, Name = "Supreme", Description = "Pepperoni, sausage, mushrooms, onions, and peppers", Price = 13.49m, Size = "Small" },
            new Pizza { Id = 23, Name = "Supreme", Description = "Pepperoni, sausage, mushrooms, onions, and peppers", Price = 15.49m, Size = "Medium" },
            new Pizza { Id = 24, Name = "Supreme", Description = "Pepperoni, sausage, mushrooms, onions, and peppers", Price = 17.99m, Size = "Large" },

            // Chicken Alfredo pizza in all sizes
            new Pizza { Id = 25, Name = "Chicken Alfredo", Description = "Grilled chicken, Alfredo sauce, and mozzarella", Price = 11.49m, Size = "Small" },
            new Pizza { Id = 26, Name = "Chicken Alfredo", Description = "Grilled chicken, Alfredo sauce, and mozzarella", Price = 13.49m, Size = "Medium" },
            new Pizza { Id = 27, Name = "Chicken Alfredo", Description = "Grilled chicken, Alfredo sauce, and mozzarella", Price = 15.49m, Size = "Large" }
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

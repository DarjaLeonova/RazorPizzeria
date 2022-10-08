using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class Pizza : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4.50f
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese", 
                PizzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Beef = true,
                FinalPrice = 16.40f
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian", 
                PizzaName = "Hawaiian",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Ham = true,
                Pineapple = true,
                FinalPrice = 15 
            },
            new PizzasModel()
            {
                ImageTitle = "Carbonara", 
                PizzaName = "Carbonara",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Ham = true,
                Mushroom = true,
                FinalPrice = 13.00f
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast", 
                PizzaName = "MeatFest",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Ham = true,
                Beef = true,
                FinalPrice = 18.50f
            },
            new PizzasModel()
            {
                ImageTitle = "Mushroom", 
                PizzaName = "Mushroom",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                FinalPrice = 10.80f
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni", 
                PizzaName = "Pepperoni",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Peperoni = true,
                FinalPrice = 14.70f
            },
            new PizzasModel()
            {
                ImageTitle = "Seafood", 
                PizzaName = "Seafood",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Tuna = true,
                FinalPrice = 19.10f
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian", 
                PizzaName = "Vegetarian",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                Pineapple = true,
                FinalPrice = 12.90f
            },
        };
        public void OnGet()
        {
            
        }
    }
}
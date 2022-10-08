using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizza : PageModel
    {
       [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1.00f;
            if (Pizza.Cheese) PizzaPrice += 3.50f;
            if (Pizza.Peperoni) PizzaPrice += 2.00f;
            if (Pizza.Ham) PizzaPrice += 2.00f;
            if (Pizza.Pineapple) PizzaPrice += 1.90f;
            if (Pizza.Tuna) PizzaPrice += 6.00f;
            if (Pizza.Mushroom) PizzaPrice += 2.30f;
            if (Pizza.Beef) PizzaPrice += 9.50f;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
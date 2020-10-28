using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronForge.Models;
using IronForge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IronForge.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartPriceTotal = _shoppingCart.GetShoppingCartPriceTotal(),
                ShoppingCartItemTotal = _shoppingCart.GetShoppingCartItemTotal()

            };
            return View(shoppingCartViewModel);
        }
    }
}

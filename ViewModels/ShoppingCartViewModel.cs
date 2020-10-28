using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronForge.Models;

namespace IronForge.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartPriceTotal { get; set; }
        public int ShoppingCartItemTotal { get; set; }
    }
}

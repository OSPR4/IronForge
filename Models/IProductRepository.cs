using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IronForge.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        Product GetProductById(int productId);
    }
}

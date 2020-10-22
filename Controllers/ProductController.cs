using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronForge.Models;
using IronForge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IronForge.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;

        }

        //public IActionResult List()
        //{
        //    ProductListViewModel productListViewModel = new ProductListViewModel();
        //    productListViewModel.Products = _productRepository.AllProducts;

        //    return View(productListViewModel);
        //}

        //public IActionResult List()
        //{
        //    ProductListViewModel productListViewModel = new ProductListViewModel();
        //    productListViewModel.Products = _productRepository.AllProducts;

        //    return View(productListViewModel);
        //}
        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.Name == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.Name == category)?.Name;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}

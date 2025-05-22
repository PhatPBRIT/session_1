using Microsoft.AspNetCore.Mvc;
using session_1.Models.Interfaces;

namespace session_1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IActionResult Shop()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
    }
}
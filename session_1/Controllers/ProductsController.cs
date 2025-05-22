    using Microsoft.AspNetCore.Mvc;
    using session_1.Models.Interfaces;
    using session_1.Models;

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
                var product = _productRepository.GetAllProducts();

           
                if (product == null)
                {
                    product = new List<Product>();
                }

                return View(product);
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

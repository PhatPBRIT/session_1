using session_1.Models;
using session_1.Models.Interfaces;

namespace session_1.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _productsList = new List<Product>
        {
            new Product { Id = 1, Name = "America", Price = 25, Detail = "Name product", ImageUrl = "https://index.com", IsTrendingProduct = false },
            new Product { Id = 2, Name = "Vietnam", Price = 20, Detail = "Vietnamese product", ImageUrl = "https://index.com", IsTrendingProduct = true },
            new Product { Id = 3, Name = "United Kingdom", Price = 15, Detail = "UK product", ImageUrl = "https://index.com", IsTrendingProduct = true }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _productsList;
        }

        public Product? GetProductDetail(int id)
        {
            return _productsList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return _productsList.Where(p => p.IsTrendingProduct);
        }
    }
}
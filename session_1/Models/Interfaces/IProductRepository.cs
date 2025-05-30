﻿using session_1.Models.Interfaces;

namespace session_1.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetTrendingProducts();
        Product? GetProductDetail(int id);
    }
}
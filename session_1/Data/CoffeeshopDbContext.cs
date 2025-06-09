using session_1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace session_1.Data
{
    public class CoffeeShopDbContext : IdentityDbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Contact> ContactMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "America", Price = 25, Detail = "Name product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection. ", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 2, Name = "Vietnam", Price = 20, Detail = "Vietnamese product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 3, Name = "United Kingdom", Price = 15, Detail = "UK product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 4, Name = "India", Price = 15, Detail = "India product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 5, Name = "Russian", Price = 25, Detail = "Russian product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 6, Name = "France", Price = 35, Detail = "France product Coffee is one of the most beloved beverages around the world. Known for its rich aroma and energizing properties, it plays an essential role in daily routines. From a quick espresso shot to a creamy latte, coffee comes in countless varieties to suit every taste. Beyond its flavor, coffee brings people together in cafés, conversations, and moments of reflection.", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true }

            );
        }
    }
}
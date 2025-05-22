using Microsoft.EntityFrameworkCore;
using session_1.Data;
using session_1.Models.Interfaces;
using session_1.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CoffeeShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeShopDbContextConnection")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "product",
    pattern: "{controller=Product}/{action=ListAll}/{id?}");

app.MapControllerRoute(
    name: "shop",
    pattern: "{controller=Product}/{action=Shop}/{id?}");

app.Run();
using session_1.Models.Interfaces;
using session_1.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default", // ??i t�n route th�nh "default" ?? tr�nh xung ??t
    pattern: "{controller=Products}/{action=Shop}/{id?}"); // S?a "Product" th�nh "Products" ?? kh?p v?i ProductsController

app.Run();
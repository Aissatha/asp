using Microsoft.EntityFrameworkCore;
using My_FirstApp;
using My_FirstApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<My_FirstApp.AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseWelcomePage("/");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//endpoint hello world lorsque le path / est appelé

app.UseAuthorization();
app.MapGet("/", () => "Hello world");
//Endpoint retourne C# object realisé en JSON data
app.MapGet("Movietest", () => new Movie());
app.MapGet("Product/Test1", () => "Test1");
app.MapGet("Product/Test2", () => "Test2");
//l'URL se mappe à un hendler unique et query string est 
//utilisé pour montrer les datas dynamiques
//product?name =produit1
app.MapGet("product", (string name) => name);
//1.qnnote le route avec le nom Hello 
//2.génère une reponse qui envoie une redirection 
//à l'endpoint
app.MapGet("/test", () => "Hello world").WithName("Hello");
app.MapGet("/redirect-me",()=> Results.RedirectToRoute("Hello"));
//Routing mapps url to a single handler and the url
//segment identifies dynamic data
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

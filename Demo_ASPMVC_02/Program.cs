using Demo_ASPMVC_02.DAL;
using Demo_ASPMVC_02.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Pokedex Context
builder.Services.AddDbContext<PokedexContext>(
    b => b.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

//Repositories
builder.Services.AddScoped<PokemonRepository>();
builder.Services.AddScoped<TypeRepository>();

//Services

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

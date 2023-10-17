using Microsoft.EntityFrameworkCore;
using SneakersProjetoFinal.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*builder.Services.AddDbContext<Contexto> //MARREGA
    (options => options.UseSqlServer("Data Source=SP-1491038\\SQLSENAI;Initial Catalog = SneakersProjetoFinal;Integrated Security = True;TrustServerCertificate = true"));*/

/*builder.Services.AddDbContext<Contexto> //PAULO
    (options => options.UseSqlServer("Data Source=SP-1491005\\SQLSENAI;Initial Catalog = SneakersProjetoFinal;Integrated Security = True;TrustServerCertificate = true"));*/

/*builder.Services.AddDbContext<Contexto> //VITOR
    (options => options.UseSqlServer("Data Source=SP-1491026\\SQLSENAI;Initial Catalog = SneakersProjetoFinal;Integrated Security = True;TrustServerCertificate = true"));*/

/*builder.Services.AddDbContext<Contexto> //MENDES
    (options => options.UseSqlServer("Data Source=SP-1491036\\SQLSENAI;Initial Catalog = SneakersProjetoFinal;Integrated Security = True;TrustServerCertificate = true"));*/

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

app.Run();

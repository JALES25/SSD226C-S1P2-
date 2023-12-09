using Microsoft.EntityFrameworkCore;
using S2P1.Data;
using S2P1.Interfaces;
using S2P1.Repositories;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SQLiteDBContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IDBInitializer, DBInitializerRepo>();

builder.Services.AddScoped<IPerson, PersonRepo>(); // make PersonRepo available for dependency injection throughout the application

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

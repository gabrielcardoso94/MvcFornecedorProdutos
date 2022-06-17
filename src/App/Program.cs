using App.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Data.Context;
using Business.Interfaces;
using Data.Repository;
using Business.Models;
using App.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddIdentity(builder.Configuration);

builder.Services.AddDbContext<MeuDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.ResolveDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

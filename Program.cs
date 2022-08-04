using Microsoft.EntityFrameworkCore;
using RicetteDB.Data;

var Builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Builder.Services.AddRazorPages();

var App = Builder.Build();

// Configure the HTTP request pipeline.
if (!App.Environment.IsDevelopment())
{
    App.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    App.UseHsts();
}

App.UseHttpsRedirection();
App.UseStaticFiles();

App.UseRouting();

App.UseAuthorization();

App.MapRazorPages();

App.Run();

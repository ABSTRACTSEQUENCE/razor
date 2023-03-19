using Microsoft.AspNetCore.Mvc.Razor;
using razor;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
app.MapRazorPages();
app.UseDeveloperExceptionPage();
app.UseRouting();
app.Run();

using Core;
using Microsoft.Extensions.Options;
using System.Net.Mime;
using System.Web;


var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<FruitOptions>(options =>
{

    options.Name = "watermelon";
});

var app = builder.Build();

//app.MapGet("/Fruit", async (HttpContext context, IOptions<FruitOptions> FruitOptions) =>
//{
//    FruitOptions options = FruitOptions.Value;
//    await context.Response.WriteAsync($"{options.Name}, {options.Color}");

//});

app.UseMiddleware<FruitMiddleware>();

app.MapGet("/", () => "Hello World!");

app.Run();
 
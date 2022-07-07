using Ocelot.DependencyInjection;
using Ocelot.Middleware;



var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOcelot();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseOcelot().Wait();
app.UseAuthorization();
app.MapControllers();
app.Run();

using Atmosync.Web;
using Atmosync.Web.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7058/api/") }); 

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://192.168.1.3:9191/api/") });

// Register Api services
builder.Services.AddScoped<DHT22ApiService>();
builder.Services.AddScoped<MQ136ApiService>();
builder.Services.AddScoped<MQ7ApiService>();


await builder.Build().RunAsync();

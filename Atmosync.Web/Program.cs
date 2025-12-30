using Atmosync.Web;
using Atmosync.Web.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5033/api/") });

// Register Api services
builder.Services.AddScoped<DHT22ApiService>();
builder.Services.AddScoped<MQ136ApiService>();
builder.Services.AddScoped<MQ7ApiService>();


await builder.Build().RunAsync();

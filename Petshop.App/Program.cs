using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Petshop.App;
using Petshop.App.Classes;
using Petshop.App.Enums;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//Skillnaden mellan Singleton och AddScoped?
builder.Services.AddScoped<PetStore>();
//builder.Services.AddSingleton<PetStore>();

await builder.Build().RunAsync();

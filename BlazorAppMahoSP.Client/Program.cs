using BlazorAppMahoSP.Client;
using BlazorAppMahoSP.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//aqui se instancian los servicios
builder.Services.AddScoped<LibroService>();

builder.Services.AddScoped<TipoLibroService>();
await builder.Build().RunAsync();

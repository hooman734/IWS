using IWS.Plugin.InMemory;
using IWS.UseCase.Items;
using IWS.UseCase.PluginInterfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IWS.WebApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add custom services
builder.Services.AddSingleton<IRepository, Repository>();
builder.Services.AddTransient<IRetrieveAllItemsUseCase, RetrieveAllItemsUseCase>();

await builder.Build().RunAsync();
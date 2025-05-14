using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio; // Import the main namespace for the app

// Create the default WebAssembly host builder
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root component <App> in the HTML element with id="app"
builder.RootComponents.Add<App>("#app");

// Allow dynamic elements like <title>, <meta> inside the HTML head
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure an HttpClient service to use the app's base URL
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Build and run the Blazor WebAssembly app
await builder.Build().RunAsync();

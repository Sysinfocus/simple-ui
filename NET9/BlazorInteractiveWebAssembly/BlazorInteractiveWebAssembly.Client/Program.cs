using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Sysinfocus.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSysinfocus();

await builder.Build().RunAsync();

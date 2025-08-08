# Sysinfocus simple/ui
a Razor component library for Blazor, inspired by the shadcn/ui components. [Explore more about this UI Library @ BLAZOR.ART](https://blazor.art)

# Get [Free UI Templates](https://github.com/Sysinfocus/simple-ui-templates) built using Sysinfocus simple/ui library.

## THIS LIBRARY IS NOW - **FREE TO USE** - FOR ALL
Use the version 0.0.2.1 and above for free access.

## Setup Instructions

1.  Download the NuGet package `Sysinfocus.AspNetCore.Components` to your project.

2.  Add `@using Sysinfocus.AspNetCore.Components` to your `_import.razor` file.

3.  Add `builder.Services.AddSysinfocus(jsCssFromCDN: false);` to your `Program.cs` file.

4.  Add the following CSS to your project's appropriate file as this depends upon the type of project being used.
    ```
    /// For .NET 8
    <link rel="stylesheet" href="_content/Sysinfocus.AspNetCore.Components/styles.css" />
    <link rel="stylesheet" href="_content/Sysinfocus.AspNetCore.Components/Sysinfocus.AspNetCore.Components.bundle.scp.css" />
    
    /// For .NET 9
    <link rel="stylesheet" href="@Assets["_content/Sysinfocus.AspNetCore.Components/styles.css"]" />
    <link rel="stylesheet" href="@Assets["_content/Sysinfocus.AspNetCore.Components/Sysinfocus.AspNetCore.Components.bundle.scp.css"]" />
    ```

5.  Add the following initialization code to your `MainLayout.razor` or any layout file which you host the components.
    ```
    @inherits LayoutComponentBase
    @inject Initialization init

    <div @onclick="init.HandleMainLayoutClickEvent"> // this is required for some components to close on click outside of its hosting component.
      @Body
    </div>

    @code
    {
      protected override async Task OnAfterRenderAsync(bool firstRender)
      {
        // This initializes the theme for the components.
        // Then you can use init.ToggleTheme() to toggle between light and dark modes.    
        if (firstRender) await init.InitializeTheme(); 
      }
    }
    ```

6.  For non-interactive Blazor SSR, you need to add the `light` or `dark` class to `body` tag manually as it can't initialize automatically.
7.  For more information, you can download the samples from this repo which has all these steps done and the projects are ready to explore.
8.  To see the demo of each component, check out [Demo](https://blazor.art/)
9.  Check out the [Release Notes](ReleaseNotes.md)

---

For more information, you can download the samples from this repo which has all these steps done and the projects are ready to explore.
To see the demo of each component, check out [Demo](https://blazor.art/)

## Have issues?
Open an issue on this repo or email to issues@sysinfocus.com

# Sysinfocus simple/ui
a Razor component library for Blazor, inspired by the shadcn/ui components.

# THIS LIBRARY IS NOW - **FREE TO USE** - FOR ALL

## Setup Instructions

1.  Download the NuGet package `Sysinfocus.AspNetCore.Components` to your project.

2.  Add `@using Sysinfocus.AspNetCore.Components` to your `_import.razor` file.

3.  Add `builder.Services.AddSysinfocus();` to your `Program.cs` file.

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
8.  To see the demo of each component, check out [Demo GitHub Repo](https://sysinfocus.github.io/shadcn-inspired/)

---

# Release Notes

Release notes for **Version 0.0.2**

## Updates / Bug fixes
1. Updated **Textarea** and **Swipe** components with more parameters.
1. Fixed bugs in **Slider** component.

---

Release notes for **Version 0.0.1.9**

## Updates / Bug fixes
1. Updated **Accordion** component with bug fixes and new reduced animation.
1. Fixed bugs in **Widget**, **Checkbox** and updated properties *Style* and *Class* for **Badge** components.

---

Release notes for **Version 0.0.1.8**

## Updates / Bug fixes
1. Fixed bug with **CodeScanner** component for missing assembly reference.
1. Added **FileManager** component.

---

Release notes for **Version 0.0.1.7**

## Updates / Bug fixes
1. Added `ClearState` and `PopFromState` methods for `StateManager` to clear memory.
1. Fixed issues with **GeoLocation** component registering DotNet reference.

---

Release notes for **Version 0.0.1.6**

## Updates / Bug fixes
1. **SaveFilePicker** component updated to fallback to regular download, in case any browser doesn't support the new APIs.
1. Added new method to preload JS and CSS either all or some of the dependencies using `PreloadJSAndCSSDependencies` method of the ``Initialization`` class. This needs to be called in the **Layouts**.
1. Fixed tab focus issues for **Dialog** and **Alert Dialog** components.

---

Release notes for **Version 0.0.1.5**

## Updates / Bug fixes
1. **SpeechToText** component added.
1. **TextToSpeech** component added.
1. Added new property **ReadOnly** for **Input** and **TextArea** components.
1. Fixed UI for **Verify Human** component.
1. Now the JS and CSS dependencies are used from local components' folder. If you want them to be served from CDNs, you can use the **AddSysinfocus** method's `jsCssFromCDN` parameter and set it to `true`, which toggle's this feature. 

---

Release notes for **Version 0.0.1.4**

## Bug fixes
1. Fixed the issue in **Popover** component - [GitHub Issues #2](https://github.com/Sysinfocus/simple-ui/issues/2).
1. **Verify Human** component added.

---

Release notes for **Version 0.0.1.3**

## Bug fixes
1. Fixed the issue in Select component.

---

Release notes for **Version 0.0.1.2**

## Updates / Bug fixes

1. Added new event for marker movement `OnMarkerMoved` for **Maps** component.
1. Added `DistanceKilometers` and `DistanceMiles` methods to get distance between 2 locations in **Geolocation** component.
1. **Treeview** component added.
1. Following components have been made available in free tier.
	- Accordion
	- Alert
	- Dialog
	- Navigation Menu
	- Select
	- Table

---

Release notes for **Version 0.0.1.1**

## Bug fixes

1. Fixed input issue and dark theme forecolor issue in **ComboBox** component.
1. Fixed the **Accordion** component animation.
1. Fixed the tab button spacings in **Tabs** component for vertical direction.
1. Fixed the **Signature** component bounce issue when using on touch devices.
1. Updated **Button** component with Success, Warning and Info types.
1. Updated **Alert** component with Success, Warning and Info types.
1. Updated **Badge** component with Success, Warning and Info types. 	

---

For more information, you can download the samples from this repo which has all these steps done and the projects are ready to explore.
To see the demo of each component, check out [Demo GitHub Repo](https://sysinfocus.github.io/shadcn-inspired/)

## Have issues?
Open an issue on this repo or email to issues@sysinfocus.com

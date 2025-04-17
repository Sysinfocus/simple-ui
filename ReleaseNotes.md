# Release Notes

Release notes for **Version 0.0.2.9**

## New / Updates / Bug fixes
1. Updated **Input** component to support Format attribute and bug fixes.
1. Updated **Treeview** component to raise `OnExpanded` and `OnCollapsed` events only on parent nodes.
1. Added `Prefix` and `Suffix` attributes to **Input** component.
1. Added `GetInnerText`, `GetInnerHtml`, `SetInnerText` and `SetInnerHtml` methods to **BrowserExtensions**.
1. Added **MarkdownPreview** component.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.8**

## New / Updates / Bug fixes
1. Fixed bug for **Tabs** component which was not allowing programmatically change of tabs.
1. Updates **Scheduler** component to show proper week days starting from Monday.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.7**

## New / Updates / Bug fixes
1. **ResizeObserver** component added for anything to monitor for change in dimensions using Css selector.
1. Fixed bug for `scrollIntoViewIfNeeded` call in JSInterop for **Presenter** component, instead now uses **ResizeObserver** to update the size on dimension changes.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.6**

## New / Updates / Bug fixes
1. **TabPages** component added.
1. **Presenter** component added.
1. **Pills** component added.
1. Updated **Input** component to use `Format` parameter for displaying numbers, date and time with respective formats.
1. Fixed **Tabs** component issue where it was triggering tab change on events fired on other components.
1. Streamlined the box-shadow for all components.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.5**

## New / Updates / Bug fixes
1. **Sidebar** component added with 2 types - `Simple` and `Multi-level` which can be switched by `IsSimpleSidebar` boolean parameter.
1. **Timeline** component added.
1. Updated the **BrowserExtensions** with `AddClass` and `RemoveClass` methods.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.4**

## New / Updates / Bug fixes
1. **ColorPicker** component added.
1. **Notification** component added (preview for testing purpose).
1. Updated **Icon** component to support Microsoft FluentUI Icons and Lucide Icons.
1. Updated the **BrowserExtensions** with `GetUserAgent`, `GetPlatform`, `GetTextFromClipboard`, `SetTextToClipboard`, `InvokePrint` and `InvokeShare` methods.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.3**

## Updates / Bug fixes
1. Fixed UI issue in **Editor** component for UL, OL and Colors.
1. Updated the **BrowserExtensions** with `IsPWA`, `ToggleFullscreen`, `Debounce`, `SetElementWidth`, `SetElementHeight` and `GetClientRectForElement` methods.
1. Other minor UI fixes.

---

Release notes for **Version 0.0.2.2**

## Updates / Bug fixes
1. Fixed bug in **Dialog** component which was shifting focus to the first element always.
1. Added **Animate**, **Text** and **Icon** components.

---

Release notes for **Version 0.0.2.1**

## Updates / Bug fixes
1. Fixed UI issues.
1. Removed license key requirements and made the library FREE FOR ALL.

---

Release notes for **Version 0.0.2**

## Updates / Bug fixes
1. Fixed bugs in **Slider** component.
1. Updated attributes in **Textarea** component.
1. Updated attributes in **Swipe** component.
1. Other minor UI fixes for various components.

---

Release notes for **Version 0.0.1.9**

## Updates / Bug fixes
1. Updated **CodeScanner** component to start and stop using `bool` flag.
1. Added `Controls` bool flag to hide the camera list and button.
1. Fixed bug in **Checkbox** component, now showing the outline for label.
1. Fixed bug in **Radio** component, now showing the outline for label.

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
To see the demo of each component, check out [Demo](https://blazor.art/)

## Have issues?
Open an issue on this repo or email to issues@sysinfocus.com

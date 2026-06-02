# WolvenKit.UITests README

We use FLaUI to automate UI testing for WolvenKit.

Requirements:

- have your CP77_EXE env var set to an installation of the game
- run the tests and don't touch the mouse while they go

## How to write a UI test for WolvenKit

- Install FLaUInspect from https://github.com/FlaUI/FlaUInspect
- Add AutomationID XAML tags to any View.xaml elements that your test needs to interact with. (See example below.)
- For any given Syncfusion component, refer to the relevant UI Automation docs (e.g. for [DataGrid](https://help.syncfusion.com/wpf/datagrid/ui-automation) or [SfTreeGrid](https://help.syncfusion.com/wpf/treegrid/ui-automation), etc.)
- Check out the existing tests to get a feel for the FLaUI APIs
- Breakpoint the app at key points and use FLaUInspect to view the accessibility tags of the UI elements



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

## Implementation Notes

Syncfusion SfTreeGrid & SfDataGrid are used for the file trees and file lists on this screen.
Our new UITests need to get Files.count from these file views to verify adding files, converting to/from JSON, etc.
We use FLaUI framework to interact with UI Automation controls on the views, to simulate user interaction.
For FLaUI to work, each component needs to expose itself and key properties to be interactable in UI Automation.
But unlike stock WPF components, these Syncfusion components don't expose their properties to standard Microsoft UIA.
In fact, the SfTreeGrid & SfDataGrid are invisible to UI tests.

To make the file views visible to UI tests, required creating these custom wrapper classes:

`public class InspectableTreeGrid : SfTreeGrid {...}`

`public class InspectableDataGrid : SfDataGrid {...}`


This worked for exposing these views to UI tests.
Most of the visual properties got inherited correctly from SfTreeGrid & SfDataGrid via declarations in App.Styles.xaml.
But for some reason the background color did not get inherited or is not part of the base style.
So the ProjectExplorerView.FileTree  got a transparent background--below the files was lighter gray.
Note: we were already setting the background color manually on the SfDataGrid so it seems likely that it's not part of the global skin.

The fix: We add a global style to App.Styles.xaml to globally set the background color of the Inspectable grids (only used in these file lists):

```
<Style TargetType=
"{
     x:Type
     others:InspectableTreeGrid
}">

<Setter Property="Background" Value=
"{
    StaticResource
    ContentBackground
}"
/>

</Style>
```

(without the extra whitespace of course)
Everything looks good now, but if anything else comes up we can add another override in App.Styles.xaml or at the individual spot of the declarations in the relevant View.xaml.

We also added pragma'd out overrides in the .cs classes themselves, which should help guarantee inheritance of style.

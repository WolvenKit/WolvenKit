# Contributing

## Basics

When you work on anything please create an issue for it or comment on the appropriate issue thus people won't work on the same issues voiding their works.
Please make your issue very descriptive and describe what you are trying to achieve with it.

## Localizations

We do not support localizations yet. Although once we will anyone is welcome to help with it to make WolvenKit more avaliable for everyone.

## Bug reports

Please use the GitHub Issue tracker.

## Some local guidelines

### Frontend

WolvenKit uses **WPF** as framework for its GUI and we are using the **MVVM** pattern.

* `WolvenKit.csproj` is the WPF UI (it contains the Views)
* `WolvenKit.App.csproj` is the platform-independent MVVM component (it contains the ViewModels)
* Prioritize constructor-injection with our DI

WolvenKit is supposed to be an IDE-like app for developing mods - its UI should **prioritize function over form**. Visual Studio 2022 is considered the model.

#### XAML
In order to keep consistent rules when formatting XAML, you must install the
extension **XAML Styler**. Settings are defined in `Settings.XamlStyler` file.
It should automatically import settings of this file when opening the solution
with Visual Studio or Rider.

You can see settings in `Tools` > `Options...` > `XAML Styler`. If you want to
change settings, come and ask on Discord first. By default, it should run XAML
Styler rules when saving / closing a XAML file. This is related to options in
category `Misc`.

**Additional rules:**
> Following rules were introduced long time after WolvenKit was created. You
> may find files not following these rules. Feel free to fix them when working
> on them.

**DO** explicitly define `Grid.Row` and `Grid.Column` properties. It makes it
easier to understand where a tag is in the grid. It is also easier when
updating the layout to only change values instead of adding/removing these
properties. Finally, XAML Styler will automatically organize tags based on
rows and columns.

**DO** put a blank line between tags, when such tags are part of a parent:
```xaml
<Grid>
  <Button />

  <TextBlock />

  <Grid>
    <Button />

    <TextBlock />
  </Grid>

  <!-- ... -->
</Grid>
```

**DON'T** put a blank line between `<RowDefinition>`, `<ColumnDefinition>`,
`<Setter>` tags.

**DO** put a blank line to separate a block of `<Setter>` and
a `<Setter>` which has children, like for a template:
```xaml
<Grid>
  <Grid.Resources>
    <Setter Property="Foreground" Value="White" />
    <Setter Property="Margin" Value="4" />

    <Setter Property="Template">
      <!-- ... -->
    </Setter>
  </Grid.Resources>

  <Grid.RowDefinitions>
    <RowDefinition />
    <RowDefinition />
    <RowDefinition />
  </Grid.RowDefinitions>

  <Grid.ColumnDefinitions>
    <ColumnDefinition />
    <ColumnDefinition />
    <ColumnDefinition />
  </Grid.ColumnDefinitions>

  <!-- ... -->
</Grid>
```

These rules are present to improve readiness of a XAML document. In some
cases, it makes sense to avoid blank lines. For example, when a `<Label>` is
related to an input tag like `<TextBox>`. It is fine to keep them close to
quickly see and understand the relationship between both tags.

**DO** use `<IconBox>` to show an icon in application. It provides properties
to select which `IconPack` and `Kind` of icon to draw. You can change the size
and color with respectively `Size` and `Foreground` properties. It uses a
default icon size and a white color, which should be good enough in most cases.

**UI scaling:**

**DO** use `WolvenKitFont...`, `WolvenKitIcon...`, `WolvenKitMargin...` and
other dynamic resources to draw a responsive UI. You can find plenty of them in
codebase, for example:
```xaml
<TextBlock
  Text="Hello World!"
  FontSize="{DynamicResource WolvenKitFontBody}" />
```

**DO** check for existing dynamic resources in`WolvenKit/Themes/App.Sizes.xaml`.

Sizes are defined for a display resolution of 1920x1080 (100% scale) and scoped
per view.
When the user changes UI scaling, the logic in `WolvenKit.App/ViewModels/Shell/AppViewModel.cs`
is called to update these values.

**DO** update, add or remove dynamic entries properly:
 - update `AppViewModel:UpdateScaleResources()` method for the updated, added 
   or removed entries
 - follow the current naming convention, it helps keeping things organized in
   the IDE's autocomplete

**Responsiveness:**

Currently, this application poorly implements responsive UI. It is expected for
users to run this application with at least a 1080p screen resolution, with a 
maximized window.

However, anyone is free to write PRs in order to add responsive UI where 
needed.

> [!NOTE]
> Responsiveness is in addition to scaling the UI, like mentioned above. We are
> mostly focusing on the layout of UI elements when refering to responsive UI.

`WelcomePageView` is the first view implementing a responsive UI (see [#2628]).
For now, the principal solution is to use XAML only with converters to shape 
the layout of a view, based on breakpoint widths of the window:
 - a breakpoint width is a threshold of the current size of the window (in 
   pixels).
 - a converter is a condition (like `LessThanConverter`) which change states of
   a UI element when a breakpoint is triggered or not.

Any `Style` defined for a responsive UI should be suffixed with 
`ResponsiveStyle`. For example `CardResponsiveStyle`. This help quickly 
identify what is the purpose of this style.

You can define a `Style` with a `Trigger` and change properties, like
`Grid.Row` for example. In this case, you will need to define the default value
of the property in the style, and the new value in the trigger declaration. 
Moreover, the property `Grid.Row` (for example) must be removed of its element.
This is required because any property on a UI element always takes precedence.
See this example:

```xaml
<!-- Inside a ResourceDictionary -->
<converters:LessThanConverter x:Key="LessThanConverter" />

<Style
	x:Key="ExampleResponsiveStyle"
	TargetType="{x:Type Grid}">
	<!-- Default value required -->
	<Setter Property="Grid.Row" Value="0" />
	
	<Style.Triggers>
		<!-- Trigger when ActualWidth < WolvenKitWelcomeBreakWidth -->
		<DataTrigger
			Binding="{Binding Path=ActualWidth,
							  Converter={StaticResource LessThanConverter},
							  ConverterParameter=WolvenKitWelcomeBreakWidth,
							  RelativeSource={RelativeSource AncestorType=Window}}"
			Value="True">

			<Setter Property="Grid.Row" Value="1" />
		</DataTrigger>
	</Style.Triggers>
</Style>

<!-- After ResourceDictionary -->

<Grid>
	<Grid.RowDefinitions>
		<RowDefinition />
		<!-- 2nd row reserved for responsiveness -->
		<RowDefinition />
	</Grid.RowDefinitions>

	<TextBlock x:Key="{StaticResource ExampleResponsiveStyle}" />
</Grid>
```

A few notes about this snippet of code:
 - `ConverterParameter` must be a `string` of a dynamic resource. This allows 
   UI scaling too.
 - `<!-- 2nd row reserved for responsiveness -->` or similar comment should be
   used to clearly inform users the UI element is indeed used and must not be
   removed without a good reason.

> [!NOTE]
> In some cases, we cannot explicitly define `Grid.Row` nor `Grid.Column` when
> they must be changed for responsiveness. This is an exception to the rule 
> defined above (WPF / XAML being the culprit here).

[#2628]: https://github.com/WolvenKit/WolvenKit/pull/2628

### Code Style

The solution comes with an **editorconfig** file to use.

### Git

The `main` branch is the development branch. Releases are created by **tag**, hotfixes to releases are supposed to be branched-out from the tag. Branches should be created from a GitHub issue and should be focused, small and reviewable.

Please use [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/#summary) when writing commit messages. Examples:

Commit message with description and breaking change footer
```
feat: allow provided config object to extend other configs

BREAKING CHANGE: `extends` key in config file is now used for extending other config files
```

Commit message with no body
```
docs: correct spelling of CHANGELOG
```


## General programming guidelines

We recommend to read through, and follow as closely as possible the Aviva C# Coding guidelines: [https://csharpcodingguidelines.com/](https://csharpcodingguidelines.com)

### As well as

* A class or interface should have a single purpose (**AV1000**)
* Classes should protect the consistency of their internal state (**AV1026**)
* Throw exceptions rather than returning some kind of status value (**AV1200**)
* Provide a rich and meaningful exception message text (**AV1202**)
* Name assemblies after their contained namespace (**AV1505**)
* Limit the contents of a source code file to one type (**AV1507**)
* Use using statements instead of fully qualified type names (**AV1510**)
* Don't use "magic" numbers (**AV1515**)
* Always add a block after the keywords if, else, do, while, for, foreach and case (**AV1535**)
* Build with the highest warning level (**AV2210**)

*See the PDF on [https://csharpcodingguidelines.com](https://csharpcodingguidelines.com) for details.*

### Additional points

* Avoid introducing new compiler warnings in your code.

## Code style

* Follow the general .NET naming conventions: [https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions)
* Put braces on their own lines:

```csharp
public void F()
{
    // code
}
```

Instead of using the K&R style:

```csharp
public void F() {
    // code
}
```

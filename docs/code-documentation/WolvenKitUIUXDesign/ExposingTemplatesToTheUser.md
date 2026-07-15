# Exposing Templates to the User

The user needs to be able to specify a template whenever a user interaction creates a new `IRedType` instance (e.g. New File Dialog, the yellow + button in the tree view, etc.).
::: info
If no templates are available or the only template is "default" for the type created, the choice may be skipped and the default option auto selected.
:::

When presenting the user with options for templates, the "default" template should be preselected if available.

To make this easier [a dropdown component](../Subprojects/WolvenKit.App/RedTypeTemplateDropdown) is available which accepts a requested type and exposes the selected `RedTypeTemplateSelectionOption`.


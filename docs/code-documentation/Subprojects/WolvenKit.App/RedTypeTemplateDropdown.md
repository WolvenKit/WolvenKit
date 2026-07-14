# Red Type Template Dropdown

The `RedTypeTemplateDropdown` faciliates the user chooing an available template for the given type.

## Usage

In the xaml add a `RedTypeTemplateDropdown` and bind it to an `RedTypeTemplateDropdownViewModel` instance.

```xaml
<controls:RedTypeTemplateDropdown
                    ViewModel="{Binding RedTypeTemplateDropdownViewModel}"/>
```

All code interactions are done through the ViewModel.

The type of the templates in the dropdown is directly tied to the `RequestedType` property, changing it will update the drop down options live. <br>
The selected template is represented by the `SelectedRedTypeTemplate` property which is a `RedTypeTemplateSelectionOption` and a type of `RedTypeTemplateDescriptor` with an additional property for the source which can be `System`, `User`, or `Raw` where `Raw` represents no template at all.
::: warning
If directly passed to the `RedTypeTemplateService` the additional source property will be ignored. <br>
Instead use `CreateTypeInstanceFromSelectionOption` which is an extension method that correctly handles the added source property. <br>
Additional methods can be added to `RedTypeTemplateServiceHelper`.
:::

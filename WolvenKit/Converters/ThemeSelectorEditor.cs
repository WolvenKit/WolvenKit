using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.Services.Themes;
using WolvenKit.Helpers;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Settings page editor for <c>ActiveTheme</c>: theme dropdown plus edit / duplicate / delete / import buttons.
    /// </summary>
    public class ThemeSelectorEditor : ITypeEditor
    {
        /// <summary>A theme in the dropdown: name, label and the colors of its swatch.</summary>
        public sealed class ThemeItem(string name, string text, Brush background, Brush accent)
        {
            public string Name { get; } = name;

            public string Text { get; } = text;

            public Brush Background { get; } = background;

            public Brush Accent { get; } = accent;

            public override string ToString() => Text;
        }

        /// <summary>
        /// Swatch and label of a theme. The items hold data, not elements: for an element as content the closed
        /// ComboBox shows a picture of the element in the dropdown, at the size it had when last laid out there,
        /// and after a theme switch (new fonts) the name of the selected theme was cut off.
        /// </summary>
        private static readonly DataTemplate s_itemTemplate = (DataTemplate)XamlReader.Parse("""
            <DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
                <StackPanel x:Name="Row" Orientation="Horizontal" Margin="8,0,0,0">
                    <Border Width="16" Height="16" Margin="0,0,6,0" BorderThickness="1" SnapsToDevicePixels="True"
                            Background="{Binding Background}" BorderBrush="{DynamicResource ForegroundColor_Grey_Dark}">
                        <Border Height="4" VerticalAlignment="Bottom" Background="{Binding Accent}" />
                    </Border>
                    <TextBlock VerticalAlignment="Center" Text="{Binding Text}" />
                </StackPanel>
                <DataTemplate.Triggers>
                    <!-- indented under its group header in the dropdown; the closed box (no ComboBoxItem around it) is not -->
                    <DataTrigger Binding="{Binding RelativeSource={RelativeSource AncestorType=ComboBoxItem}, FallbackValue={x:Null}}" Value="{x:Null}">
                        <Setter TargetName="Row" Property="Margin" Value="0" />
                    </DataTrigger>
                </DataTemplate.Triggers>
            </DataTemplate>
            """);

        private DockPanel _panel;
        private ComboBox _comboBox;
        private Button _deleteButton;
        private IThemeService _themeService;

        public object Create(PropertyInfo propertyInfo)
        {
            _themeService = ThemeUiHelper.ThemeService;

            _comboBox = new ComboBox { MinWidth = 180, VerticalContentAlignment = VerticalAlignment.Center, ItemTemplate = s_itemTemplate };
            RefreshItems();
            _comboBox.SelectionChanged += (_, _) => UpdateButtons();

            var buttons = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(6, 0, 0, 0) };
            buttons.Children.Add(CreateButton("Edit…", "Edit the selected theme. Built-in themes are copied first.",
                () => ThemeUiHelper.OpenEditor(SelectedTheme, Window.GetWindow(_panel))));
            buttons.Children.Add(CreateButton("Duplicate", "Create a copy of the selected theme",
                () => ThemeUiHelper.Duplicate(SelectedTheme, Window.GetWindow(_panel))));
            _deleteButton = CreateButton("Delete", "Delete the selected user theme",
                () => ThemeUiHelper.Delete(SelectedTheme));
            buttons.Children.Add(_deleteButton);
            buttons.Children.Add(CreateButton("Import…", "Import a theme from a .json file",
                () => ThemeUiHelper.Import(Window.GetWindow(_panel))));
            buttons.Children.Add(CreateButton("Folder", "Open the folder with your themes",
                ThemeUiHelper.OpenThemesFolder));

            _panel = new DockPanel { LastChildFill = true };
            DockPanel.SetDock(buttons, Dock.Right);
            _panel.Children.Add(buttons);
            _panel.Children.Add(_comboBox);

            _themeService.ThemesChanged += OnThemesChanged;
            UpdateButtons();

            return _panel;
        }

        public object Create(PropertyDescriptor propertyDescriptor) => throw new NotImplementedException();

        public void Attach(PropertyViewItem property, PropertyItem info)
        {
            var binding = new Binding("Value")
            {
                Mode = info.CanWrite ? BindingMode.TwoWay : BindingMode.OneWay,
                Source = info,
                ValidatesOnExceptions = true,
                ValidatesOnDataErrors = true
            };
            BindingOperations.SetBinding(_comboBox, Selector.SelectedValueProperty, binding);
            _comboBox.SetCurrentValue(UIElement.IsEnabledProperty, info.CanWrite);
        }

        public void Detach(PropertyViewItem property)
        {
            if (_themeService is not null)
            {
                _themeService.ThemesChanged -= OnThemesChanged;
            }
            if (_comboBox is not null)
            {
                BindingOperations.ClearBinding(_comboBox, Selector.SelectedValueProperty);
            }
        }

        public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

        private ThemeDto SelectedTheme =>
            _themeService.Find(_comboBox.SelectedValue as string) ?? _themeService.Current;

        private void OnThemesChanged(object sender, EventArgs e)
        {
            var selected = _comboBox.SelectedValue as string;

            // Replacing ItemsSource drops the selection, and the two-way binding wrote that into the setting:
            // an empty theme name ("Theme "" not found." in the log) until the selection was put back. The binding
            // is taken off meanwhile; put back, it shows the setting as it is now (a renamed theme included).
            var binding = BindingOperations.GetBindingBase(_comboBox, Selector.SelectedValueProperty);
            if (binding is not null)
            {
                BindingOperations.ClearBinding(_comboBox, Selector.SelectedValueProperty);
            }

            RefreshItems();

            if (binding is not null)
            {
                BindingOperations.SetBinding(_comboBox, Selector.SelectedValueProperty, binding);
            }
            else
            {
                _comboBox.SetCurrentValue(Selector.SelectedValueProperty, _themeService.Find(selected)?.Name ?? _themeService.Current.Name);
            }
            UpdateButtons();
        }

        private void RefreshItems()
        {
            // grouped like the View → Theme menu: dark, light, the user's own; with a color swatch per theme
            var items = new List<ComboBoxItem>();
            foreach (var (group, themes) in ThemeListHelper.Group(_themeService))
            {
                items.Add(new ComboBoxItem
                {
                    Content = group,
                    IsEnabled = false,
                    Focusable = false,
                    FontWeight = FontWeights.SemiBold
                });

                items.AddRange(themes.Select(t =>
                {
                    var (background, accent) = ThemeListHelper.GetSwatchBrushes(_themeService, t);
                    return new ComboBoxItem
                    {
                        Content = new ThemeItem(t.Name, t.DisplayName, background, accent),
                        ContentTemplate = s_itemTemplate,
                        Tag = t.Name,
                        ToolTip = string.IsNullOrEmpty(t.Description) ? null : t.Description
                    };
                }));
            }
            _comboBox.SetCurrentValue(Selector.SelectedValuePathProperty, nameof(ComboBoxItem.Tag));
            _comboBox.SetCurrentValue(ItemsControl.ItemsSourceProperty, items);
        }

        private void UpdateButtons() =>
            _deleteButton?.SetCurrentValue(UIElement.IsEnabledProperty, !SelectedTheme.IsBuiltIn);

        private static Button CreateButton(string text, string toolTip, Action action)
        {
            var button = new Button { Content = text, ToolTip = toolTip, Margin = new Thickness(4, 0, 0, 0), Padding = new Thickness(8, 0, 8, 0) };
            button.Click += (_, _) => action();
            return button;
        }
    }
}

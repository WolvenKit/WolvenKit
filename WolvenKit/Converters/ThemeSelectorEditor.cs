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
        private DockPanel _panel;
        private ComboBox _comboBox;
        private Button _deleteButton;
        private IThemeService _themeService;

        public object Create(PropertyInfo propertyInfo)
        {
            _themeService = ThemeUiHelper.ThemeService;

            _comboBox = new ComboBox { MinWidth = 180, VerticalContentAlignment = VerticalAlignment.Center };
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
            RefreshItems();
            // Replacing ItemsSource drops the selection; restore it (same value as the setting, so nothing changes).
            _comboBox.SetCurrentValue(Selector.SelectedValueProperty, _themeService.Find(selected)?.Name ?? _themeService.Current.Name);
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
                    var row = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(8, 0, 0, 0) };
                    var swatch = ThemeListHelper.CreateSwatch(_themeService, t);
                    swatch.Margin = new Thickness(0, 0, 6, 0);
                    row.Children.Add(swatch);
                    row.Children.Add(new TextBlock { Text = t.DisplayName, VerticalAlignment = VerticalAlignment.Center });

                    return new ComboBoxItem
                    {
                        Content = row,
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

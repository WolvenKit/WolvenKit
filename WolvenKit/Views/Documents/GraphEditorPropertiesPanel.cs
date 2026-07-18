#nullable enable

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.Views.Editors;
using WolvenKit.Views.Tools;

namespace WolvenKit.Views.Documents;

public class GraphEditorPropertiesPanel : Grid
{
    private readonly ISettingsManager _settingsManager;

    public GraphEditorPropertiesPanel()
    {
        _settingsManager = Locator.Current.GetService<ISettingsManager>() ??
                           throw new ArgumentNullException(nameof(ISettingsManager));

        Loaded += OnLoaded;
        Unloaded += OnUnloaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        _settingsManager.PropertyChanged += OnSettingsPropertyChanged;
        ApplyLayout();
    }

    private void OnUnloaded(object sender, RoutedEventArgs e) =>
        _settingsManager.PropertyChanged -= OnSettingsPropertyChanged;

    private void OnSettingsPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ISettingsDto.GraphEditorPropertiesLayout))
        {
            ApplyLayout();
        }
    }

    private void ApplyLayout()
    {
        var propertyTree = Children.OfType<RedTreeView>().SingleOrDefault();
        var propertySplitter = Children.OfType<GridSplitter>().SingleOrDefault();
        var propertyEditor = Children.OfType<RedTypeView>().SingleOrDefault();
        if (propertyTree is null || propertySplitter is null || propertyEditor is null)
        {
            return;
        }

        RowDefinitions.Clear();
        ColumnDefinitions.Clear();

        if (_settingsManager.GraphEditorPropertiesLayout == GraphEditorPropertiesLayout.Stacked)
        {
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(6) });
            RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition());

            SetPosition(propertyTree, 0, 0);
            SetPosition(propertySplitter, 1, 0);
            SetPosition(propertyEditor, 2, 0);

            propertySplitter.SetCurrentValue(CursorProperty, Cursors.SizeNS);
            propertySplitter.SetCurrentValue(GridSplitter.ResizeDirectionProperty, GridResizeDirection.Rows);
        }
        else
        {
            RowDefinitions.Add(new RowDefinition());
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(6) });
            ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            SetPosition(propertyTree, 0, 0);
            SetPosition(propertySplitter, 0, 1);
            SetPosition(propertyEditor, 0, 2);

            propertySplitter.SetCurrentValue(CursorProperty, Cursors.SizeWE);
            propertySplitter.SetCurrentValue(GridSplitter.ResizeDirectionProperty, GridResizeDirection.Columns);
        }

        propertySplitter.SetCurrentValue(HeightProperty, double.NaN);
        propertySplitter.SetCurrentValue(WidthProperty, double.NaN);
        propertySplitter.SetCurrentValue(HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
        propertySplitter.SetCurrentValue(VerticalAlignmentProperty, VerticalAlignment.Stretch);
        propertySplitter.SetCurrentValue(IsHitTestVisibleProperty, true);
    }

    private static void SetPosition(UIElement element, int row, int column)
    {
        SetRow(element, row);
        SetColumn(element, column);
    }
}

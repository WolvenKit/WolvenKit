using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace WolvenKit.Views.GraphEditor;

public sealed class GraphActionPaletteItem
{
    public string Title { get; init; } = "";
    public string Subtitle { get; init; } = "";
    public string Category { get; init; } = "";
    public string SearchText { get; init; } = "";
    public string Glyph { get; init; } = "";
    public string IconKind { get; init; } = "";
    public string ParentTitle { get; init; } = "";
    public bool IsVariant { get; init; }
    public bool HasMaterialIcon => !string.IsNullOrEmpty(IconKind);
    public IReadOnlyList<GraphActionPaletteItem> Variants { get; init; } = [];
    public bool HasVariants => Variants.Count > 0;
    public Action Execute { get; init; } = () => { };

    public bool Matches(string query) =>
        Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        Subtitle.Contains(query, StringComparison.OrdinalIgnoreCase) ||
        SearchText.Contains(query, StringComparison.OrdinalIgnoreCase);
}

public partial class GraphActionPalette : UserControl, INotifyPropertyChanged
{
    private IReadOnlyList<GraphActionPaletteItem> _rootItems = [];
    private GraphActionPaletteItem _variantParent;
    private string _heading = "All Actions";
    private string _searchText = "";
    private string _variantHeading = "";
    private bool _isVariantPanelVisible;
    private Thickness _variantPanelMargin = new(4, 0, 0, 0);

    public event EventHandler DismissRequested;
    public event EventHandler ActionExecuted;
    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<GraphActionPaletteItem> VisibleItems { get; } = [];
    public ObservableCollection<GraphActionPaletteItem> VariantItems { get; } = [];

    public string Heading
    {
        get => _heading;
        private set => SetField(ref _heading, value);
    }

    public string SearchText
    {
        get => _searchText;
        set
        {
            if (SetField(ref _searchText, value))
            {
                CloseVariantPanel(false);
                RefreshVisibleItems();
            }
        }
    }

    public string VariantHeading
    {
        get => _variantHeading;
        private set => SetField(ref _variantHeading, value);
    }

    public bool IsVariantPanelVisible
    {
        get => _isVariantPanelVisible;
        private set => SetField(ref _isVariantPanelVisible, value);
    }

    public Thickness VariantPanelMargin
    {
        get => _variantPanelMargin;
        private set => SetField(ref _variantPanelMargin, value);
    }

    public GraphActionPalette()
    {
        InitializeComponent();
    }

    public void Open(string heading, IReadOnlyList<GraphActionPaletteItem> items)
    {
        _rootItems = items;
        Heading = heading;
        CloseVariantPanel(false);
        SearchText = "";
        RefreshVisibleItems();

        Dispatcher.BeginInvoke(() =>
        {
            SearchBox.Focus();
            Keyboard.Focus(SearchBox);
            SearchBox.SelectAll();
        }, DispatcherPriority.Input);
    }

    public void RefreshItems(IReadOnlyList<GraphActionPaletteItem> items)
    {
        var variantParentTitle = _variantParent?.Title;
        _rootItems = items;
        RefreshVisibleItems();

        if (variantParentTitle is not null &&
            _rootItems.FirstOrDefault(item => item.Title == variantParentTitle) is { HasVariants: true } parent)
        {
            ShowVariants(parent, null, false);
        }
    }

    private void RefreshVisibleItems()
    {
        var selectedItem = ActionList.SelectedItem as GraphActionPaletteItem;
        IEnumerable<GraphActionPaletteItem> items;
        if (!string.IsNullOrWhiteSpace(SearchText))
        {
            var query = SearchText.Trim();
            items = _rootItems
                .SelectMany(item => item.Matches(query)
                    ? [item]
                    : item.Variants.Where(variant => variant.Matches(query)))
                .Distinct();
        }
        else
        {
            items = _rootItems;
        }

        VisibleItems.Clear();
        foreach (var item in items)
        {
            VisibleItems.Add(item);
        }

        var selection = selectedItem is null
            ? VisibleItems.FirstOrDefault()
            : VisibleItems.FirstOrDefault(item =>
                item.Title == selectedItem.Title &&
                item.ParentTitle == selectedItem.ParentTitle) ?? VisibleItems.FirstOrDefault();
        ActionList.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedItemProperty, selection);
        if (selection is not null)
        {
            ActionList.ScrollIntoView(selection);
        }
    }

    private void OnPreviewKeyDown(object sender, KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.Down:
                MoveSelection(GetActiveList(), 1);
                e.Handled = true;
                break;
            case Key.Up:
                MoveSelection(GetActiveList(), -1);
                e.Handled = true;
                break;
            case Key.Enter:
                ExecuteSelectedItem(GetActiveList());
                e.Handled = true;
                break;
            case Key.Right when
                string.IsNullOrEmpty(SearchText) &&
                !VariantList.IsKeyboardFocusWithin &&
                ActionList.SelectedItem is GraphActionPaletteItem { HasVariants: true } item:
                ShowVariants(item, null, true);
                e.Handled = true;
                break;
            case Key.Left when IsVariantPanelVisible:
                CloseVariantPanel(true);
                e.Handled = true;
                break;
            case Key.Escape when IsVariantPanelVisible:
                CloseVariantPanel(true);
                e.Handled = true;
                break;
            case Key.Escape:
                DismissRequested?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
                break;
        }
    }

    private ListBox GetActiveList() =>
        VariantList.IsKeyboardFocusWithin ? VariantList : ActionList;

    private static void MoveSelection(ListBox list, int offset)
    {
        if (list.Items.Count == 0)
        {
            return;
        }

        var nextIndex = Math.Clamp(list.SelectedIndex + offset, 0, list.Items.Count - 1);
        list.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedIndexProperty, nextIndex);
        list.ScrollIntoView(list.SelectedItem);
    }

    private void ActionList_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (FindVisualParent<Button>(e.OriginalSource as DependencyObject) is not null)
        {
            return;
        }

        if (ItemsControl.ContainerFromElement(ActionList, e.OriginalSource as DependencyObject) is not ListBoxItem item)
        {
            return;
        }

        ActionList.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedItemProperty, item.DataContext);
        ExecuteSelectedItem(ActionList);
        e.Handled = true;
    }

    private void VariantList_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (ItemsControl.ContainerFromElement(VariantList, e.OriginalSource as DependencyObject) is not ListBoxItem item)
        {
            return;
        }

        VariantList.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedItemProperty, item.DataContext);
        ExecuteSelectedItem(VariantList);
        e.Handled = true;
    }

    private void TemplateVariantsButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        if (sender is Button { Tag: GraphActionPaletteItem { HasVariants: true } item } button)
        {
            ShowVariants(item, button, false);
        }
    }

    private void TemplateVariantsButton_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (sender is Button { Tag: GraphActionPaletteItem { HasVariants: true } item } button)
        {
            ShowVariants(item, button, true);
            e.Handled = true;
        }
    }

    private void ShowVariants(
        GraphActionPaletteItem item,
        FrameworkElement anchor,
        bool selectFirst)
    {
        _variantParent = item;
        VariantHeading = $"{item.Title} Templates";
        VariantItems.Clear();
        foreach (var variant in item.Variants)
        {
            VariantItems.Add(variant);
        }

        IsVariantPanelVisible = true;
        ActionList.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedItemProperty, item);
        PositionVariantPanel(item, anchor);

        if (selectFirst && VariantItems.Count > 0)
        {
            VariantList.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedIndexProperty, 0);
            VariantList.Focus();
            Keyboard.Focus(VariantList);
        }
    }

    private void PositionVariantPanel(GraphActionPaletteItem item, FrameworkElement anchor)
    {
        Dispatcher.BeginInvoke(() =>
        {
            var row = FindVisualParent<ListBoxItem>(anchor) ??
                      ActionList.ItemContainerGenerator.ContainerFromItem(item) as ListBoxItem;
            if (row is null)
            {
                VariantPanelMargin = new Thickness(4, 0, 0, 0);
                return;
            }

            var rowTop = row.TranslatePoint(new Point(0, 0), Root).Y;
            var estimatedPanelHeight = Math.Min(420, 48 + (VariantItems.Count * 48));
            var maxTop = Math.Max(0, MainPanel.ActualHeight - estimatedPanelHeight);
            VariantPanelMargin = new Thickness(4, Math.Clamp(rowTop, 0, maxTop), 0, 0);
        }, DispatcherPriority.Loaded);
    }

    private void CloseVariantPanel(bool returnFocus)
    {
        var parent = _variantParent;
        _variantParent = null;
        IsVariantPanelVisible = false;
        VariantItems.Clear();

        if (!returnFocus)
        {
            return;
        }

        if (parent is not null)
        {
            ActionList.SetCurrentValue(System.Windows.Controls.Primitives.Selector.SelectedItemProperty, parent);
            ActionList.ScrollIntoView(parent);
        }

        ActionList.Focus();
        Keyboard.Focus(ActionList);
    }

    private void ExecuteSelectedItem(ListBox list)
    {
        if (list.SelectedItem is not GraphActionPaletteItem item)
        {
            return;
        }

        item.Execute();
        ActionExecuted?.Invoke(this, EventArgs.Empty);
    }

    private static T FindVisualParent<T>(DependencyObject element) where T : DependencyObject
    {
        while (element is not null)
        {
            if (element is T match)
            {
                return match;
            }

            element = VisualTreeHelper.GetParent(element);
        }

        return null;
    }

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }
}

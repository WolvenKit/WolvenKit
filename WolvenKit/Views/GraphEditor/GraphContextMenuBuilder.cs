using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.GraphEditor;

#nullable enable
internal sealed class GraphContextMenuBuilder
{
    private readonly ContextMenu _menu;
    private readonly Style _itemStyle;
    private readonly Style _separatorStyle;
    private bool _separatorPending;

    public GraphContextMenuBuilder(ContextMenu menu, Style itemStyle, Style separatorStyle)
    {
        _menu = menu;
        _itemStyle = itemStyle;
        _separatorStyle = separatorStyle;
        _menu.Items.Clear();
    }

    public void StartSection() => _separatorPending = _menu.Items.Count > 0;

    public MenuItem AddAction(string header, string iconKind, Action click, string? description = null) =>
        AddAction(header, iconKind, null, click, description);

    public MenuItem AddAction(string header, string iconKind, string? iconColor, Action click, string? description = null)
    {
        var item = CreateMenuItem(header, iconKind, iconColor, click, description);
        AddItem(item);
        return item;
    }

    public MenuItem AddCategory(string header, string? description = null)
    {
        var item = CreateMenuItem(header, "FolderOutline", null, null, description);
        AddItem(item);
        return item;
    }

    public void AddItem(MenuItem item, bool applyDefaultStyle = true)
    {
        AddPendingSeparator();
        if (applyDefaultStyle)
        {
            item.Style = _itemStyle;
        }

        _menu.Items.Add(item);
    }

    public void Open(ContextMenuEventArgs e)
    {
        _menu.SetCurrentValue(ContextMenu.IsOpenProperty, true);
        e.Handled = true;
    }

    public static MenuItem CreateMenuItem(
        string header,
        string iconKind,
        string? iconColor,
        Action? click,
        string? description = null)
    {
        var item = new MenuItem
        {
            Header = header,
            Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!
        };

        if (!string.IsNullOrWhiteSpace(description))
        {
            item.ToolTip = description;
            ToolTipService.SetPlacement(item, PlacementMode.Right);
            ToolTipService.SetHorizontalOffset(item, 8);
        }

        if (iconKind is not null)
        {
            var hasIcon = iconKind != "Empty";
            var icon = new IconBox
            {
                IconPack = hasIcon ? IconPackType.Material : IconPackType.Empty,
                Kind = hasIcon ? iconKind : "",
                Margin = new Thickness(4, 0, 2, 0),
                Size = (double)Application.Current.Resources["WolvenKitIconMicro"]!
            };

            if (!string.IsNullOrEmpty(iconColor) &&
                Application.Current.Resources[iconColor] is Brush brush)
            {
                icon.Foreground = brush;
            }

            item.Icon = icon;
        }

        if (click is not null)
        {
            item.Click += (_, _) => click();
        }

        return item;
    }

    private void AddPendingSeparator()
    {
        if (!_separatorPending)
        {
            return;
        }

        _menu.Items.Add(new Separator { Style = _separatorStyle });
        _separatorPending = false;
    }
}

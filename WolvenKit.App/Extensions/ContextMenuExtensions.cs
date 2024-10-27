using System;
using System.Windows.Controls;

namespace WolvenKit.App.Extensions;

public static class ContextMenuExtensions
{
    public static void AddMenu(this ContextMenu menu, string label, Action callback)
    {
        var menuItem = new MenuItem
        {
            Header = label
        };
        menuItem.Click += (_, _) => callback();
        menu.Items.Add(menuItem);
    }
}

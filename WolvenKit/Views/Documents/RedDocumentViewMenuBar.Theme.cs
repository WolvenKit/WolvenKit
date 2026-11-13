#nullable enable
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Splat;
using WolvenKit.App.Services.Themes;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Views.Documents;

/// <summary>
/// The menu bar's MenuItem styles are based on the theme's MenuItem style as it was when the bar was created
/// (BasedOn is a StaticResource). After a theme change while WolvenKit runs, rebase them on the new one, as menus
/// without a style of their own (Editor Mode) get it.
/// </summary>
public partial class RedDocumentViewMenuBar : IThemeAware
{
    // a second theme change rebases the copies of the first one again, from the XAML styles
    private readonly Dictionary<Style, Style> _originals = new();
    private readonly HashSet<Style> _rebased = new();

    private void RegisterForThemeChanges() => Locator.Current.GetService<IThemeService>()?.Register(this);

    // after the skin was re-applied, which runs on the same theme switch
    void IThemeAware.OnThemeChanged() => Dispatcher.BeginInvoke(RebaseMenuStyles, DispatcherPriority.ApplicationIdle);

    private void RebaseMenuStyles()
    {
        // The styles are in the resources of the bar's grid: looked up from the menu, which is inside it
        // (resource lookup goes up the tree, so the user control itself doesn't see them).
        var logger = Locator.Current.GetService<ILoggerService>();
        if (MenuBar.TryFindResource("MenuItemStyle") is not Style rootStyle)
        {
            logger?.Debug("Themes: editor menu bar, MenuItemStyle not found, not rebased.");
            return;
        }

        // the theme's MenuItem style, as the re-applied skin put it into the resources
        if (MenuBar.TryFindResource(typeof(MenuItem)) is not Style themeStyle)
        {
            logger?.Debug("Themes: no MenuItem style found, editor menu bar not rebased.");
            return;
        }

        // the styles of this bar (Grid.Resources): the ones to rebase, from MenuItemStyle down
        var ownStyles = FindOwnStyles(rootStyle);
        var copies = new Dictionary<Style, Style>();

        var count = 0;
        foreach (var item in MenuItems(MenuBar.Items))
        {
            if (item.Style is { } style && (_rebased.Contains(style) || BuiltOnOwnStyle(style, ownStyles)))
            {
                var original = _originals.TryGetValue(style, out var o) ? o : style;
                var copy = Rebase(original, themeStyle, ownStyles, copies);
                _originals[copy] = original;
                _rebased.Add(copy);
                item.Style = copy;
                count++;
            }
        }
        logger?.Debug($"Themes: editor menu bar, {count} menu item style(s) rebased.");
    }

    // an own style, or one set on the item itself in the XAML and based on an own style (e.g. "Delete unused materials")
    private static bool BuiltOnOwnStyle(Style? style, HashSet<Style> ownStyles)
    {
        for (; style is not null; style = style.BasedOn)
        {
            if (ownStyles.Contains(style))
            {
                return true;
            }
        }
        return false;
    }

    private HashSet<Style> FindOwnStyles(Style rootStyle)
    {
        var styles = new HashSet<Style>();
        foreach (var dictionary in ResourceOwners(MenuBar))
        {
            if (dictionary.Contains("MenuItemStyle") && ReferenceEquals(dictionary["MenuItemStyle"], rootStyle))
            {
                foreach (var value in dictionary.Values.OfType<Style>().Where(s => s.TargetType == typeof(MenuItem)))
                {
                    styles.Add(value);
                }
                break;
            }
        }
        return styles;
    }

    private static IEnumerable<ResourceDictionary> ResourceOwners(DependencyObject element)
    {
        for (var current = element; current is not null; current = LogicalTreeHelperParent(current))
        {
            if (current is FrameworkElement { Resources: { } resources })
            {
                yield return resources;
            }
        }

        static DependencyObject? LogicalTreeHelperParent(DependencyObject e) => LogicalTreeHelper.GetParent(e);
    }

    private static IEnumerable<MenuItem> MenuItems(ItemCollection items)
    {
        foreach (var item in items.OfType<MenuItem>())
        {
            yield return item;
            foreach (var child in MenuItems(item.Items))
            {
                yield return child;
            }
        }
    }

    /// <summary>
    /// A copy of <paramref name="style"/> whose chain of own styles ends on <paramref name="themeStyle"/>.
    /// </summary>
    private static Style Rebase(Style style, Style themeStyle, HashSet<Style> ownStyles, Dictionary<Style, Style> copies)
    {
        if (copies.TryGetValue(style, out var done))
        {
            return done;
        }

        var basedOn = style.BasedOn is { } parent && ownStyles.Contains(parent)
            ? Rebase(parent, themeStyle, ownStyles, copies)
            : themeStyle;

        var copy = new Style(style.TargetType, basedOn);
        foreach (var setterBase in style.Setters)
        {
            switch (setterBase)
            {
                case Setter setter:
                    copy.Setters.Add(new Setter(setter.Property, CopyValue(setter.Value), setter.TargetName));
                    break;
                case EventSetter eventSetter:
                    copy.Setters.Add(new EventSetter(eventSetter.Event, eventSetter.Handler) { HandledEventsToo = eventSetter.HandledEventsToo });
                    break;
            }
        }
        foreach (var trigger in style.Triggers)
        {
            copy.Triggers.Add(trigger);
        }

        copies[style] = copy;
        return copy;
    }

    // a sealed {DynamicResource} setter value: keep it dynamic in the copy
    private static object? CopyValue(object? value)
    {
        if (value is null or DynamicResourceExtension)
        {
            return value;
        }
        var keyField = value.GetType().GetField("_resourceKey", BindingFlags.Instance | BindingFlags.NonPublic);
        return keyField?.GetValue(value) is { } key ? new DynamicResourceExtension(key) : value;
    }
}

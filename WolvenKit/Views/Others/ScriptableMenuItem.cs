using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Splat;
using WolvenKit.Functionality.Services;

namespace WolvenKit.Views.Others;

public class ScriptableMenuItem : MenuItem, IScriptableControl
{
    public static readonly DependencyProperty ScriptingNameProperty = DependencyProperty.Register(
        nameof(ScriptingName), typeof(string), typeof(ScriptableMenuItem), new PropertyMetadata(default));

    public string ScriptingName
    {
        get => (string) GetValue(ScriptingNameProperty);
        set => SetValue(ScriptingNameProperty, value);
    }

    protected override void OnInitialized(EventArgs e)
    {
        if (!DesignerProperties.GetIsInDesignMode(this) && string.IsNullOrEmpty(ScriptingName))
        {
            throw new Exception("ScriptingName must be explicitly set!");
        }

        var scriptService = Locator.Current.GetService<ExtendedScriptService>();
        if (scriptService == null)
        {
            throw new Exception("ExtendedScriptService could not be found!");
        }

        var scriptEntries = scriptService.GetScripts(ScriptingName);
        foreach (var scriptEntry in scriptEntries)
        {
            var menuItem = new MenuItem { Header = scriptEntry.Name };
            menuItem.Click += (_, _) => scriptEntry.Execute();

            Items.Add(menuItem);
        }

        base.OnInitialized(e);
    }
}
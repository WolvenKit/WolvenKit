using System.ComponentModel;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Splat;
using WolvenKit.App.Services;

namespace WolvenKit.Views.Others;

public class ScriptableMenu : Menu, IScriptableControl
{
    private ExtendedScriptService _scriptService;

    private readonly List<UIElement> _scriptedElements = new();
    private bool _disposed;

    public static readonly DependencyProperty ScriptingNameProperty = DependencyProperty.Register(
        nameof(ScriptingName), typeof(string), typeof(ScriptableMenu), new PropertyMetadata(default));

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

        _scriptService = Locator.Current.GetService<ExtendedScriptService>();
        if (_scriptService == null)
        {
            throw new Exception("ExtendedScriptService could not be found!");
        }

        _scriptService.RegisterControl(this);

        base.OnInitialized(e);
    }

    public void AddScriptedElements(List<ScriptEntry> scriptEntries)
    {
        foreach (var scriptEntry in scriptEntries)
        {
            var menuItem = CreateTree(scriptEntry);

            Items.Add(menuItem);
            _scriptedElements.Add(menuItem);
        }

        MenuItem CreateTree(ScriptEntry scriptEntry)
        {
            var menuItem = new MenuItem { Header = scriptEntry.Name };
            if (scriptEntry.HasFunction)
            {
                menuItem.Click += (_, _) => scriptEntry.Execute();
            }

            foreach (var child in scriptEntry.Children)
            {
                menuItem.Items.Add(CreateTree(child));
            }

            return menuItem;
        }
    }

    public void RemoveScriptedElements()
    {
        foreach (var element in _scriptedElements)
        {
            Items.Remove(element);
        }
        _scriptedElements.Clear();
    }

    #region IDisposable

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources.
            }

            _scriptService?.UnRegisterControl(this);

            _disposed = true;
        }
    }

    ~ScriptableMenu()
    {
        Dispose(disposing: false);
    }

    #endregion IDisposable
}
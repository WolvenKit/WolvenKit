using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.Controls;

namespace WolvenKit.Views.Exporters;

public class CustomCollectionEditor : BaseTypeEditor
{
    protected CustomCollectionEditorView _wrappedControl;

    private readonly Func<CallbackArguments, Task> _callback;
    private readonly CallbackArguments _args;

    public CustomCollectionEditor(Func<CallbackArguments, Task> callback, CallbackArguments args)
    {
        _callback = callback;
        _args = args;
    }

    public override object Create(PropertyInfo propertyInfo)
    {
        _wrappedControl = new CustomCollectionEditorView(_callback, _args);
        return _wrappedControl;
    }

    public override object Create(PropertyDescriptor PropertyDescriptor)
    {
        _wrappedControl = new CustomCollectionEditorView(_callback, _args);
        return _wrappedControl;
    }

    public override bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

    public override void Attach(PropertyViewItem property, PropertyItem info)
    {
        if (info.CanWrite)
        {
            var binding = new Binding("Value")
            {
                Mode = BindingMode.TwoWay,
                Source = info,
                ValidatesOnExceptions = true,
                ValidatesOnDataErrors = true
            };
            BindingOperations.SetBinding(_wrappedControl, CustomCollectionEditorView.ListProperty, binding);
        }
        else
        {
            _wrappedControl.SetCurrentValue(UIElement.IsEnabledProperty, false);
            var binding = new Binding("Value")
            {
                Source = info,
                ValidatesOnExceptions = true,
                ValidatesOnDataErrors = true
            };
            BindingOperations.SetBinding(_wrappedControl, CustomCollectionEditorView.ListProperty, binding);
        }
    }

    public override void Detach(PropertyViewItem property) => _wrappedControl = null;
}
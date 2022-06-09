using System.Reflection;
using System.Windows.Data;
using Syncfusion.Windows.PropertyGrid;

namespace WolvenKit.Controls
{
    //Custom Editor for folder type properties.
    public abstract class FolderPathEditorBase : ITypeEditor
    {
        public PathEditorFilter[] Filters { get; set; }

        protected PathEditorView _wrappedControl;
        public void Attach(PropertyViewItem property, PropertyItem info)
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
                BindingOperations.SetBinding(_wrappedControl, PathEditorView.TextProperty, binding);
            }
            else
            {
                _wrappedControl.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                var binding = new Binding("Value")
                {
                    Source = info,
                    ValidatesOnExceptions = true,
                    ValidatesOnDataErrors = true
                };
                BindingOperations.SetBinding(_wrappedControl, PathEditorView.TextProperty, binding);
            }
        }

        public abstract object Create(PropertyInfo propertyInfo);
        public void Detach(PropertyViewItem property) { }
    }


    //Custom Editor for folder type properties.
    public class MultiFolderPathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(true, true, Filters);
            return _wrappedControl;
        }
    }

    //Custom Editor for folder type properties.
    public class SingleFolderPathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(true, false, Filters);
            return _wrappedControl;
        }
    }

    //Custom Editor for file type properties.
    public class MultiFilePathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(false, true, Filters);
            return _wrappedControl;
        }
    }

    //Custom Editor for file type properties.
    public class SingleFilePathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(false, false, Filters);
            return _wrappedControl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Controls;

namespace WolvenKit.Controls
{
    //Custom Editor for folder type properties.
    public abstract class FolderPathEditorBase : ITypeEditor
    {
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
                _wrappedControl.IsEnabled = false;
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
            _wrappedControl = new PathEditorView(true, true);
            return _wrappedControl;
        }
    }

    //Custom Editor for folder type properties.
    public class SingleFolderPathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(true, false);
            return _wrappedControl;
        }
    }

    //Custom Editor for file type properties.
    public class MultiFilePathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(false, true);
            return _wrappedControl;
        }
    }

    //Custom Editor for file type properties.
    public class SingleFilePathEditor : FolderPathEditorBase
    {
        public override object Create(PropertyInfo propertyInfo)
        {
            _wrappedControl = new PathEditorView(false, false);
            return _wrappedControl;
        }
    }











    //public class PathEditor : ITypeEditor
    //{
    //    AddPathDialogView _addPathDialogView;

    //    public void Attach(PropertyViewItem property, PropertyItem info)
    //    {
    //        if (info.CanWrite)
    //        {
    //            var binding = new Binding("Value")
    //            {
    //                Mode = BindingMode.TwoWay,
    //                Source = info,
    //                ValidatesOnExceptions = true,
    //                ValidatesOnDataErrors = true
    //            };
    //            BindingOperations.SetBinding(_addPathDialogView, AddPathDialogView.TextProperty, binding);
    //        }
    //        else
    //        {
    //            _addPathDialogView.IsEnabled = false;
    //            var binding = new Binding("Value")
    //            {
    //                Source = info,
    //                ValidatesOnExceptions = true,
    //                ValidatesOnDataErrors = true
    //            };
    //            BindingOperations.SetBinding(_addPathDialogView, AddPathDialogView.TextProperty, binding);
    //        }
    //    }
    //    public object Create(PropertyInfo PropertyInfo)
    //    {
    //        _addPathDialogView = new AddPathDialogView
    //        {

    //        };
    //        return _addPathDialogView;
    //    }

    //    public void Detach(PropertyViewItem property)
    //    {

    //    }
    //}
}

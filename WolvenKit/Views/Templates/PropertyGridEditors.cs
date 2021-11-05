using System;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Data;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Views.Templates;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Views.Editors
{
    public class PropertyGridEditors
    {
        public static ITypeEditor GetPropertyEditor(Type PropertyType)
        {
            if (PropertyType.IsAssignableTo(typeof(IREDString)))
            {
                return new PropertyGridEditors.TextEditor();
                
            }
            else if (PropertyType.IsAssignableTo(typeof(IREDIntegerType)))
            {
                if (PropertyType == typeof(CFloat))
                {
                    return new PropertyGridEditors.FloatEditor();
                }
                return new PropertyGridEditors.IntegerEditor();
            }
            else if (PropertyType.IsAssignableTo(typeof(IREDBool)))
            {
                return new PropertyGridEditors.BoolEditor();
                
            }
            else if (PropertyType.IsAssignableTo(typeof(IREDEnum)))
            {
                return new PropertyGridEditors.EnumEditor();
                
            }
            else if (PropertyType.IsAssignableTo(typeof(IREDChunkPtr)))
            {
                return new PropertyGridEditors.ChunkPtrEditor();
                
            }
            else if (PropertyType.IsAssignableTo(typeof(IREDRef)))
            {
                return new PropertyGridEditors.RefEditor();
                
            }
            else if (PropertyType.IsAssignableTo(typeof(ICurveDataAccessor)))
            {
                return new PropertyGridEditors.CurveEditor();
                
            }
            else if (PropertyType.IsAssignableTo(typeof(IREDColor)))
            {
                return new PropertyGridEditors.ColorEditor();
                
            }

            return null;
        }


        public class ColorEditor : ITypeEditor
        {
            private RedColorEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedColorEditor.RedColorProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedColorEditor.RedColorProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedColorEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class CurveEditor : ITypeEditor
        {
            private RedCurveEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedCurveEditor.RedCurveProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedCurveEditor.RedCurveProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedCurveEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class RefEditor : ITypeEditor
        {
            private RedRefEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedRefEditor.RedRefProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedRefEditor.RedRefProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedRefEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class ChunkPtrEditor : ITypeEditor
        {
            private HandleTemplateView _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, HandleTemplateView.RedChunkPtrProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, HandleTemplateView.RedChunkPtrProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new HandleTemplateView();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class EnumEditor : ITypeEditor
        {
            private EnumTemplateView _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, EnumTemplateView.RedEnumProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, EnumTemplateView.RedEnumProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new EnumTemplateView();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class BoolEditor : ITypeEditor
        {
            private RedBoolEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedBoolEditor.RedBoolProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedBoolEditor.RedBoolProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedBoolEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class TextEditor : ITypeEditor
        {
            private RedStringEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedStringEditor.RedStringProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedStringEditor.RedStringProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedStringEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class FloatEditor : ITypeEditor
        {
            private RedFloatEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedFloatEditor.RedStringProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedFloatEditor.RedStringProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedFloatEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class IntegerEditor : ITypeEditor
        {
            private RedIntegerEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                    };
                    BindingOperations.SetBinding(_editor, RedIntegerEditor.RedIntegerProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedIntegerEditor.RedIntegerProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedIntegerEditor();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }
    }

    
}

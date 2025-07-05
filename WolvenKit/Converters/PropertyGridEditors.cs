using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using WolvenKit.Views.Templates;

namespace WolvenKit.Converters
{
    public class PropertyGridEditors
    {
        public static ITypeEditor GetPropertyEditor(Type PropertyType)
        {
            if (PropertyType.IsAssignableTo(typeof(CString)))
            {
                return new StringEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(CName)))
            {
                return new CNameEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(NodeRef)))
            {
                return new NodeRefEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<ulong>)))
            {
                return new UlongEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(FixedPoint)))
            {
                return new FixedPointEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
            {
                return new FloatEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
            {
                return new IntegerEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<bool>)))
            {
                return new BoolEditor();
            }
            if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
            {
                return new EnumEditor();
            }
            /*
            if (PropertyType.IsAssignableTo(typeof(IRedBaseHandle)))
            {
                return new ChunkPtrEditor();
            }
            */
            if (PropertyType.IsAssignableTo(typeof(IRedRef)))
            {
                return new RefEditor();
            }
            //if (PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
            //{
            //    return new CurveEditor();
            //}
            if (PropertyType.IsAssignableTo(typeof(CColor)))
            {
                return new ColorEditor();
            }

            return null;
        }
        /*
        public class BaseTypeEditor : ITypeEditor
        {
            private RedBaseTypeEditor _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                var binding = new Binding("Value")
                {
                    Source = info,
                    ValidatesOnExceptions = true,
                    ValidatesOnDataErrors = true
                };
                BindingOperations.SetBinding(_editor, RedBaseTypeEditor.RedTypeProperty, binding);
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedBaseTypeEditor();
                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;
            
            public void Detach(PropertyViewItem property)
            {

            }
        }
        */

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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        //public class CurveEditor : ITypeEditor
        //{
        //    private RedCurveEditor _editor;
        //
        //    public void Attach(PropertyViewItem property, PropertyItem info)
        //    {
        //        if (info.CanWrite)
        //        {
        //            var binding = new Binding("Value")
        //            {
        //                Mode = BindingMode.TwoWay,
        //                Source = info,
        //                ValidatesOnExceptions = true,
        //                ValidatesOnDataErrors = true,
        //            };
        //            BindingOperations.SetBinding(_editor, RedCurveEditor.RedCurveProperty, binding);
        //        }
        //        else
        //        {
        //            _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
        //            var binding = new Binding("Value")
        //            {
        //                Source = info,
        //                ValidatesOnExceptions = true,
        //                ValidatesOnDataErrors = true
        //            };
        //            BindingOperations.SetBinding(_editor, RedCurveEditor.RedCurveProperty, binding);
        //        }
        //    }
        //    public object Create(PropertyInfo propertyInfo)
        //    {
        //        _editor = new RedCurveEditor();
        //
        //        return _editor;
        //    }
        //    public void Detach(PropertyViewItem property)
        //    {
        //
        //    }
        //}

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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        /*
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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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
            
            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;
            
            public void Detach(PropertyViewItem property)
            {

            }
        }
        */

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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class CNameEditor : ITypeEditor
        {
            private RedCNameEditor _editor;

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
                    BindingOperations.SetBinding(_editor, RedCNameEditor.RedStringProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedCNameEditor.RedStringProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedCNameEditor();

                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class NodeRefEditor : ITypeEditor
        {
            private RedNodeRefEditor _editor;

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
                    BindingOperations.SetBinding(_editor, RedNodeRefEditor.RedNodeRefProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedNodeRefEditor.RedNodeRefProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedNodeRefEditor();

                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class StringEditor : ITypeEditor
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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class UlongEditor : ITypeEditor
        {
            private RedUlongEditor _editor;

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
                    BindingOperations.SetBinding(_editor, RedUlongEditor.RedNumberProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedUlongEditor.RedNumberProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedUlongEditor();

                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

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
                    BindingOperations.SetBinding(_editor, RedFloatEditor.RedNumberProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedFloatEditor.RedNumberProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedFloatEditor();

                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class FixedPointEditor : ITypeEditor
        {
            private RedFixedPointEditor _editor;

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
                    BindingOperations.SetBinding(_editor, RedFixedPointEditor.RedNumberProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, RedFixedPointEditor.RedNumberProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new RedFixedPointEditor();

                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

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
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
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

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

        public class BrushEditor : ITypeEditor
        {
            private ColorPickerPalette _editor;

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
                        Converter = new StringColorConverter()
                    };
                    BindingOperations.SetBinding(_editor, ColorPickerPalette.ColorProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, ColorPickerPalette.ColorProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new ColorPickerPalette();
                _editor.SetCurrentValue(ColorPickerPalette.AutomaticColorProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DF2935")));

                return _editor;
            }

            public object Create(PropertyDescriptor PropertyDescriptor) => throw new NotImplementedException();
            public bool ShouldPropertyGridTryToHandleKeyDown(Key key) => true;

            public void Detach(PropertyViewItem property)
            {

            }
        }

    }
}

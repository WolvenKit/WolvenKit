using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using Catel.IoC;
using CP77.CR2W.Types;
using HandyControl.Controls;
using HandyControl.Tools;
using Orchestra.Services;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    #region IoC

    public static class PropertyGridResolver
    {
        public static void Initialize()
        {
            var serviceLocator = ServiceLocator.Default;
            
            // Register PropertyEditor services here to the UI
            serviceLocator.RegisterType<ICollectionEditor, REDArrayEditor>();
            serviceLocator.RegisterType<IExpandableObjectEditor, ExpandableObjectEditor>();

            serviceLocator.RegisterType(typeof(ITextEditor<double>), typeof(TextEditor<CDouble>));
            serviceLocator.RegisterType(typeof(ITextEditor<float>), typeof(TextEditor<CFloat>));

            serviceLocator.RegisterType(typeof(ITextEditor<ulong>), typeof(TextEditor<CUInt64>));
            serviceLocator.RegisterType(typeof(ITextEditor<long>), typeof(TextEditor<CInt64>));

            serviceLocator.RegisterType(typeof(ITextEditor<uint>), typeof(TextEditor<CUInt32>));
            serviceLocator.RegisterType(typeof(ITextEditor<int>), typeof(TextEditor<CInt32>));

            serviceLocator.RegisterType(typeof(ITextEditor<ushort>), typeof(TextEditor<CUInt16>));
            serviceLocator.RegisterType(typeof(ITextEditor<short>), typeof(TextEditor<CInt16>));

            serviceLocator.RegisterType(typeof(ITextEditor<byte>), typeof(TextEditor<CUInt8>));
            serviceLocator.RegisterType(typeof(ITextEditor<sbyte>), typeof(TextEditor<CInt8>));

            serviceLocator.RegisterType(typeof(ITextEditor<string>), typeof(TextEditor<CString>));
            serviceLocator.RegisterType(typeof(INameEditor), typeof(TextEditor<CName>));

            serviceLocator.RegisterType(typeof(IBoolEditor), typeof(BoolEditor));
            serviceLocator.RegisterType(typeof(IEnumEditor), typeof(EnumEditor));
            serviceLocator.RegisterType(typeof(IColorEditor), typeof(ColorEditor));
        }
    }

    #endregion

    /// <summary>
    /// Propertygrid editor for numeric values
    /// </summary>
    [Editor(typeof(IColorEditor), typeof(IPropertyEditorBase))]
    public class ColorEditor : EditorBase<IREDColor>, IColorEditor
    {
        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) =>
            new ColorPicker();

        private protected override DependencyProperty GetInnerDependencyProperty() => ColorPicker.SelectedBrushProperty;
    }

    /// <summary>
    /// Propertygrid editor for numeric values
    /// </summary>
    public class TextEditor<T> : EditorBase<T>, ITextEditor<T> where T : class, IEditorBindable
    {
        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) =>
            new System.Windows.Controls.TextBox()
            {
                IsReadOnly = propertyItem.IsReadOnly,
            };

        private protected override DependencyProperty GetInnerDependencyProperty() => System.Windows.Controls.TextBox.TextProperty;
    }

    /// <summary>
    /// Propertygrid editor for CBools
    /// </summary>
    public class BoolEditor : EditorBase<IREDBool>, IBoolEditor
    {
        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) =>
            new ToggleButton
            {
                Style = ResourceHelper.GetResource<Style>("ToggleButtonSwitch"),
                HorizontalAlignment = HorizontalAlignment.Left,
                IsEnabled = !propertyItem.IsReadOnly
            };

        private protected override DependencyProperty GetInnerDependencyProperty() => ToggleButton.IsCheckedProperty;
    }

    /// <summary>
    /// Propertygrid editor for CEnums
    /// </summary>
    public class EnumEditor : EditorBase<IEnumAccessor>, IEnumEditor
    {
        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem)
        {
            var t = propertyItem.PropertyType;

            if (!typeof(IEnumAccessor).IsAssignableFrom(t))
            {
                throw new NotImplementedException();
            }

            var wrappedenumtype = t.GenericTypeArguments.FirstOrDefault();
            if (wrappedenumtype is null)
            {
                throw new NotImplementedException();
            }

            var box = new System.Windows.Controls.ComboBox
            {
                IsEnabled = !propertyItem.IsReadOnly,
                ItemsSource = Enum.GetValues(wrappedenumtype)
            };
            return box;
        }

        private protected override DependencyProperty GetInnerDependencyProperty() => Selector.SelectedValueProperty;
    }
}

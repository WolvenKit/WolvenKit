using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Catel.IoC;
using CP77.CR2W;
using CP77.CR2W.Reflection;
using CP77.CR2W.Types;
using FastMember;
using HandyControl.Controls;
using HandyControl.Tools;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Converters;

namespace WolvenKit.Views.Others.PropertyGridEditors
{
    #region IoC

    public static class PropertyGridResolver
    {
        #region Methods

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
            serviceLocator.RegisterType(typeof(IHandleEditor), typeof(HandleEditor));
            serviceLocator.RegisterType(typeof(IColorEditor), typeof(ColorEditor));
        }

        #endregion Methods

        public static IEditableVariable GetObjectFromPropertyItem(PropertyItem propertyItem)
        {
            dynamic parent = propertyItem.Value;
            if (parent.accessor is TypeAccessor accessor)
            {
                if (accessor[parent, $"{propertyItem.PropertyName}"] is IEditableVariable instance)
                {
                    return instance;
                }
            }

            return null;
        }
    }

    #endregion IoC

    /// <summary>
    /// Propertygrid editor for CBools
    /// </summary>
    public class BoolEditor : EditorBase<IREDBool>, IBoolEditor
    {
        #region Methods

        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) =>
            new ToggleButton
            {
                Style = ResourceHelper.GetResource<Style>("ToggleButtonSwitch"),
                HorizontalAlignment = HorizontalAlignment.Left,
                IsEnabled = !propertyItem.IsReadOnly
            };

        private protected override DependencyProperty GetInnerDependencyProperty() => ToggleButton.IsCheckedProperty;

        #endregion Methods
    }

    /// <summary>
    /// Propertygrid editor for numeric values
    /// </summary>
    [Editor(typeof(IColorEditor), typeof(IPropertyEditorBase))]
    public class ColorEditor : EditorBase<IREDColor>, IColorEditor
    {
        #region Methods

        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) =>
            new ColorPicker();

        private protected override IValueConverter GetInnerConverter() => new ColorToSolidColorBrushConverter();

        private protected override DependencyProperty GetInnerDependencyProperty() => ColorPicker.SelectedBrushProperty;

        #endregion Methods
    }

    /// <summary>
    /// Propertygrid editor for CEnums
    /// </summary>
    public class EnumEditor : EditorBase<IEnumAccessor>, IEnumEditor
    {
        #region Methods

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

        #endregion Methods
    }

    /// <summary>
    /// Propertygrid editor for numeric values
    /// </summary>
    public class TextEditor<T> : EditorBase<T>, ITextEditor<T> where T : class, IEditorBindable
    {
        #region Methods

        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) =>
            new System.Windows.Controls.TextBox()
            {
                IsReadOnly = propertyItem.IsReadOnly,
            };

        private protected override DependencyProperty GetInnerDependencyProperty() => System.Windows.Controls.TextBox.TextProperty;

        #endregion Methods
    }

    /// <summary>
    /// Propertygrid editor for Handles
    /// </summary>
    public class HandleEditor : EditorBase<IHandleAccessor>, IEnumEditor
    {
        #region Methods

        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem)
        {
            var chunks = new List<ICR2WExport>();

            if (PropertyGridResolver.GetObjectFromPropertyItem(propertyItem) is IHandleAccessor instance)
            {
                chunks = instance.GetReferenceChunks().ToList();
            }

            var box = new System.Windows.Controls.ComboBox
            {
                IsEnabled = !propertyItem.IsReadOnly,
                ItemsSource = chunks
            };
            return box;
        }

        private protected override DependencyProperty GetInnerDependencyProperty() => Selector.SelectedValueProperty;

        private protected override string GetBoundPropertyName() => nameof(IHandleAccessor.Reference);

        #endregion Methods
    }
}

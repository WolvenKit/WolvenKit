using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using HandyControl.Controls;
using HandyControl.Tools;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
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
    public class EnumEditor : EditorBase<IEnumAccessor<Enum>>, IEnumEditor
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
                IsEnabled = !propertyItem.IsReadOnly, ItemsSource = Enum.GetValues(wrappedenumtype)
            };
            return box;
        }

        private protected override DependencyProperty GetInnerDependencyProperty() => Selector.SelectedValueProperty;
    }
}

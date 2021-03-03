using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using HandyControl.Controls;

namespace WolvenKit.Functionality.Extensions
{
    public class IListPropertyEditor : PropertyEditorBase
    {
        public override FrameworkElement CreateElement(PropertyItem propertyItem) => new System.Windows.Controls.TextBox
        {
            IsReadOnly = propertyItem.IsReadOnly,
            Background = Brushes.Aqua
        };

        public override DependencyProperty GetDependencyProperty() => System.Windows.Controls.TextBox.TextProperty;
    }

    public class MyPropertyResolver : PropertyResolver
    {
        public MyPropertyResolver() : base()
        {
        }

        private enum EditorTypeCode
        {
            IList,
        }

        private static readonly Dictionary<Type, EditorTypeCode> MyTypeCodeDic = new()
        {
            [typeof(IList)] = EditorTypeCode.IList,
        };
    }
}

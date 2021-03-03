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
        #region Methods

        public override FrameworkElement CreateElement(PropertyItem propertyItem) => new System.Windows.Controls.TextBox
        {
            IsReadOnly = propertyItem.IsReadOnly,
            Background = Brushes.Aqua
        };

        public override DependencyProperty GetDependencyProperty() => System.Windows.Controls.TextBox.TextProperty;

        #endregion Methods
    }

    public class MyPropertyResolver : PropertyResolver
    {
        #region Fields

        private static readonly Dictionary<Type, EditorTypeCode> MyTypeCodeDic = new()
        {
            [typeof(IList)] = EditorTypeCode.IList,
        };

        #endregion Fields

        #region Constructors

        public MyPropertyResolver() : base()
        {
        }

        #endregion Constructors



        #region Enums

        private enum EditorTypeCode
        {
            IList,
        }

        #endregion Enums
    }
}

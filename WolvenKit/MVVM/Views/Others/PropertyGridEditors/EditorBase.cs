using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Functionality.Converters;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    /// <summary>
    /// Abstract base for property grid editors.
    /// T1 ... Wrapper (e.g. CDouble)
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public abstract class EditorBase<T1> : PropertyEditorBase where T1 : class, IEditorBindable
    {
        /// <summary>
        /// Specify the dependency property of the propertygrid editor.
        /// </summary>
        /// <returns></returns>
        private protected abstract DependencyProperty GetInnerDependencyProperty();

        /// <summary>
        /// Create the custom propertygrid editor.
        /// </summary>
        /// <param name="propertyItem"></param>
        /// <returns></returns>
        private protected abstract FrameworkElement CreateInnerElement(PropertyItem propertyItem);

        /// <summary>
        /// Overrride this to specify the wrapped bound property, default is "Value".
        /// </summary>
        /// <returns></returns>
        private protected virtual string GetBoundPropertyName() => "Value";

        /// <summary>
        /// Specify the converter, default is null.
        /// </summary>
        /// <returns></returns>
        private protected virtual IValueConverter GetInnerConverter() => null;

        public override FrameworkElement CreateElement(PropertyItem propertyItem)
        {
            var control = CreateInnerElement(propertyItem);
            CreateInnerBinding(control);

            BindingOperations.SetBinding(
                control,
                Control.BackgroundProperty,
                new Binding($"{nameof(Wrapper)}.IsSerialized")
                {
                    Source = this,
                    Mode = BindingMode.OneWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    Converter = new BoolToBrushConverter(),
                });
            return control;
        }

        #region bindings

        // bind to the private dependency property 
        public override DependencyProperty GetDependencyProperty() => WrapperProperty;

        // bind to this
        public override void CreateBinding(PropertyItem propertyItem, DependencyObject element) =>
            BindingOperations.SetBinding(this, GetDependencyProperty(), new Binding($"{propertyItem.PropertyName}")
            {
                Source = propertyItem.Value,
                Mode = GetBindingMode(propertyItem),
                UpdateSourceTrigger = GetUpdateSourceTrigger(propertyItem),
                Converter = GetConverter(propertyItem)
            });

        // bind the private dependency property to the UI element
        protected virtual void CreateInnerBinding(FrameworkElement element)
        {
            BindingOperations.SetBinding(
                element,
                GetInnerDependencyProperty(),
                new Binding($"{nameof(Wrapper)}.{GetBoundPropertyName()}")
                {
                    Source = this,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    Converter = GetInnerConverter(),
                    NotifyOnSourceUpdated = true,
                    NotifyOnTargetUpdated = true
                });
            element.SourceUpdated += FrameworkElementOnSourceUpdated;
            element.TargetUpdated += ElementOnTargetUpdated;
        }

        private void ElementOnTargetUpdated(object sender, DataTransferEventArgs e)
        {


        }

        private void FrameworkElementOnSourceUpdated(object sender, DataTransferEventArgs e)
        {
            if (!Wrapper.IsSerialized)
            {
                Wrapper.IsSerialized = true;
            }
        }

        #endregion

        #region dependency properties

        protected T1 Wrapper
        {
            get => (T1)GetValue(WrapperProperty);
            set => SetValue(WrapperProperty, value);
        }

        private static readonly DependencyProperty WrapperProperty
            = DependencyProperty.Register(
                nameof(Wrapper),
                typeof(T1),
                typeof(EditorBase<T1>),
                new FrameworkPropertyMetadata(default(T1)/*, OnWrapperChanged*/));

        //private static void OnWrapperChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        //{
            
        //}

        #endregion
    }
}

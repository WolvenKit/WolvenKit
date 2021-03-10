using System.Windows;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.Views.Others.PropertyGridEditors
{
    // we edit an IArrayAccessor (a list wrapper)
    public class REDArrayEditor : EditorBase<IArrayAccessor>, ICollectionEditor
    {
        #region Methods

        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) => new ListEditorView();

        private protected override string GetBoundPropertyName() => "Elements";

        private protected override DependencyProperty GetInnerDependencyProperty() => ListEditorView.ItemsSourceProperty;

        #endregion Methods

        //// bind the dependency property to the UI element
        //protected override void CreateInnerBinding(FrameworkElement element) =>
        //    BindingOperations.SetBinding(
        //        element,
        //        GetInnerDependencyProperty(),
        //        new Binding($"{nameof(Wrapper)}.Value")
        //        {
        //            Source = this,
        //            Mode = BindingMode.TwoWay,
        //            UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
        //        });
    }
}

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    // we edit an IArrayAccessor (a list wrapper)
    public class REDArrayEditor : EditorBase<IArrayAccessor>, ICollectionEditor
    {
        private protected override DependencyProperty GetInnerDependencyProperty() => ListEditorView.ItemsSourceProperty;
        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) => new ListEditorView();

        private protected override string GetBoundPropertyName() => "Elements";

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

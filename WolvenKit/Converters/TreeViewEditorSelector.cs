using System.Windows;
using System.Windows.Controls;
using Syncfusion.UI.Xaml.TreeView.Engine;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters
{
    internal class TreeViewEditorSelector : DataTemplateSelector
    {
        public DataTemplate PropertyEditTemplate { get; set; }
        public DataTemplate ArrayTemplate { get; set; }
        public DataTemplate HandleEditTemplate { get; set; }
        public UserControl Editor { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TreeViewNode tvn)
            {
                if (tvn.Content is ChunkViewModel vm)
                {
                    if (vm.Data is IRedArray)
                    {
                        return ArrayTemplate;
                    }
                    else if (vm.Data is IRedHandle)
                    {
                        //if (vm.Data is IRedBaseHandle)
                        //{
                        //    Editor = new HandleTemplateView();
                        //}
                        return HandleEditTemplate;
                    }
                    else
                    {
                        //if (vm.Data is IRedString)
                        //{
                        //    Editor = new RedStringEditor();
                        //}
                        //if (vm.Data is IRedPrimitive<ulong>)
                        //{
                        //    Editor = new RedUlongEditor();
                        //}
                        //if (vm.Data is IRedInteger)
                        //{
                        //    Editor = new RedIntegerEditor();
                        //}
                        //if (vm.Data is IRedPrimitive<float>)
                        //{
                        //    Editor = new RedFloatEditor();
                        //}
                        //if (vm.Data is IRedPrimitive<bool>)
                        //{
                        //    Editor = new RedBoolEditor();
                        //}
                        //if (vm.Data is IRedEnum)
                        //{
                        //    Editor = new EnumTemplateView();
                        //}
                        //if (vm.Data is IRedRef)
                        //{
                        //    Editor = new RedRefEditor();
                        //}
                        //if (vm.Data is IRedLegacySingleChannelCurve)
                        //{
                        //    Editor = new RedCurveEditor();
                        //}
                        //if (vm.Data is CColor)
                        //{
                        //    Editor = new RedColorEditor();
                        //}
                        return PropertyEditTemplate;
                    }
                }
            }
            return null;

        }
    }
}

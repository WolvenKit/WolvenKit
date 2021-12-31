
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;
using WolvenKit.ViewModels.Documents;
using WolvenKit.Views.Documents;
using WolvenKit.ViewModels.Shell;
using WolvenKit.RED4.Types;
using Syncfusion.UI.Xaml.TreeView.Engine;

namespace WolvenKit.Converters
{
    class RedEditorTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RedStringEditor { get; set; }
        public DataTemplate RedUlongEditor { get; set; }
        public DataTemplate RedFloatEditor { get; set; }
        public DataTemplate RedFixedPointEditor { get; set; }
        public DataTemplate RedIntegerEditor { get; set; }
        public DataTemplate RedColorEditor { get; set; }
        public DataTemplate RedCurveEditor { get; set; }
        public DataTemplate RedRefEditor { get; set; }
        public DataTemplate HandleTemplateView { get; set; }
        public DataTemplate EnumTemplateView { get; set; }
        public DataTemplate ColorPickerPalette { get; set; }
        public DataTemplate RedBoolEditor { get; set; }
        public DataTemplate RedVector3Editor { get; set; }
        public DataTemplate RedVector4Editor { get; set; }
        public DataTemplate RedQuaternionEditor { get; set; }
        public DataTemplate RedWorldPositionEditor { get; set; }
        public DataTemplate RedArrayEditor { get; set; }
        public DataTemplate RedTypeViewer { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is ChunkViewModel vm)
            {
                if (vm.PropertyType == null)
                {
                    return RedTypeViewer;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedString)))
                {
                    return RedStringEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedPrimitive<ulong>)))
                {
                    return RedUlongEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedInteger)))
                {
                    return RedIntegerEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(FixedPoint)))
                {
                    return RedFixedPointEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(Vector3)))
                {
                    return RedVector3Editor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(Vector4)))
                {
                    return RedVector4Editor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(Quaternion)))
                {
                    return RedQuaternionEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(WorldPosition)))
                {
                    return RedWorldPositionEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
                {
                    return RedFloatEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedPrimitive<bool>)))
                {
                    return RedBoolEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    return EnumTemplateView;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedBaseHandle)))
                {
                    return RedArrayEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedRef)))
                {
                    return RedRefEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
                {
                    return RedCurveEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(CColor)))
                {
                    return RedColorEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    return RedArrayEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(RedBaseClass)) && vm.Properties != null && vm.Properties.Count < 5)
                {
                    return RedArrayEditor;
                }
                return RedTypeViewer;
            }
            return null;
        }
    }
}

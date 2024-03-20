using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters
{
    internal class RedEditorTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RedStringEditor { get; set; }
        public DataTemplate RedCNameEditor { get; set; }
        public DataTemplate RedUlongEditor { get; set; }
        public DataTemplate RedTweakEditor { get; set; }
        public DataTemplate RedFloatEditor { get; set; }
        public DataTemplate RedFixedPointEditor { get; set; }
        public DataTemplate RedChunkMaskEditor { get; set; }
        public DataTemplate RedIntegerEditor { get; set; }
        public DataTemplate RedColorEditor { get; set; }
        public DataTemplate RedVectorColorEditor { get; set; }
        public DataTemplate RedColorPicker { get; set; }
        public DataTemplate RedCurveEditor { get; set; }
        public DataTemplate RedCurvePointEditor { get; set; }
        public DataTemplate RedRefEditor { get; set; }
        public DataTemplate RedNodeRefEditor { get; set; }
        public DataTemplate HandleTemplateView { get; set; }
        public DataTemplate BitfieldTemplateView { get; set; }
        public DataTemplate EnumTemplateView { get; set; }
        public DataTemplate ColorPickerPalette { get; set; }
        public DataTemplate RedBoolEditor { get; set; }
        public DataTemplate RedVector3Editor { get; set; }
        public DataTemplate RedVector4Editor { get; set; }
        public DataTemplate RedQuaternionEditor { get; set; }
        public DataTemplate RedWorldPositionEditor { get; set; }
        public DataTemplate RedArrayEditor { get; set; }
        public DataTemplate RedTypeViewer { get; set; }
        public DataTemplate NullTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return NullTemplate;
            }
            if (item is ChunkViewModel vm)
            {
                if (vm.PropertyType.IsAssignableTo(typeof(NodeRef)))
                {
                    return RedNodeRefEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(CString)))
                {
                    return RedStringEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(CName)))
                {
                    return RedCNameEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(TweakDBID)))
                {
                    return RedTweakEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedPrimitive<ulong>)))
                {
                    if (vm.PropertyName == "chunkMask")
                    {
                        return RedChunkMaskEditor;
                    }
                    else
                    {
                        return RedUlongEditor;
                    }
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
                    // Some vectors are actually colours
                    if (vm.Parent?.ResolvedData is CKeyValuePair pair && pair.Key.GetResolvedText() == "BaseColorScale")
                    {
                        return RedVectorColorEditor;
                    }
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
                if (vm.PropertyType.IsAssignableTo(typeof(IRedInteger)))
                {
                    return RedIntegerEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedPrimitive<bool>)))
                {
                    return RedBoolEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedBitField)))
                {
                    return BitfieldTemplateView;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    return EnumTemplateView;
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
                if (vm.PropertyType.IsAssignableTo(typeof(HDRColor)))
                {
                    return RedColorPicker;
                }
                //if (vm.PropertyType.IsAssignableTo(typeof(IRedArray)))
                //{
                //    return RedArrayEditor;
                //}
                if (vm.PropertyType.IsAssignableTo(typeof(IRedBufferPointer)))
                {
                    return RedArrayEditor;
                }
                if (vm.PropertyType.IsAssignableTo(typeof(IRedCurvePoint)))
                {
                    return RedCurvePointEditor;
                }
                if (vm.HasChildren())
                {
                    return RedArrayEditor;
                }
                //if (vm.ResolvedData is RedBaseClass && (
                //    ((vm.Properties == null || vm.Properties.Count < 5) && vm.DetailsLevel <= 0) ||
                //    (vm.ForceLoadProperties && vm.DetailsLevel <= 2)) && (vm.Properties == null || vm.Properties.Count < 500))
                //{
                //    return RedArrayEditor;
                //}
                return RedTypeViewer;
            }
            return null;
        }
    }
}

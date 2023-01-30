using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters
{
    public class EditableVariableDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CommmonTemplate { get; set; }
        public DataTemplate CNameTemplateView { get; set; }
        public DataTemplate StringTemplateView { get; set; }
        public DataTemplate NodeRefTemplateView { get; set; }
        public DataTemplate RedboolTemplate { get; set; }
        public DataTemplate NumericTemplate { get; set; }
        public DataTemplate EnumTemplate { get; set; }
        public DataTemplate HandleTemplateView { get; set; }
        public DataTemplate RefTemplateView { get; set; }
        public DataTemplate ColorTemplateView { get; set; }
        public DataTemplate SingleChannelCurveTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) =>
            item is not ChunkPropertyViewModel editableVariable
                ? null
                : GetTemplate(editableVariable.Property);

        private DataTemplate GetTemplate(IRedType variable) =>
            variable switch
            {
                IRedPrimitive<bool> => RedboolTemplate,        //done in PG
                CString => StringTemplateView,   //done in PG
                CName => CNameTemplateView,   //done in PG
                NodeRef => NodeRefTemplateView,   //done in PG
                IRedInteger => NumericTemplate, //done in PG
                IRedEnum => EnumTemplate,           //done in PG
                IRedBaseHandle => HandleTemplateView, //done in PG
                IRedRef => RefTemplateView,         //done in PG
                CColor x => ColorTemplateView,   //done in PG
                IRedArray => CommmonTemplate,       //done in PG
                IRedLegacySingleChannelCurve => SingleChannelCurveTemplate,   //done in PG
                _ => CommmonTemplate
            };
    }
}

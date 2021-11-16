using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Assimp;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Converters
{
    public class EditableVariableDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CommmonTemplate { get; set; }
        public DataTemplate StringTemplateView { get; set; }
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
                IRedPrimitive<string> => StringTemplateView,   //done in PG
                IREDIntegerType => NumericTemplate, //done in PG
                IRedEnum => EnumTemplate,           //done in PG
                IREDChunkPtr => HandleTemplateView, //done in PG
                IRedRef => RefTemplateView,         //done in PG
                CColor x => ColorTemplateView,   //done in PG
                IRedArray => CommmonTemplate,       //done in PG
                ICurveDataAccessor => SingleChannelCurveTemplate,   //done in PG
                _ => CommmonTemplate
            };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Assimp;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Templates
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

        private DataTemplate GetTemplate(IEditableVariable variable) =>
            variable switch
            {
                IREDBool => RedboolTemplate,        //done in PG
                IREDString => StringTemplateView,   //done in PG
                IREDIntegerType => NumericTemplate, //done in PG
                IREDEnum => EnumTemplate,           //done in PG
                IREDChunkPtr => HandleTemplateView, //done in PG
                IREDRef => RefTemplateView,         //done in PG
                IREDColor x => ColorTemplateView,   //done in PG
                IREDArray => CommmonTemplate,       //done in PG
                ICurveDataAccessor => SingleChannelCurveTemplate,   //done in PG
                _ => CommmonTemplate
            };
    }
}

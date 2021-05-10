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
        public DataTemplate RedboolTemplate { get; set; }
        public DataTemplate NumericTemplate { get; set; }
        public DataTemplate EnumTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) =>
            item is not ChunkPropertyViewModel editableVariable
                ? null
                : editableVariable.Property switch
                {
                    IREDBool => RedboolTemplate,
                    IREDString => RedboolTemplate,
                    IREDIntegerType => NumericTemplate,
                    IEnumAccessor => EnumTemplate,
                    _ => CommmonTemplate
                };
    }
}

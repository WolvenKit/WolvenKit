using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Assimp;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Views.Templates
{
    public class IEditableVariableDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CommmonTemplate { get; set; }
        public DataTemplate RedboolTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var editableVariable = item as IEditableVariable;

            return editableVariable switch
            {
                IREDBool => RedboolTemplate,
                _ => CommmonTemplate
            };
        }
    }
}

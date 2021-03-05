using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using HandyControl.Controls;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    public class MyPropertyResolver : PropertyResolver
    {
        public override PropertyEditorBase CreateEditor(Type type, Type baseType)
        {
            // support editor services
            // check if basetype is correctly specified (redundant)
            if (baseType == typeof(IPropertyEditorBase))
            {
                //check if interface
                //if (type == typeof(IPropertyEditorBase))
                if (typeof(IPropertyEditorBase).IsAssignableFrom(type))
                {
                    var service = ServiceLocator.Default.ResolveType(type);
                    return base.CreateEditor(service.GetType(), typeof(PropertyEditorBase));
                }
            }

            return base.CreateEditor(type, baseType);

        }
    }
}

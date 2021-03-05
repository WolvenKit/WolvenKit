using System;
using HandyControl.Controls;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    public class MyPropertyResolver : PropertyResolver
    {
        #region Methods

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

        #endregion Methods
    }
}

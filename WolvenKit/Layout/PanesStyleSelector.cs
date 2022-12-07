using System.Windows;
using System.Windows.Controls;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Functionality.Layout
{
    internal class PanesStyleSelector : StyleSelector
    {
        #region Properties

        public Style FileStyle
        {
            get;
            set;
        }

        public Style ToolStyle
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        public override Style SelectStyle(object item, DependencyObject container)
        {
            return item switch
            {
                ToolViewModel _ => ToolStyle,
                DocumentViewModel _ => FileStyle,
                _ => base.SelectStyle(item, container),
            };
        }

        #endregion Methods
    }
}

using System.Windows;
using System.Windows.Controls;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools;

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

        public override System.Windows.Style SelectStyle(object item, System.Windows.DependencyObject container)
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

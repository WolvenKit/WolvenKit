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

        public override System.Windows.Style SelectStyle(object item, System.Windows.DependencyObject container)
        {
            switch (item)
            {
                case ToolViewModel _:
                    return ToolStyle;

                case DocumentViewModel _:
                    return FileStyle;

                default:
                    return base.SelectStyle(item, container);
            }
        }

        #endregion Methods
    }
}

namespace WolvenKit.Layout
{
	using System.Windows.Controls;
	using System.Windows;
    using WolvenKit.ViewModels;

    class PanesStyleSelector : StyleSelector
	{
		public Style ToolStyle
		{
			get;
			set;
		}

		public Style FileStyle
		{
			get;
			set;
		}

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
	}
}

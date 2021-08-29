using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipModuleController : inkWidgetLogicController
	{
		private inkWidgetReference _lineWidget;

		[Ordinal(1)] 
		[RED("lineWidget")] 
		public inkWidgetReference LineWidget
		{
			get => GetProperty(ref _lineWidget);
			set => SetProperty(ref _lineWidget, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipModuleController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("lineWidget")] 
		public inkWidgetReference LineWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ItemTooltipModuleController()
		{
			LineWidget = new();
		}
	}
}

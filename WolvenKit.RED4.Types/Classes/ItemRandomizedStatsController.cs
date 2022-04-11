using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemRandomizedStatsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemRandomizedStatsController()
		{
			StatName = new();
		}
	}
}

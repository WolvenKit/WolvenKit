using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TrophyTooltipController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("trophyTooltipSpawner")] 
		public inkWidgetReference TrophyTooltipSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public TrophyTooltipController()
		{
			TrophyTooltipSpawner = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

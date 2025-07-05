using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BarHoverOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<RipperdocBarTooltipTooltipData> Data
		{
			get => GetPropertyValue<CHandle<RipperdocBarTooltipTooltipData>>();
			set => SetPropertyValue<CHandle<RipperdocBarTooltipTooltipData>>(value);
		}

		public BarHoverOverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

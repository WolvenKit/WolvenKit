using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkHoverEventTooltipData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<IDisplayData> Data
		{
			get => GetPropertyValue<CHandle<IDisplayData>>();
			set => SetPropertyValue<CHandle<IDisplayData>>(value);
		}

		[Ordinal(2)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get => GetPropertyValue<CEnum<gameuiETooltipPlacement>>();
			set => SetPropertyValue<CEnum<gameuiETooltipPlacement>>(value);
		}

		[Ordinal(3)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PerkHoverEventTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

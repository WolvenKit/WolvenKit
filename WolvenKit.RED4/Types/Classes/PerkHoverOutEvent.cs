using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkHoverOutEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("perkData")] 
		public CHandle<BasePerkDisplayData> PerkData
		{
			get => GetPropertyValue<CHandle<BasePerkDisplayData>>();
			set => SetPropertyValue<CHandle<BasePerkDisplayData>>(value);
		}

		public PerkHoverOutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

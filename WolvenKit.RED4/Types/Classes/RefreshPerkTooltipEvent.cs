using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshPerkTooltipEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<inkWidget> Target
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("perkData")] 
		public CHandle<NewPerkDisplayData> PerkData
		{
			get => GetPropertyValue<CHandle<NewPerkDisplayData>>();
			set => SetPropertyValue<CHandle<NewPerkDisplayData>>(value);
		}

		public RefreshPerkTooltipEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

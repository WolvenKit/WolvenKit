using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReleasePreloadedEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entReleasePreloadedEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

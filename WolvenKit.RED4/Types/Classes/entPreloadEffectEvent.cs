using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPreloadEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entPreloadEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

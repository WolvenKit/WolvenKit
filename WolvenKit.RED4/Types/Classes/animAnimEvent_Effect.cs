using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_Effect : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimEvent_Effect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

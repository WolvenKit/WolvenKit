using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_ItemEffect : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimEvent_ItemEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

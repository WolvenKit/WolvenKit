using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_SoundFromEmitter : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimEvent_SoundFromEmitter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

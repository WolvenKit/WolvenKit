using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsPlaySoundOnEmitter : gameaudioeventsEmitterEvent
	{
		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsPlaySoundOnEmitter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

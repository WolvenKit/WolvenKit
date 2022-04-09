using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsStopSoundOnEmitter : gameaudioeventsEmitterEvent
	{
		[Ordinal(1)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsStopSoundOnEmitter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

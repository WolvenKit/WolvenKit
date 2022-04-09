using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlaySoundEvent : MusicSettings
	{
		[Ordinal(1)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PlaySoundEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

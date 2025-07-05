using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayNewPerksSoundEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("rumbleStrength")] 
		public CEnum<inkRumbleStrength> RumbleStrength
		{
			get => GetPropertyValue<CEnum<inkRumbleStrength>>();
			set => SetPropertyValue<CEnum<inkRumbleStrength>>(value);
		}

		[Ordinal(2)] 
		[RED("stopIfPlaying")] 
		public CBool StopIfPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayNewPerksSoundEvent()
		{
			StopIfPlaying = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

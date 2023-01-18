using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpeakerControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("speakerSetup")] 
		public SpeakerSetup SpeakerSetup
		{
			get => GetPropertyValue<SpeakerSetup>();
			set => SetPropertyValue<SpeakerSetup>(value);
		}

		[Ordinal(105)] 
		[RED("currentValue")] 
		public CName CurrentValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(106)] 
		[RED("previousValue")] 
		public CName PreviousValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SpeakerControllerPS()
		{
			DeviceName = "LocKey#166";
			TweakDBRecord = 67691775111;
			TweakDBDescriptionRecord = 118735618267;
			SpeakerSetup = new() { Range = 10.000000F, GlitchSFX = "dev_radio_ditraction_glitching" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpeakerControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("speakerSetup")] 
		public SpeakerSetup SpeakerSetup
		{
			get => GetPropertyValue<SpeakerSetup>();
			set => SetPropertyValue<SpeakerSetup>(value);
		}

		[Ordinal(108)] 
		[RED("currentValue")] 
		public CName CurrentValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(109)] 
		[RED("previousValue")] 
		public CName PreviousValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SpeakerControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

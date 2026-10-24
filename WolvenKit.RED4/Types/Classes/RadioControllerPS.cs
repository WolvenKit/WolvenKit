using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(112)] 
		[RED("radioSetup")] 
		public RadioSetup RadioSetup
		{
			get => GetPropertyValue<RadioSetup>();
			set => SetPropertyValue<RadioSetup>(value);
		}

		[Ordinal(113)] 
		[RED("wasRadioSetup")] 
		public CBool WasRadioSetup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RadioControllerPS()
		{
			DeviceName = "LocKey#96";
			TweakDBRecord = "Devices.Radio";
			TweakDBDescriptionRecord = "device_descriptions.Radio";
			RadioSetup = new RadioSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("radioSetup")] 
		public RadioSetup RadioSetup
		{
			get => GetPropertyValue<RadioSetup>();
			set => SetPropertyValue<RadioSetup>(value);
		}

		[Ordinal(110)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetPropertyValue<CArray<RadioStationsMap>>();
			set => SetPropertyValue<CArray<RadioStationsMap>>(value);
		}

		[Ordinal(111)] 
		[RED("stationsInitialized")] 
		public CBool StationsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RadioControllerPS()
		{
			DeviceName = "LocKey#96";
			TweakDBRecord = "Devices.Radio";
			TweakDBDescriptionRecord = 109081313862;
			RadioSetup = new RadioSetup();
			Stations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

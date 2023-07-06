using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Radio : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetPropertyValue<CArray<RadioStationsMap>>();
			set => SetPropertyValue<CArray<RadioStationsMap>>(value);
		}

		[Ordinal(95)] 
		[RED("startingStation")] 
		public CInt32 StartingStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(96)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public Radio()
		{
			ControllerTypeName = "RadioController";
			Stations = new();
			ShortGlitchDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

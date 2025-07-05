using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAudioPSData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("activeRadioStation")] 
		public CName ActiveRadioStation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("glassAcousticIsolationFactor")] 
		public CFloat GlassAcousticIsolationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayerVehicleSummoned")] 
		public CBool IsPlayerVehicleSummoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("openedWindows", 6)] 
		public CStatic<CName> OpenedWindows
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		public vehicleAudioPSData()
		{
			AcousticIsolationFactor = float.MinValue;
			GlassAcousticIsolationFactor = float.MinValue;
			OpenedWindows = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

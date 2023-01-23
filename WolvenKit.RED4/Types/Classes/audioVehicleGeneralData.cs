using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleGeneralData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("revSoundbankName")] 
		public CName RevSoundbankName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("revElectricSoundbankName")] 
		public CName RevElectricSoundbankName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("reverbSoundbankName")] 
		public CName ReverbSoundbankName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("enterVehicleEvent")] 
		public CName EnterVehicleEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("exitVehicleEvent")] 
		public CName ExitVehicleEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("ignitionStartEvent")] 
		public CName IgnitionStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("ignitionEndEvent")] 
		public CName IgnitionEndEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("hornOnEvent")] 
		public CName HornOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("hornOffEvent")] 
		public CName HornOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("policeHornOnEvent")] 
		public CName PoliceHornOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("policeHornOffEvent")] 
		public CName PoliceHornOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("trafficPanicHornOnEvent")] 
		public CName TrafficPanicHornOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("trafficPanicHornOffEvent")] 
		public CName TrafficPanicHornOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("sirenOnEvent")] 
		public CName SirenOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("sirenOffEvent")] 
		public CName SirenOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("rainStartEvent")] 
		public CName RainStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("rainStopEvent")] 
		public CName RainStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("waterStartEvent")] 
		public CName WaterStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("waterStopEvent")] 
		public CName WaterStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("tyreBurstEvent")] 
		public CName TyreBurstEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("skid")] 
		public CName Skid
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("inclination")] 
		public CName Inclination
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("impactVelocity")] 
		public CName ImpactVelocity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("impactGridCellRawChange")] 
		public CName ImpactGridCellRawChange
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("collisionSoundEvent")] 
		public CName CollisionSoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("interiorReverbBus")] 
		public CName InteriorReverbBus
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("acoustingIsolationFactor")] 
		public CName AcoustingIsolationFactor
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("dopplerShift")] 
		public CName DopplerShift
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("vehicleDoorsSettings")] 
		public audioVehicleDoorsSettingsMetadata VehicleDoorsSettings
		{
			get => GetPropertyValue<audioVehicleDoorsSettingsMetadata>();
			set => SetPropertyValue<audioVehicleDoorsSettingsMetadata>(value);
		}

		[Ordinal(29)] 
		[RED("vehicleInteriorParameterData")] 
		public audioVehicleInteriorParameterData VehicleInteriorParameterData
		{
			get => GetPropertyValue<audioVehicleInteriorParameterData>();
			set => SetPropertyValue<audioVehicleInteriorParameterData>(value);
		}

		[Ordinal(30)] 
		[RED("vehicleTemperatureSettings")] 
		public audioVehicleTemperatureSettings VehicleTemperatureSettings
		{
			get => GetPropertyValue<audioVehicleTemperatureSettings>();
			set => SetPropertyValue<audioVehicleTemperatureSettings>(value);
		}

		public audioVehicleGeneralData()
		{
			VehicleDoorsSettings = new() { Door = new(), Trunk = new(), Hood = new() };
			VehicleInteriorParameterData = new() { EnterCurveType = Enums.audioESoundCurveType.Linear, EnterCurveTime = 3.000000F, EnterDelayTime = 2.000000F, ExitCurveType = Enums.audioESoundCurveType.Linear, ExitCurveTime = 3.000000F, ExitDelayTime = 2.000000F };
			VehicleTemperatureSettings = new() { RpmThreshold = 3.000000F, TimeToActivateTemperature = 8.000000F, CooldownTime = 10.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

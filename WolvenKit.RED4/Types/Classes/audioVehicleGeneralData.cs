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
		[RED("UIStartEvent")] 
		public CName UIStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("UIEndEvent")] 
		public CName UIEndEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("hornOnEvent")] 
		public CName HornOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("hornOffEvent")] 
		public CName HornOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("policeHornOnEvent")] 
		public CName PoliceHornOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("policeHornOffEvent")] 
		public CName PoliceHornOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("trafficPanicHornOnEvent")] 
		public CName TrafficPanicHornOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("trafficPanicHornOffEvent")] 
		public CName TrafficPanicHornOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("sirenOnEvent")] 
		public CName SirenOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("sirenOffEvent")] 
		public CName SirenOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("rainStartEvent")] 
		public CName RainStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("rainStopEvent")] 
		public CName RainStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("waterStartEvent")] 
		public CName WaterStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("waterStopEvent")] 
		public CName WaterStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("tyreBurstEvent")] 
		public CName TyreBurstEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("skid")] 
		public CName Skid
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("inclination")] 
		public CName Inclination
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("impactVelocity")] 
		public CName ImpactVelocity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("impactGridCellRawChange")] 
		public CName ImpactGridCellRawChange
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("collisionSoundEvent")] 
		public CName CollisionSoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("brakeApplyEvent")] 
		public CName BrakeApplyEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("brakeReleaseEvent")] 
		public CName BrakeReleaseEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("handbrakeApplyEvent")] 
		public CName HandbrakeApplyEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("handbrakeReleaseEvent")] 
		public CName HandbrakeReleaseEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("brakeLoopStartEvent")] 
		public CName BrakeLoopStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("brakeLoopEndEvent")] 
		public CName BrakeLoopEndEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("lightsOnEvent")] 
		public CName LightsOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("lightsOffEvent")] 
		public CName LightsOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("interiorReverbBus")] 
		public CName InteriorReverbBus
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("acoustingIsolationFactor")] 
		public CName AcoustingIsolationFactor
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("dopplerShift")] 
		public CName DopplerShift
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("vehicleDoorsSettings")] 
		public audioVehicleDoorsSettingsMetadata VehicleDoorsSettings
		{
			get => GetPropertyValue<audioVehicleDoorsSettingsMetadata>();
			set => SetPropertyValue<audioVehicleDoorsSettingsMetadata>(value);
		}

		[Ordinal(39)] 
		[RED("vehicleInteriorParameterData")] 
		public audioVehicleInteriorParameterData VehicleInteriorParameterData
		{
			get => GetPropertyValue<audioVehicleInteriorParameterData>();
			set => SetPropertyValue<audioVehicleInteriorParameterData>(value);
		}

		[Ordinal(40)] 
		[RED("vehicleTemperatureSettings")] 
		public audioVehicleTemperatureSettings VehicleTemperatureSettings
		{
			get => GetPropertyValue<audioVehicleTemperatureSettings>();
			set => SetPropertyValue<audioVehicleTemperatureSettings>(value);
		}

		public audioVehicleGeneralData()
		{
			VehicleDoorsSettings = new audioVehicleDoorsSettingsMetadata { Door = new audioVehicleDoorsSettings(), Trunk = new audioVehicleDoorsSettings(), Hood = new audioVehicleDoorsSettings() };
			VehicleInteriorParameterData = new audioVehicleInteriorParameterData { EnterCurveType = Enums.audioESoundCurveType.Linear, EnterCurveTime = 3.000000F, EnterDelayTime = 2.000000F, ExitCurveType = Enums.audioESoundCurveType.Linear, ExitCurveTime = 3.000000F, ExitDelayTime = 2.000000F };
			VehicleTemperatureSettings = new audioVehicleTemperatureSettings { RpmThreshold = 3.000000F, TimeToActivateTemperature = 8.000000F, CooldownTime = 10.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

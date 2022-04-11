using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("generalData")] 
		public audioVehicleGeneralData GeneralData
		{
			get => GetPropertyValue<audioVehicleGeneralData>();
			set => SetPropertyValue<audioVehicleGeneralData>(value);
		}

		[Ordinal(2)] 
		[RED("mechanicalData")] 
		public audioVehicleMechanicalData MechanicalData
		{
			get => GetPropertyValue<audioVehicleMechanicalData>();
			set => SetPropertyValue<audioVehicleMechanicalData>(value);
		}

		[Ordinal(3)] 
		[RED("wheelData")] 
		public audioVehicleWheelData WheelData
		{
			get => GetPropertyValue<audioVehicleWheelData>();
			set => SetPropertyValue<audioVehicleWheelData>(value);
		}

		[Ordinal(4)] 
		[RED("emitterPositionData")] 
		public audioVehicleEmitterPositionData EmitterPositionData
		{
			get => GetPropertyValue<audioVehicleEmitterPositionData>();
			set => SetPropertyValue<audioVehicleEmitterPositionData>(value);
		}

		[Ordinal(5)] 
		[RED("minRpm")] 
		public CFloat MinRpm
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxRpm")] 
		public CFloat MaxRpm
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("vehicleCollisionSettings")] 
		public CName VehicleCollisionSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleGridDestructionSettings")] 
		public CName VehicleGridDestructionSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("vehiclePartSettings")] 
		public CName VehiclePartSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("collisionCooldown")] 
		public CFloat CollisionCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("maxPlayingDistance")] 
		public CFloat MaxPlayingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("suspensionSqueekTimeout")] 
		public CFloat SuspensionSqueekTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("exitDelay")] 
		public CFloat ExitDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("gearSweeteners")] 
		public CArray<CName> GearSweeteners
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(16)] 
		[RED("testWheelMaterial")] 
		public CBool TestWheelMaterial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("hasRadioReceiver")] 
		public CBool HasRadioReceiver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("usesPoliceRadioStation")] 
		public CBool UsesPoliceRadioStation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("trafficEmitterMetadata")] 
		public CName TrafficEmitterMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("radioReceiverType")] 
		public CName RadioReceiverType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("matchingStartupRadioStations")] 
		public CArray<CName> MatchingStartupRadioStations
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(23)] 
		[RED("radioPlaysWhenEngineStartsProbability")] 
		public CFloat RadioPlaysWhenEngineStartsProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVehicleMetadata()
		{
			GeneralData = new() { VehicleDoorsSettings = new() { Door = new(), Trunk = new(), Hood = new() }, VehicleInteriorParameterData = new() { EnterCurveType = Enums.audioESoundCurveType.Linear, EnterCurveTime = 3.000000F, EnterDelayTime = 2.000000F, ExitCurveType = Enums.audioESoundCurveType.Linear, ExitCurveTime = 3.000000F, ExitDelayTime = 2.000000F }, VehicleTemperatureSettings = new() { RpmThreshold = 3.000000F, TimeToActivateTemperature = 8.000000F, CooldownTime = 10.000000F } };
			MechanicalData = new();
			WheelData = new() { WheelStartEvents = new(), WheelStopEvents = new(), WheelRegularSuspensionImpacts = new(), WheelLandingSuspensionImpacts = new(), SuspensionPressureMultiplier = 2.000000F, LandingSuspensionPressureMultiplier = 1.000000F, SuspensionPressureLimit = 1.000000F, MinSuspensionPressureThreshold = 0.100000F, SuspensionImpactCooldown = 0.200000F, MinWheelTimeInAirBeforeLanding = 0.500000F };
			EmitterPositionData = new() { EngineEmitterPosition = new(), ExaustEmitterPosition = new(), CentralEmitterPosition = new(), HoodEmitterPosition = new(), TrunkEmitterPosition = new(), Wheel1Position = new(), Wheel2Position = new(), Wheel3Position = new(), Wheel4Position = new() };
			DopplerFactor = 1.000000F;
			GearSweeteners = new();
			AcousticIsolationFactor = 1.000000F;
			TrafficEmitterMetadata = "acousticsemitter_default_occl_obstr_ignore_5m";
			RadioReceiverType = "radio_car";
			MatchingStartupRadioStations = new();
			RadioPlaysWhenEngineStartsProbability = 0.300000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

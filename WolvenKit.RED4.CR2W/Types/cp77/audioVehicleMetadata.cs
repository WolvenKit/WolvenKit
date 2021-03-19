using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMetadata : audioCustomEmitterMetadata
	{
		private audioVehicleGeneralData _generalData;
		private audioVehicleMechanicalData _mechanicalData;
		private audioVehicleWheelData _wheelData;
		private audioVehicleEmitterPositionData _emitterPositionData;
		private CFloat _minRpm;
		private CFloat _maxRpm;
		private CName _vehicleCollisionSettings;
		private CName _vehicleGridDestructionSettings;
		private CName _vehiclePartSettings;
		private CFloat _collisionCooldown;
		private CFloat _maxPlayingDistance;
		private CFloat _dopplerFactor;
		private CFloat _suspensionSqueekTimeout;
		private CFloat _exitDelay;
		private CArray<CName> _gearSweeteners;
		private CBool _testWheelMaterial;
		private CBool _hasRadioReceiver;
		private CBool _usesPoliceRadioStation;
		private CFloat _acousticIsolationFactor;
		private CName _trafficEmitterMetadata;
		private CName _radioReceiverType;
		private CArray<CName> _matchingStartupRadioStations;
		private CFloat _radioPlaysWhenEngineStartsProbability;

		[Ordinal(1)] 
		[RED("generalData")] 
		public audioVehicleGeneralData GeneralData
		{
			get => GetProperty(ref _generalData);
			set => SetProperty(ref _generalData, value);
		}

		[Ordinal(2)] 
		[RED("mechanicalData")] 
		public audioVehicleMechanicalData MechanicalData
		{
			get => GetProperty(ref _mechanicalData);
			set => SetProperty(ref _mechanicalData, value);
		}

		[Ordinal(3)] 
		[RED("wheelData")] 
		public audioVehicleWheelData WheelData
		{
			get => GetProperty(ref _wheelData);
			set => SetProperty(ref _wheelData, value);
		}

		[Ordinal(4)] 
		[RED("emitterPositionData")] 
		public audioVehicleEmitterPositionData EmitterPositionData
		{
			get => GetProperty(ref _emitterPositionData);
			set => SetProperty(ref _emitterPositionData, value);
		}

		[Ordinal(5)] 
		[RED("minRpm")] 
		public CFloat MinRpm
		{
			get => GetProperty(ref _minRpm);
			set => SetProperty(ref _minRpm, value);
		}

		[Ordinal(6)] 
		[RED("maxRpm")] 
		public CFloat MaxRpm
		{
			get => GetProperty(ref _maxRpm);
			set => SetProperty(ref _maxRpm, value);
		}

		[Ordinal(7)] 
		[RED("vehicleCollisionSettings")] 
		public CName VehicleCollisionSettings
		{
			get => GetProperty(ref _vehicleCollisionSettings);
			set => SetProperty(ref _vehicleCollisionSettings, value);
		}

		[Ordinal(8)] 
		[RED("vehicleGridDestructionSettings")] 
		public CName VehicleGridDestructionSettings
		{
			get => GetProperty(ref _vehicleGridDestructionSettings);
			set => SetProperty(ref _vehicleGridDestructionSettings, value);
		}

		[Ordinal(9)] 
		[RED("vehiclePartSettings")] 
		public CName VehiclePartSettings
		{
			get => GetProperty(ref _vehiclePartSettings);
			set => SetProperty(ref _vehiclePartSettings, value);
		}

		[Ordinal(10)] 
		[RED("collisionCooldown")] 
		public CFloat CollisionCooldown
		{
			get => GetProperty(ref _collisionCooldown);
			set => SetProperty(ref _collisionCooldown, value);
		}

		[Ordinal(11)] 
		[RED("maxPlayingDistance")] 
		public CFloat MaxPlayingDistance
		{
			get => GetProperty(ref _maxPlayingDistance);
			set => SetProperty(ref _maxPlayingDistance, value);
		}

		[Ordinal(12)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get => GetProperty(ref _dopplerFactor);
			set => SetProperty(ref _dopplerFactor, value);
		}

		[Ordinal(13)] 
		[RED("suspensionSqueekTimeout")] 
		public CFloat SuspensionSqueekTimeout
		{
			get => GetProperty(ref _suspensionSqueekTimeout);
			set => SetProperty(ref _suspensionSqueekTimeout, value);
		}

		[Ordinal(14)] 
		[RED("exitDelay")] 
		public CFloat ExitDelay
		{
			get => GetProperty(ref _exitDelay);
			set => SetProperty(ref _exitDelay, value);
		}

		[Ordinal(15)] 
		[RED("gearSweeteners")] 
		public CArray<CName> GearSweeteners
		{
			get => GetProperty(ref _gearSweeteners);
			set => SetProperty(ref _gearSweeteners, value);
		}

		[Ordinal(16)] 
		[RED("testWheelMaterial")] 
		public CBool TestWheelMaterial
		{
			get => GetProperty(ref _testWheelMaterial);
			set => SetProperty(ref _testWheelMaterial, value);
		}

		[Ordinal(17)] 
		[RED("hasRadioReceiver")] 
		public CBool HasRadioReceiver
		{
			get => GetProperty(ref _hasRadioReceiver);
			set => SetProperty(ref _hasRadioReceiver, value);
		}

		[Ordinal(18)] 
		[RED("usesPoliceRadioStation")] 
		public CBool UsesPoliceRadioStation
		{
			get => GetProperty(ref _usesPoliceRadioStation);
			set => SetProperty(ref _usesPoliceRadioStation, value);
		}

		[Ordinal(19)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get => GetProperty(ref _acousticIsolationFactor);
			set => SetProperty(ref _acousticIsolationFactor, value);
		}

		[Ordinal(20)] 
		[RED("trafficEmitterMetadata")] 
		public CName TrafficEmitterMetadata
		{
			get => GetProperty(ref _trafficEmitterMetadata);
			set => SetProperty(ref _trafficEmitterMetadata, value);
		}

		[Ordinal(21)] 
		[RED("radioReceiverType")] 
		public CName RadioReceiverType
		{
			get => GetProperty(ref _radioReceiverType);
			set => SetProperty(ref _radioReceiverType, value);
		}

		[Ordinal(22)] 
		[RED("matchingStartupRadioStations")] 
		public CArray<CName> MatchingStartupRadioStations
		{
			get => GetProperty(ref _matchingStartupRadioStations);
			set => SetProperty(ref _matchingStartupRadioStations, value);
		}

		[Ordinal(23)] 
		[RED("radioPlaysWhenEngineStartsProbability")] 
		public CFloat RadioPlaysWhenEngineStartsProbability
		{
			get => GetProperty(ref _radioPlaysWhenEngineStartsProbability);
			set => SetProperty(ref _radioPlaysWhenEngineStartsProbability, value);
		}

		public audioVehicleMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

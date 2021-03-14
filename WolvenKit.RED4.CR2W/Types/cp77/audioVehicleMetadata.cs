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
			get
			{
				if (_generalData == null)
				{
					_generalData = (audioVehicleGeneralData) CR2WTypeManager.Create("audioVehicleGeneralData", "generalData", cr2w, this);
				}
				return _generalData;
			}
			set
			{
				if (_generalData == value)
				{
					return;
				}
				_generalData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mechanicalData")] 
		public audioVehicleMechanicalData MechanicalData
		{
			get
			{
				if (_mechanicalData == null)
				{
					_mechanicalData = (audioVehicleMechanicalData) CR2WTypeManager.Create("audioVehicleMechanicalData", "mechanicalData", cr2w, this);
				}
				return _mechanicalData;
			}
			set
			{
				if (_mechanicalData == value)
				{
					return;
				}
				_mechanicalData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wheelData")] 
		public audioVehicleWheelData WheelData
		{
			get
			{
				if (_wheelData == null)
				{
					_wheelData = (audioVehicleWheelData) CR2WTypeManager.Create("audioVehicleWheelData", "wheelData", cr2w, this);
				}
				return _wheelData;
			}
			set
			{
				if (_wheelData == value)
				{
					return;
				}
				_wheelData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emitterPositionData")] 
		public audioVehicleEmitterPositionData EmitterPositionData
		{
			get
			{
				if (_emitterPositionData == null)
				{
					_emitterPositionData = (audioVehicleEmitterPositionData) CR2WTypeManager.Create("audioVehicleEmitterPositionData", "emitterPositionData", cr2w, this);
				}
				return _emitterPositionData;
			}
			set
			{
				if (_emitterPositionData == value)
				{
					return;
				}
				_emitterPositionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("minRpm")] 
		public CFloat MinRpm
		{
			get
			{
				if (_minRpm == null)
				{
					_minRpm = (CFloat) CR2WTypeManager.Create("Float", "minRpm", cr2w, this);
				}
				return _minRpm;
			}
			set
			{
				if (_minRpm == value)
				{
					return;
				}
				_minRpm = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxRpm")] 
		public CFloat MaxRpm
		{
			get
			{
				if (_maxRpm == null)
				{
					_maxRpm = (CFloat) CR2WTypeManager.Create("Float", "maxRpm", cr2w, this);
				}
				return _maxRpm;
			}
			set
			{
				if (_maxRpm == value)
				{
					return;
				}
				_maxRpm = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vehicleCollisionSettings")] 
		public CName VehicleCollisionSettings
		{
			get
			{
				if (_vehicleCollisionSettings == null)
				{
					_vehicleCollisionSettings = (CName) CR2WTypeManager.Create("CName", "vehicleCollisionSettings", cr2w, this);
				}
				return _vehicleCollisionSettings;
			}
			set
			{
				if (_vehicleCollisionSettings == value)
				{
					return;
				}
				_vehicleCollisionSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vehicleGridDestructionSettings")] 
		public CName VehicleGridDestructionSettings
		{
			get
			{
				if (_vehicleGridDestructionSettings == null)
				{
					_vehicleGridDestructionSettings = (CName) CR2WTypeManager.Create("CName", "vehicleGridDestructionSettings", cr2w, this);
				}
				return _vehicleGridDestructionSettings;
			}
			set
			{
				if (_vehicleGridDestructionSettings == value)
				{
					return;
				}
				_vehicleGridDestructionSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vehiclePartSettings")] 
		public CName VehiclePartSettings
		{
			get
			{
				if (_vehiclePartSettings == null)
				{
					_vehiclePartSettings = (CName) CR2WTypeManager.Create("CName", "vehiclePartSettings", cr2w, this);
				}
				return _vehiclePartSettings;
			}
			set
			{
				if (_vehiclePartSettings == value)
				{
					return;
				}
				_vehiclePartSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("collisionCooldown")] 
		public CFloat CollisionCooldown
		{
			get
			{
				if (_collisionCooldown == null)
				{
					_collisionCooldown = (CFloat) CR2WTypeManager.Create("Float", "collisionCooldown", cr2w, this);
				}
				return _collisionCooldown;
			}
			set
			{
				if (_collisionCooldown == value)
				{
					return;
				}
				_collisionCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("maxPlayingDistance")] 
		public CFloat MaxPlayingDistance
		{
			get
			{
				if (_maxPlayingDistance == null)
				{
					_maxPlayingDistance = (CFloat) CR2WTypeManager.Create("Float", "maxPlayingDistance", cr2w, this);
				}
				return _maxPlayingDistance;
			}
			set
			{
				if (_maxPlayingDistance == value)
				{
					return;
				}
				_maxPlayingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get
			{
				if (_dopplerFactor == null)
				{
					_dopplerFactor = (CFloat) CR2WTypeManager.Create("Float", "dopplerFactor", cr2w, this);
				}
				return _dopplerFactor;
			}
			set
			{
				if (_dopplerFactor == value)
				{
					return;
				}
				_dopplerFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("suspensionSqueekTimeout")] 
		public CFloat SuspensionSqueekTimeout
		{
			get
			{
				if (_suspensionSqueekTimeout == null)
				{
					_suspensionSqueekTimeout = (CFloat) CR2WTypeManager.Create("Float", "suspensionSqueekTimeout", cr2w, this);
				}
				return _suspensionSqueekTimeout;
			}
			set
			{
				if (_suspensionSqueekTimeout == value)
				{
					return;
				}
				_suspensionSqueekTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("exitDelay")] 
		public CFloat ExitDelay
		{
			get
			{
				if (_exitDelay == null)
				{
					_exitDelay = (CFloat) CR2WTypeManager.Create("Float", "exitDelay", cr2w, this);
				}
				return _exitDelay;
			}
			set
			{
				if (_exitDelay == value)
				{
					return;
				}
				_exitDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("gearSweeteners")] 
		public CArray<CName> GearSweeteners
		{
			get
			{
				if (_gearSweeteners == null)
				{
					_gearSweeteners = (CArray<CName>) CR2WTypeManager.Create("array:CName", "gearSweeteners", cr2w, this);
				}
				return _gearSweeteners;
			}
			set
			{
				if (_gearSweeteners == value)
				{
					return;
				}
				_gearSweeteners = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("testWheelMaterial")] 
		public CBool TestWheelMaterial
		{
			get
			{
				if (_testWheelMaterial == null)
				{
					_testWheelMaterial = (CBool) CR2WTypeManager.Create("Bool", "testWheelMaterial", cr2w, this);
				}
				return _testWheelMaterial;
			}
			set
			{
				if (_testWheelMaterial == value)
				{
					return;
				}
				_testWheelMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hasRadioReceiver")] 
		public CBool HasRadioReceiver
		{
			get
			{
				if (_hasRadioReceiver == null)
				{
					_hasRadioReceiver = (CBool) CR2WTypeManager.Create("Bool", "hasRadioReceiver", cr2w, this);
				}
				return _hasRadioReceiver;
			}
			set
			{
				if (_hasRadioReceiver == value)
				{
					return;
				}
				_hasRadioReceiver = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("usesPoliceRadioStation")] 
		public CBool UsesPoliceRadioStation
		{
			get
			{
				if (_usesPoliceRadioStation == null)
				{
					_usesPoliceRadioStation = (CBool) CR2WTypeManager.Create("Bool", "usesPoliceRadioStation", cr2w, this);
				}
				return _usesPoliceRadioStation;
			}
			set
			{
				if (_usesPoliceRadioStation == value)
				{
					return;
				}
				_usesPoliceRadioStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get
			{
				if (_acousticIsolationFactor == null)
				{
					_acousticIsolationFactor = (CFloat) CR2WTypeManager.Create("Float", "acousticIsolationFactor", cr2w, this);
				}
				return _acousticIsolationFactor;
			}
			set
			{
				if (_acousticIsolationFactor == value)
				{
					return;
				}
				_acousticIsolationFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("trafficEmitterMetadata")] 
		public CName TrafficEmitterMetadata
		{
			get
			{
				if (_trafficEmitterMetadata == null)
				{
					_trafficEmitterMetadata = (CName) CR2WTypeManager.Create("CName", "trafficEmitterMetadata", cr2w, this);
				}
				return _trafficEmitterMetadata;
			}
			set
			{
				if (_trafficEmitterMetadata == value)
				{
					return;
				}
				_trafficEmitterMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("radioReceiverType")] 
		public CName RadioReceiverType
		{
			get
			{
				if (_radioReceiverType == null)
				{
					_radioReceiverType = (CName) CR2WTypeManager.Create("CName", "radioReceiverType", cr2w, this);
				}
				return _radioReceiverType;
			}
			set
			{
				if (_radioReceiverType == value)
				{
					return;
				}
				_radioReceiverType = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("matchingStartupRadioStations")] 
		public CArray<CName> MatchingStartupRadioStations
		{
			get
			{
				if (_matchingStartupRadioStations == null)
				{
					_matchingStartupRadioStations = (CArray<CName>) CR2WTypeManager.Create("array:CName", "matchingStartupRadioStations", cr2w, this);
				}
				return _matchingStartupRadioStations;
			}
			set
			{
				if (_matchingStartupRadioStations == value)
				{
					return;
				}
				_matchingStartupRadioStations = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("radioPlaysWhenEngineStartsProbability")] 
		public CFloat RadioPlaysWhenEngineStartsProbability
		{
			get
			{
				if (_radioPlaysWhenEngineStartsProbability == null)
				{
					_radioPlaysWhenEngineStartsProbability = (CFloat) CR2WTypeManager.Create("Float", "radioPlaysWhenEngineStartsProbability", cr2w, this);
				}
				return _radioPlaysWhenEngineStartsProbability;
			}
			set
			{
				if (_radioPlaysWhenEngineStartsProbability == value)
				{
					return;
				}
				_radioPlaysWhenEngineStartsProbability = value;
				PropertySet(this);
			}
		}

		public audioVehicleMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

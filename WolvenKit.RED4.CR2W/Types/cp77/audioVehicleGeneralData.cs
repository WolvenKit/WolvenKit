using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGeneralData : CVariable
	{
		private CName _revSoundbankName;
		private CName _revElectricSoundbankName;
		private CName _enterVehicleEvent;
		private CName _exitVehicleEvent;
		private CName _ignitionStartEvent;
		private CName _ignitionEndEvent;
		private CName _hornOnEvent;
		private CName _hornOffEvent;
		private CName _policeHornOnEvent;
		private CName _policeHornOffEvent;
		private CName _sirenOnEvent;
		private CName _sirenOffEvent;
		private CName _rainStartEvent;
		private CName _rainStopEvent;
		private CName _tyreBurstEvent;
		private CName _skid;
		private CName _inclination;
		private CName _impactVelocity;
		private CName _impactGridCellRawChange;
		private CName _collisionSoundEvent;
		private CName _interiorReverbBus;
		private CName _acoustingIsolationFactor;
		private CName _dopplerShift;
		private audioVehicleDoorsSettingsMetadata _vehicleDoorsSettings;
		private audioVehicleInteriorParameterData _vehicleInteriorParameterData;
		private audioVehicleTemperatureSettings _vehicleTemperatureSettings;

		[Ordinal(0)] 
		[RED("revSoundbankName")] 
		public CName RevSoundbankName
		{
			get
			{
				if (_revSoundbankName == null)
				{
					_revSoundbankName = (CName) CR2WTypeManager.Create("CName", "revSoundbankName", cr2w, this);
				}
				return _revSoundbankName;
			}
			set
			{
				if (_revSoundbankName == value)
				{
					return;
				}
				_revSoundbankName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("revElectricSoundbankName")] 
		public CName RevElectricSoundbankName
		{
			get
			{
				if (_revElectricSoundbankName == null)
				{
					_revElectricSoundbankName = (CName) CR2WTypeManager.Create("CName", "revElectricSoundbankName", cr2w, this);
				}
				return _revElectricSoundbankName;
			}
			set
			{
				if (_revElectricSoundbankName == value)
				{
					return;
				}
				_revElectricSoundbankName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enterVehicleEvent")] 
		public CName EnterVehicleEvent
		{
			get
			{
				if (_enterVehicleEvent == null)
				{
					_enterVehicleEvent = (CName) CR2WTypeManager.Create("CName", "enterVehicleEvent", cr2w, this);
				}
				return _enterVehicleEvent;
			}
			set
			{
				if (_enterVehicleEvent == value)
				{
					return;
				}
				_enterVehicleEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exitVehicleEvent")] 
		public CName ExitVehicleEvent
		{
			get
			{
				if (_exitVehicleEvent == null)
				{
					_exitVehicleEvent = (CName) CR2WTypeManager.Create("CName", "exitVehicleEvent", cr2w, this);
				}
				return _exitVehicleEvent;
			}
			set
			{
				if (_exitVehicleEvent == value)
				{
					return;
				}
				_exitVehicleEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ignitionStartEvent")] 
		public CName IgnitionStartEvent
		{
			get
			{
				if (_ignitionStartEvent == null)
				{
					_ignitionStartEvent = (CName) CR2WTypeManager.Create("CName", "ignitionStartEvent", cr2w, this);
				}
				return _ignitionStartEvent;
			}
			set
			{
				if (_ignitionStartEvent == value)
				{
					return;
				}
				_ignitionStartEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ignitionEndEvent")] 
		public CName IgnitionEndEvent
		{
			get
			{
				if (_ignitionEndEvent == null)
				{
					_ignitionEndEvent = (CName) CR2WTypeManager.Create("CName", "ignitionEndEvent", cr2w, this);
				}
				return _ignitionEndEvent;
			}
			set
			{
				if (_ignitionEndEvent == value)
				{
					return;
				}
				_ignitionEndEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hornOnEvent")] 
		public CName HornOnEvent
		{
			get
			{
				if (_hornOnEvent == null)
				{
					_hornOnEvent = (CName) CR2WTypeManager.Create("CName", "hornOnEvent", cr2w, this);
				}
				return _hornOnEvent;
			}
			set
			{
				if (_hornOnEvent == value)
				{
					return;
				}
				_hornOnEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hornOffEvent")] 
		public CName HornOffEvent
		{
			get
			{
				if (_hornOffEvent == null)
				{
					_hornOffEvent = (CName) CR2WTypeManager.Create("CName", "hornOffEvent", cr2w, this);
				}
				return _hornOffEvent;
			}
			set
			{
				if (_hornOffEvent == value)
				{
					return;
				}
				_hornOffEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("policeHornOnEvent")] 
		public CName PoliceHornOnEvent
		{
			get
			{
				if (_policeHornOnEvent == null)
				{
					_policeHornOnEvent = (CName) CR2WTypeManager.Create("CName", "policeHornOnEvent", cr2w, this);
				}
				return _policeHornOnEvent;
			}
			set
			{
				if (_policeHornOnEvent == value)
				{
					return;
				}
				_policeHornOnEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("policeHornOffEvent")] 
		public CName PoliceHornOffEvent
		{
			get
			{
				if (_policeHornOffEvent == null)
				{
					_policeHornOffEvent = (CName) CR2WTypeManager.Create("CName", "policeHornOffEvent", cr2w, this);
				}
				return _policeHornOffEvent;
			}
			set
			{
				if (_policeHornOffEvent == value)
				{
					return;
				}
				_policeHornOffEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sirenOnEvent")] 
		public CName SirenOnEvent
		{
			get
			{
				if (_sirenOnEvent == null)
				{
					_sirenOnEvent = (CName) CR2WTypeManager.Create("CName", "sirenOnEvent", cr2w, this);
				}
				return _sirenOnEvent;
			}
			set
			{
				if (_sirenOnEvent == value)
				{
					return;
				}
				_sirenOnEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("sirenOffEvent")] 
		public CName SirenOffEvent
		{
			get
			{
				if (_sirenOffEvent == null)
				{
					_sirenOffEvent = (CName) CR2WTypeManager.Create("CName", "sirenOffEvent", cr2w, this);
				}
				return _sirenOffEvent;
			}
			set
			{
				if (_sirenOffEvent == value)
				{
					return;
				}
				_sirenOffEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rainStartEvent")] 
		public CName RainStartEvent
		{
			get
			{
				if (_rainStartEvent == null)
				{
					_rainStartEvent = (CName) CR2WTypeManager.Create("CName", "rainStartEvent", cr2w, this);
				}
				return _rainStartEvent;
			}
			set
			{
				if (_rainStartEvent == value)
				{
					return;
				}
				_rainStartEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rainStopEvent")] 
		public CName RainStopEvent
		{
			get
			{
				if (_rainStopEvent == null)
				{
					_rainStopEvent = (CName) CR2WTypeManager.Create("CName", "rainStopEvent", cr2w, this);
				}
				return _rainStopEvent;
			}
			set
			{
				if (_rainStopEvent == value)
				{
					return;
				}
				_rainStopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tyreBurstEvent")] 
		public CName TyreBurstEvent
		{
			get
			{
				if (_tyreBurstEvent == null)
				{
					_tyreBurstEvent = (CName) CR2WTypeManager.Create("CName", "tyreBurstEvent", cr2w, this);
				}
				return _tyreBurstEvent;
			}
			set
			{
				if (_tyreBurstEvent == value)
				{
					return;
				}
				_tyreBurstEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("skid")] 
		public CName Skid
		{
			get
			{
				if (_skid == null)
				{
					_skid = (CName) CR2WTypeManager.Create("CName", "skid", cr2w, this);
				}
				return _skid;
			}
			set
			{
				if (_skid == value)
				{
					return;
				}
				_skid = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("inclination")] 
		public CName Inclination
		{
			get
			{
				if (_inclination == null)
				{
					_inclination = (CName) CR2WTypeManager.Create("CName", "inclination", cr2w, this);
				}
				return _inclination;
			}
			set
			{
				if (_inclination == value)
				{
					return;
				}
				_inclination = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("impactVelocity")] 
		public CName ImpactVelocity
		{
			get
			{
				if (_impactVelocity == null)
				{
					_impactVelocity = (CName) CR2WTypeManager.Create("CName", "impactVelocity", cr2w, this);
				}
				return _impactVelocity;
			}
			set
			{
				if (_impactVelocity == value)
				{
					return;
				}
				_impactVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("impactGridCellRawChange")] 
		public CName ImpactGridCellRawChange
		{
			get
			{
				if (_impactGridCellRawChange == null)
				{
					_impactGridCellRawChange = (CName) CR2WTypeManager.Create("CName", "impactGridCellRawChange", cr2w, this);
				}
				return _impactGridCellRawChange;
			}
			set
			{
				if (_impactGridCellRawChange == value)
				{
					return;
				}
				_impactGridCellRawChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("collisionSoundEvent")] 
		public CName CollisionSoundEvent
		{
			get
			{
				if (_collisionSoundEvent == null)
				{
					_collisionSoundEvent = (CName) CR2WTypeManager.Create("CName", "collisionSoundEvent", cr2w, this);
				}
				return _collisionSoundEvent;
			}
			set
			{
				if (_collisionSoundEvent == value)
				{
					return;
				}
				_collisionSoundEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("interiorReverbBus")] 
		public CName InteriorReverbBus
		{
			get
			{
				if (_interiorReverbBus == null)
				{
					_interiorReverbBus = (CName) CR2WTypeManager.Create("CName", "interiorReverbBus", cr2w, this);
				}
				return _interiorReverbBus;
			}
			set
			{
				if (_interiorReverbBus == value)
				{
					return;
				}
				_interiorReverbBus = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("acoustingIsolationFactor")] 
		public CName AcoustingIsolationFactor
		{
			get
			{
				if (_acoustingIsolationFactor == null)
				{
					_acoustingIsolationFactor = (CName) CR2WTypeManager.Create("CName", "acoustingIsolationFactor", cr2w, this);
				}
				return _acoustingIsolationFactor;
			}
			set
			{
				if (_acoustingIsolationFactor == value)
				{
					return;
				}
				_acoustingIsolationFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("dopplerShift")] 
		public CName DopplerShift
		{
			get
			{
				if (_dopplerShift == null)
				{
					_dopplerShift = (CName) CR2WTypeManager.Create("CName", "dopplerShift", cr2w, this);
				}
				return _dopplerShift;
			}
			set
			{
				if (_dopplerShift == value)
				{
					return;
				}
				_dopplerShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("vehicleDoorsSettings")] 
		public audioVehicleDoorsSettingsMetadata VehicleDoorsSettings
		{
			get
			{
				if (_vehicleDoorsSettings == null)
				{
					_vehicleDoorsSettings = (audioVehicleDoorsSettingsMetadata) CR2WTypeManager.Create("audioVehicleDoorsSettingsMetadata", "vehicleDoorsSettings", cr2w, this);
				}
				return _vehicleDoorsSettings;
			}
			set
			{
				if (_vehicleDoorsSettings == value)
				{
					return;
				}
				_vehicleDoorsSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("vehicleInteriorParameterData")] 
		public audioVehicleInteriorParameterData VehicleInteriorParameterData
		{
			get
			{
				if (_vehicleInteriorParameterData == null)
				{
					_vehicleInteriorParameterData = (audioVehicleInteriorParameterData) CR2WTypeManager.Create("audioVehicleInteriorParameterData", "vehicleInteriorParameterData", cr2w, this);
				}
				return _vehicleInteriorParameterData;
			}
			set
			{
				if (_vehicleInteriorParameterData == value)
				{
					return;
				}
				_vehicleInteriorParameterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("vehicleTemperatureSettings")] 
		public audioVehicleTemperatureSettings VehicleTemperatureSettings
		{
			get
			{
				if (_vehicleTemperatureSettings == null)
				{
					_vehicleTemperatureSettings = (audioVehicleTemperatureSettings) CR2WTypeManager.Create("audioVehicleTemperatureSettings", "vehicleTemperatureSettings", cr2w, this);
				}
				return _vehicleTemperatureSettings;
			}
			set
			{
				if (_vehicleTemperatureSettings == value)
				{
					return;
				}
				_vehicleTemperatureSettings = value;
				PropertySet(this);
			}
		}

		public audioVehicleGeneralData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

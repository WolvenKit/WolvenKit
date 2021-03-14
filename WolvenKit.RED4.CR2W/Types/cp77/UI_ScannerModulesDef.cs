using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ScannerModulesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _scannerName;
		private gamebbScriptID_Variant _scannerHealth;
		private gamebbScriptID_Variant _scannerLevel;
		private gamebbScriptID_Variant _scannerAuthorization;
		private gamebbScriptID_Variant _scannerRarity;
		private gamebbScriptID_Variant _scannerArchetype;
		private gamebbScriptID_Variant _scannerFaction;
		private gamebbScriptID_Variant _scannerWeaponBasic;
		private gamebbScriptID_Variant _scannerWeaponDetailed;
		private gamebbScriptID_Variant _scannerVulnerabilities;
		private gamebbScriptID_Variant _scannerSquadInfo;
		private gamebbScriptID_Variant _scannerResistances;
		private gamebbScriptID_Variant _scannerAbilities;
		private gamebbScriptID_Variant _scannerAttitude;
		private gamebbScriptID_Variant _scannerBountySystem;
		private gamebbScriptID_Variant _scannerDeviceStatus;
		private gamebbScriptID_Variant _scannerNetworkLevel;
		private gamebbScriptID_Variant _scannerNetworkStatus;
		private gamebbScriptID_Variant _scannerConnections;
		private gamebbScriptID_Variant _scannerDescription;
		private gamebbScriptID_Variant _scannerSkillChecks;
		private gamebbScriptID_Variant _scannerVehicleName;
		private gamebbScriptID_Variant _scannerVehicleManufacturer;
		private gamebbScriptID_Variant _scannerVehicleProductionYears;
		private gamebbScriptID_Variant _scannerVehicleDriveLayout;
		private gamebbScriptID_Variant _scannerVehicleHorsepower;
		private gamebbScriptID_Variant _scannerVehicleMass;
		private gamebbScriptID_Variant _scannerVehicleState;
		private gamebbScriptID_Variant _scannerVehicleInfo;
		private gamebbScriptID_Variant _scannerQuickHackDescription;
		private gamebbScriptID_Int32 _objectType;

		[Ordinal(0)] 
		[RED("ScannerName")] 
		public gamebbScriptID_Variant ScannerName
		{
			get
			{
				if (_scannerName == null)
				{
					_scannerName = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerName", cr2w, this);
				}
				return _scannerName;
			}
			set
			{
				if (_scannerName == value)
				{
					return;
				}
				_scannerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ScannerHealth")] 
		public gamebbScriptID_Variant ScannerHealth
		{
			get
			{
				if (_scannerHealth == null)
				{
					_scannerHealth = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerHealth", cr2w, this);
				}
				return _scannerHealth;
			}
			set
			{
				if (_scannerHealth == value)
				{
					return;
				}
				_scannerHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ScannerLevel")] 
		public gamebbScriptID_Variant ScannerLevel
		{
			get
			{
				if (_scannerLevel == null)
				{
					_scannerLevel = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerLevel", cr2w, this);
				}
				return _scannerLevel;
			}
			set
			{
				if (_scannerLevel == value)
				{
					return;
				}
				_scannerLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ScannerAuthorization")] 
		public gamebbScriptID_Variant ScannerAuthorization
		{
			get
			{
				if (_scannerAuthorization == null)
				{
					_scannerAuthorization = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerAuthorization", cr2w, this);
				}
				return _scannerAuthorization;
			}
			set
			{
				if (_scannerAuthorization == value)
				{
					return;
				}
				_scannerAuthorization = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ScannerRarity")] 
		public gamebbScriptID_Variant ScannerRarity
		{
			get
			{
				if (_scannerRarity == null)
				{
					_scannerRarity = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerRarity", cr2w, this);
				}
				return _scannerRarity;
			}
			set
			{
				if (_scannerRarity == value)
				{
					return;
				}
				_scannerRarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ScannerArchetype")] 
		public gamebbScriptID_Variant ScannerArchetype
		{
			get
			{
				if (_scannerArchetype == null)
				{
					_scannerArchetype = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerArchetype", cr2w, this);
				}
				return _scannerArchetype;
			}
			set
			{
				if (_scannerArchetype == value)
				{
					return;
				}
				_scannerArchetype = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ScannerFaction")] 
		public gamebbScriptID_Variant ScannerFaction
		{
			get
			{
				if (_scannerFaction == null)
				{
					_scannerFaction = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerFaction", cr2w, this);
				}
				return _scannerFaction;
			}
			set
			{
				if (_scannerFaction == value)
				{
					return;
				}
				_scannerFaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ScannerWeaponBasic")] 
		public gamebbScriptID_Variant ScannerWeaponBasic
		{
			get
			{
				if (_scannerWeaponBasic == null)
				{
					_scannerWeaponBasic = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerWeaponBasic", cr2w, this);
				}
				return _scannerWeaponBasic;
			}
			set
			{
				if (_scannerWeaponBasic == value)
				{
					return;
				}
				_scannerWeaponBasic = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ScannerWeaponDetailed")] 
		public gamebbScriptID_Variant ScannerWeaponDetailed
		{
			get
			{
				if (_scannerWeaponDetailed == null)
				{
					_scannerWeaponDetailed = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerWeaponDetailed", cr2w, this);
				}
				return _scannerWeaponDetailed;
			}
			set
			{
				if (_scannerWeaponDetailed == value)
				{
					return;
				}
				_scannerWeaponDetailed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ScannerVulnerabilities")] 
		public gamebbScriptID_Variant ScannerVulnerabilities
		{
			get
			{
				if (_scannerVulnerabilities == null)
				{
					_scannerVulnerabilities = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVulnerabilities", cr2w, this);
				}
				return _scannerVulnerabilities;
			}
			set
			{
				if (_scannerVulnerabilities == value)
				{
					return;
				}
				_scannerVulnerabilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ScannerSquadInfo")] 
		public gamebbScriptID_Variant ScannerSquadInfo
		{
			get
			{
				if (_scannerSquadInfo == null)
				{
					_scannerSquadInfo = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerSquadInfo", cr2w, this);
				}
				return _scannerSquadInfo;
			}
			set
			{
				if (_scannerSquadInfo == value)
				{
					return;
				}
				_scannerSquadInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ScannerResistances")] 
		public gamebbScriptID_Variant ScannerResistances
		{
			get
			{
				if (_scannerResistances == null)
				{
					_scannerResistances = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerResistances", cr2w, this);
				}
				return _scannerResistances;
			}
			set
			{
				if (_scannerResistances == value)
				{
					return;
				}
				_scannerResistances = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ScannerAbilities")] 
		public gamebbScriptID_Variant ScannerAbilities
		{
			get
			{
				if (_scannerAbilities == null)
				{
					_scannerAbilities = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerAbilities", cr2w, this);
				}
				return _scannerAbilities;
			}
			set
			{
				if (_scannerAbilities == value)
				{
					return;
				}
				_scannerAbilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ScannerAttitude")] 
		public gamebbScriptID_Variant ScannerAttitude
		{
			get
			{
				if (_scannerAttitude == null)
				{
					_scannerAttitude = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerAttitude", cr2w, this);
				}
				return _scannerAttitude;
			}
			set
			{
				if (_scannerAttitude == value)
				{
					return;
				}
				_scannerAttitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ScannerBountySystem")] 
		public gamebbScriptID_Variant ScannerBountySystem
		{
			get
			{
				if (_scannerBountySystem == null)
				{
					_scannerBountySystem = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerBountySystem", cr2w, this);
				}
				return _scannerBountySystem;
			}
			set
			{
				if (_scannerBountySystem == value)
				{
					return;
				}
				_scannerBountySystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("ScannerDeviceStatus")] 
		public gamebbScriptID_Variant ScannerDeviceStatus
		{
			get
			{
				if (_scannerDeviceStatus == null)
				{
					_scannerDeviceStatus = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerDeviceStatus", cr2w, this);
				}
				return _scannerDeviceStatus;
			}
			set
			{
				if (_scannerDeviceStatus == value)
				{
					return;
				}
				_scannerDeviceStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ScannerNetworkLevel")] 
		public gamebbScriptID_Variant ScannerNetworkLevel
		{
			get
			{
				if (_scannerNetworkLevel == null)
				{
					_scannerNetworkLevel = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerNetworkLevel", cr2w, this);
				}
				return _scannerNetworkLevel;
			}
			set
			{
				if (_scannerNetworkLevel == value)
				{
					return;
				}
				_scannerNetworkLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ScannerNetworkStatus")] 
		public gamebbScriptID_Variant ScannerNetworkStatus
		{
			get
			{
				if (_scannerNetworkStatus == null)
				{
					_scannerNetworkStatus = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerNetworkStatus", cr2w, this);
				}
				return _scannerNetworkStatus;
			}
			set
			{
				if (_scannerNetworkStatus == value)
				{
					return;
				}
				_scannerNetworkStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ScannerConnections")] 
		public gamebbScriptID_Variant ScannerConnections
		{
			get
			{
				if (_scannerConnections == null)
				{
					_scannerConnections = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerConnections", cr2w, this);
				}
				return _scannerConnections;
			}
			set
			{
				if (_scannerConnections == value)
				{
					return;
				}
				_scannerConnections = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ScannerDescription")] 
		public gamebbScriptID_Variant ScannerDescription
		{
			get
			{
				if (_scannerDescription == null)
				{
					_scannerDescription = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerDescription", cr2w, this);
				}
				return _scannerDescription;
			}
			set
			{
				if (_scannerDescription == value)
				{
					return;
				}
				_scannerDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ScannerSkillChecks")] 
		public gamebbScriptID_Variant ScannerSkillChecks
		{
			get
			{
				if (_scannerSkillChecks == null)
				{
					_scannerSkillChecks = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerSkillChecks", cr2w, this);
				}
				return _scannerSkillChecks;
			}
			set
			{
				if (_scannerSkillChecks == value)
				{
					return;
				}
				_scannerSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ScannerVehicleName")] 
		public gamebbScriptID_Variant ScannerVehicleName
		{
			get
			{
				if (_scannerVehicleName == null)
				{
					_scannerVehicleName = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleName", cr2w, this);
				}
				return _scannerVehicleName;
			}
			set
			{
				if (_scannerVehicleName == value)
				{
					return;
				}
				_scannerVehicleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("ScannerVehicleManufacturer")] 
		public gamebbScriptID_Variant ScannerVehicleManufacturer
		{
			get
			{
				if (_scannerVehicleManufacturer == null)
				{
					_scannerVehicleManufacturer = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleManufacturer", cr2w, this);
				}
				return _scannerVehicleManufacturer;
			}
			set
			{
				if (_scannerVehicleManufacturer == value)
				{
					return;
				}
				_scannerVehicleManufacturer = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("ScannerVehicleProductionYears")] 
		public gamebbScriptID_Variant ScannerVehicleProductionYears
		{
			get
			{
				if (_scannerVehicleProductionYears == null)
				{
					_scannerVehicleProductionYears = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleProductionYears", cr2w, this);
				}
				return _scannerVehicleProductionYears;
			}
			set
			{
				if (_scannerVehicleProductionYears == value)
				{
					return;
				}
				_scannerVehicleProductionYears = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("ScannerVehicleDriveLayout")] 
		public gamebbScriptID_Variant ScannerVehicleDriveLayout
		{
			get
			{
				if (_scannerVehicleDriveLayout == null)
				{
					_scannerVehicleDriveLayout = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleDriveLayout", cr2w, this);
				}
				return _scannerVehicleDriveLayout;
			}
			set
			{
				if (_scannerVehicleDriveLayout == value)
				{
					return;
				}
				_scannerVehicleDriveLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("ScannerVehicleHorsepower")] 
		public gamebbScriptID_Variant ScannerVehicleHorsepower
		{
			get
			{
				if (_scannerVehicleHorsepower == null)
				{
					_scannerVehicleHorsepower = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleHorsepower", cr2w, this);
				}
				return _scannerVehicleHorsepower;
			}
			set
			{
				if (_scannerVehicleHorsepower == value)
				{
					return;
				}
				_scannerVehicleHorsepower = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("ScannerVehicleMass")] 
		public gamebbScriptID_Variant ScannerVehicleMass
		{
			get
			{
				if (_scannerVehicleMass == null)
				{
					_scannerVehicleMass = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleMass", cr2w, this);
				}
				return _scannerVehicleMass;
			}
			set
			{
				if (_scannerVehicleMass == value)
				{
					return;
				}
				_scannerVehicleMass = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("ScannerVehicleState")] 
		public gamebbScriptID_Variant ScannerVehicleState
		{
			get
			{
				if (_scannerVehicleState == null)
				{
					_scannerVehicleState = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleState", cr2w, this);
				}
				return _scannerVehicleState;
			}
			set
			{
				if (_scannerVehicleState == value)
				{
					return;
				}
				_scannerVehicleState = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("ScannerVehicleInfo")] 
		public gamebbScriptID_Variant ScannerVehicleInfo
		{
			get
			{
				if (_scannerVehicleInfo == null)
				{
					_scannerVehicleInfo = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerVehicleInfo", cr2w, this);
				}
				return _scannerVehicleInfo;
			}
			set
			{
				if (_scannerVehicleInfo == value)
				{
					return;
				}
				_scannerVehicleInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("ScannerQuickHackDescription")] 
		public gamebbScriptID_Variant ScannerQuickHackDescription
		{
			get
			{
				if (_scannerQuickHackDescription == null)
				{
					_scannerQuickHackDescription = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ScannerQuickHackDescription", cr2w, this);
				}
				return _scannerQuickHackDescription;
			}
			set
			{
				if (_scannerQuickHackDescription == value)
				{
					return;
				}
				_scannerQuickHackDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ObjectType")] 
		public gamebbScriptID_Int32 ObjectType
		{
			get
			{
				if (_objectType == null)
				{
					_objectType = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ObjectType", cr2w, this);
				}
				return _objectType;
			}
			set
			{
				if (_objectType == value)
				{
					return;
				}
				_objectType = value;
				PropertySet(this);
			}
		}

		public UI_ScannerModulesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

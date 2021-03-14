using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonWidgetGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _vehicleNameLabel;
		private inkImageWidgetReference _vehicleTypeIcon;
		private inkImageWidgetReference _vehicleManufactorIcon;
		private inkTextWidgetReference _distanceLabel;
		private inkTextWidgetReference _isWaiting;
		private CEnum<EMeasurementUnit> _unit;
		private inkTextWidgetReference _unitText;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _animationCounterProxy;
		private inkanimPlaybackOptions _optionIntro;
		private inkanimPlaybackOptions _optionCounter;
		private CHandle<VehicleSummonDataDef> _vehicleSummonDataDef;
		private CHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CUInt32 _vehicleSummonStateCallback;
		private CUInt32 _vehicleSummonState;
		private Vector4 _vehiclePos;
		private Vector4 _playerPos;
		private Vector4 _distanceVector;
		private ScriptGameInstance _gameInstance;
		private CInt32 _distance;
		private entEntityID _vehicleID;
		private wCHandle<entEntity> _vehicleEntity;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CHandle<gamedataVehicle_Record> _vehicleRecord;
		private CHandle<textTextParameterSet> _textParams;
		private CHandle<gamedataUIIcon_Record> _iconRecord;

		[Ordinal(9)] 
		[RED("vehicleNameLabel")] 
		public inkTextWidgetReference VehicleNameLabel
		{
			get
			{
				if (_vehicleNameLabel == null)
				{
					_vehicleNameLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleNameLabel", cr2w, this);
				}
				return _vehicleNameLabel;
			}
			set
			{
				if (_vehicleNameLabel == value)
				{
					return;
				}
				_vehicleNameLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vehicleTypeIcon")] 
		public inkImageWidgetReference VehicleTypeIcon
		{
			get
			{
				if (_vehicleTypeIcon == null)
				{
					_vehicleTypeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "vehicleTypeIcon", cr2w, this);
				}
				return _vehicleTypeIcon;
			}
			set
			{
				if (_vehicleTypeIcon == value)
				{
					return;
				}
				_vehicleTypeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("vehicleManufactorIcon")] 
		public inkImageWidgetReference VehicleManufactorIcon
		{
			get
			{
				if (_vehicleManufactorIcon == null)
				{
					_vehicleManufactorIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "vehicleManufactorIcon", cr2w, this);
				}
				return _vehicleManufactorIcon;
			}
			set
			{
				if (_vehicleManufactorIcon == value)
				{
					return;
				}
				_vehicleManufactorIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("distanceLabel")] 
		public inkTextWidgetReference DistanceLabel
		{
			get
			{
				if (_distanceLabel == null)
				{
					_distanceLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "distanceLabel", cr2w, this);
				}
				return _distanceLabel;
			}
			set
			{
				if (_distanceLabel == value)
				{
					return;
				}
				_distanceLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isWaiting")] 
		public inkTextWidgetReference IsWaiting
		{
			get
			{
				if (_isWaiting == null)
				{
					_isWaiting = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "isWaiting", cr2w, this);
				}
				return _isWaiting;
			}
			set
			{
				if (_isWaiting == value)
				{
					return;
				}
				_isWaiting = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("unit")] 
		public CEnum<EMeasurementUnit> Unit
		{
			get
			{
				if (_unit == null)
				{
					_unit = (CEnum<EMeasurementUnit>) CR2WTypeManager.Create("EMeasurementUnit", "unit", cr2w, this);
				}
				return _unit;
			}
			set
			{
				if (_unit == value)
				{
					return;
				}
				_unit = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("unitText")] 
		public inkTextWidgetReference UnitText
		{
			get
			{
				if (_unitText == null)
				{
					_unitText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "unitText", cr2w, this);
				}
				return _unitText;
			}
			set
			{
				if (_unitText == value)
				{
					return;
				}
				_unitText = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animationCounterProxy")] 
		public CHandle<inkanimProxy> AnimationCounterProxy
		{
			get
			{
				if (_animationCounterProxy == null)
				{
					_animationCounterProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationCounterProxy", cr2w, this);
				}
				return _animationCounterProxy;
			}
			set
			{
				if (_animationCounterProxy == value)
				{
					return;
				}
				_animationCounterProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("optionIntro")] 
		public inkanimPlaybackOptions OptionIntro
		{
			get
			{
				if (_optionIntro == null)
				{
					_optionIntro = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "optionIntro", cr2w, this);
				}
				return _optionIntro;
			}
			set
			{
				if (_optionIntro == value)
				{
					return;
				}
				_optionIntro = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("optionCounter")] 
		public inkanimPlaybackOptions OptionCounter
		{
			get
			{
				if (_optionCounter == null)
				{
					_optionCounter = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "optionCounter", cr2w, this);
				}
				return _optionCounter;
			}
			set
			{
				if (_optionCounter == value)
				{
					return;
				}
				_optionCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get
			{
				if (_vehicleSummonDataDef == null)
				{
					_vehicleSummonDataDef = (CHandle<VehicleSummonDataDef>) CR2WTypeManager.Create("handle:VehicleSummonDataDef", "vehicleSummonDataDef", cr2w, this);
				}
				return _vehicleSummonDataDef;
			}
			set
			{
				if (_vehicleSummonDataDef == value)
				{
					return;
				}
				_vehicleSummonDataDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("vehicleSummonDataBB")] 
		public CHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get
			{
				if (_vehicleSummonDataBB == null)
				{
					_vehicleSummonDataBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "vehicleSummonDataBB", cr2w, this);
				}
				return _vehicleSummonDataBB;
			}
			set
			{
				if (_vehicleSummonDataBB == value)
				{
					return;
				}
				_vehicleSummonDataBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("vehicleSummonStateCallback")] 
		public CUInt32 VehicleSummonStateCallback
		{
			get
			{
				if (_vehicleSummonStateCallback == null)
				{
					_vehicleSummonStateCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleSummonStateCallback", cr2w, this);
				}
				return _vehicleSummonStateCallback;
			}
			set
			{
				if (_vehicleSummonStateCallback == value)
				{
					return;
				}
				_vehicleSummonStateCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("vehicleSummonState")] 
		public CUInt32 VehicleSummonState
		{
			get
			{
				if (_vehicleSummonState == null)
				{
					_vehicleSummonState = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleSummonState", cr2w, this);
				}
				return _vehicleSummonState;
			}
			set
			{
				if (_vehicleSummonState == value)
				{
					return;
				}
				_vehicleSummonState = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("vehiclePos")] 
		public Vector4 VehiclePos
		{
			get
			{
				if (_vehiclePos == null)
				{
					_vehiclePos = (Vector4) CR2WTypeManager.Create("Vector4", "vehiclePos", cr2w, this);
				}
				return _vehiclePos;
			}
			set
			{
				if (_vehiclePos == value)
				{
					return;
				}
				_vehiclePos = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("playerPos")] 
		public Vector4 PlayerPos
		{
			get
			{
				if (_playerPos == null)
				{
					_playerPos = (Vector4) CR2WTypeManager.Create("Vector4", "playerPos", cr2w, this);
				}
				return _playerPos;
			}
			set
			{
				if (_playerPos == value)
				{
					return;
				}
				_playerPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get
			{
				if (_distanceVector == null)
				{
					_distanceVector = (Vector4) CR2WTypeManager.Create("Vector4", "distanceVector", cr2w, this);
				}
				return _distanceVector;
			}
			set
			{
				if (_distanceVector == value)
				{
					return;
				}
				_distanceVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("distance")] 
		public CInt32 Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CInt32) CR2WTypeManager.Create("Int32", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("vehicleID")] 
		public entEntityID VehicleID
		{
			get
			{
				if (_vehicleID == null)
				{
					_vehicleID = (entEntityID) CR2WTypeManager.Create("entEntityID", "vehicleID", cr2w, this);
				}
				return _vehicleID;
			}
			set
			{
				if (_vehicleID == value)
				{
					return;
				}
				_vehicleID = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("vehicleEntity")] 
		public wCHandle<entEntity> VehicleEntity
		{
			get
			{
				if (_vehicleEntity == null)
				{
					_vehicleEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "vehicleEntity", cr2w, this);
				}
				return _vehicleEntity;
			}
			set
			{
				if (_vehicleEntity == value)
				{
					return;
				}
				_vehicleEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get
			{
				if (_vehicleRecord == null)
				{
					_vehicleRecord = (CHandle<gamedataVehicle_Record>) CR2WTypeManager.Create("handle:gamedataVehicle_Record", "vehicleRecord", cr2w, this);
				}
				return _vehicleRecord;
			}
			set
			{
				if (_vehicleRecord == value)
				{
					return;
				}
				_vehicleRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get
			{
				if (_textParams == null)
				{
					_textParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "textParams", cr2w, this);
				}
				return _textParams;
			}
			set
			{
				if (_textParams == value)
				{
					return;
				}
				_textParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("iconRecord")] 
		public CHandle<gamedataUIIcon_Record> IconRecord
		{
			get
			{
				if (_iconRecord == null)
				{
					_iconRecord = (CHandle<gamedataUIIcon_Record>) CR2WTypeManager.Create("handle:gamedataUIIcon_Record", "iconRecord", cr2w, this);
				}
				return _iconRecord;
			}
			set
			{
				if (_iconRecord == value)
				{
					return;
				}
				_iconRecord = value;
				PropertySet(this);
			}
		}

		public VehicleSummonWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

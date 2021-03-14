using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Float _bikeTilt;
		private gamebbScriptID_Float _speedValue;
		private gamebbScriptID_Int32 _gearValue;
		private gamebbScriptID_Float _rPMValue;
		private gamebbScriptID_Float _rPMMax;
		private gamebbScriptID_Float _suspensionTransversalForce;
		private gamebbScriptID_Float _suspensionLongitudinalForce;
		private gamebbScriptID_Bool _isAutopilotOn;
		private gamebbScriptID_Float _declutchTimer;
		private gamebbScriptID_Float _handlingPenalty;
		private gamebbScriptID_Int32 _lightMode;
		private gamebbScriptID_Int32 _vehicleState;
		private gamebbScriptID_Bool _vehicleReady;
		private gamebbScriptID_Bool _vehRadioState;
		private gamebbScriptID_CName _vehRadioStationName;
		private gamebbScriptID_Bool _isCrowd;
		private gamebbScriptID_Bool _isUIActive;
		private gamebbScriptID_String _gameTime;
		private gamebbScriptID_Bool _collision;
		private gamebbScriptID_Int32 _damageState;
		private gamebbScriptID_Float _meanSlipRatio;
		private gamebbScriptID_Int32 _isHandbraking;
		private gamebbScriptID_Float _engineTemp;
		private gamebbScriptID_Bool _isInWater;
		private gamebbScriptID_String _raceTimer;
		private gamebbScriptID_Bool _isTargetingFriendly;

		[Ordinal(0)] 
		[RED("BikeTilt")] 
		public gamebbScriptID_Float BikeTilt
		{
			get
			{
				if (_bikeTilt == null)
				{
					_bikeTilt = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "BikeTilt", cr2w, this);
				}
				return _bikeTilt;
			}
			set
			{
				if (_bikeTilt == value)
				{
					return;
				}
				_bikeTilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("SpeedValue")] 
		public gamebbScriptID_Float SpeedValue
		{
			get
			{
				if (_speedValue == null)
				{
					_speedValue = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "SpeedValue", cr2w, this);
				}
				return _speedValue;
			}
			set
			{
				if (_speedValue == value)
				{
					return;
				}
				_speedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("GearValue")] 
		public gamebbScriptID_Int32 GearValue
		{
			get
			{
				if (_gearValue == null)
				{
					_gearValue = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "GearValue", cr2w, this);
				}
				return _gearValue;
			}
			set
			{
				if (_gearValue == value)
				{
					return;
				}
				_gearValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("RPMValue")] 
		public gamebbScriptID_Float RPMValue
		{
			get
			{
				if (_rPMValue == null)
				{
					_rPMValue = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "RPMValue", cr2w, this);
				}
				return _rPMValue;
			}
			set
			{
				if (_rPMValue == value)
				{
					return;
				}
				_rPMValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("RPMMax")] 
		public gamebbScriptID_Float RPMMax
		{
			get
			{
				if (_rPMMax == null)
				{
					_rPMMax = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "RPMMax", cr2w, this);
				}
				return _rPMMax;
			}
			set
			{
				if (_rPMMax == value)
				{
					return;
				}
				_rPMMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("SuspensionTransversalForce")] 
		public gamebbScriptID_Float SuspensionTransversalForce
		{
			get
			{
				if (_suspensionTransversalForce == null)
				{
					_suspensionTransversalForce = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "SuspensionTransversalForce", cr2w, this);
				}
				return _suspensionTransversalForce;
			}
			set
			{
				if (_suspensionTransversalForce == value)
				{
					return;
				}
				_suspensionTransversalForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("SuspensionLongitudinalForce")] 
		public gamebbScriptID_Float SuspensionLongitudinalForce
		{
			get
			{
				if (_suspensionLongitudinalForce == null)
				{
					_suspensionLongitudinalForce = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "SuspensionLongitudinalForce", cr2w, this);
				}
				return _suspensionLongitudinalForce;
			}
			set
			{
				if (_suspensionLongitudinalForce == value)
				{
					return;
				}
				_suspensionLongitudinalForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsAutopilotOn")] 
		public gamebbScriptID_Bool IsAutopilotOn
		{
			get
			{
				if (_isAutopilotOn == null)
				{
					_isAutopilotOn = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsAutopilotOn", cr2w, this);
				}
				return _isAutopilotOn;
			}
			set
			{
				if (_isAutopilotOn == value)
				{
					return;
				}
				_isAutopilotOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("DeclutchTimer")] 
		public gamebbScriptID_Float DeclutchTimer
		{
			get
			{
				if (_declutchTimer == null)
				{
					_declutchTimer = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "DeclutchTimer", cr2w, this);
				}
				return _declutchTimer;
			}
			set
			{
				if (_declutchTimer == value)
				{
					return;
				}
				_declutchTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("HandlingPenalty")] 
		public gamebbScriptID_Float HandlingPenalty
		{
			get
			{
				if (_handlingPenalty == null)
				{
					_handlingPenalty = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "HandlingPenalty", cr2w, this);
				}
				return _handlingPenalty;
			}
			set
			{
				if (_handlingPenalty == value)
				{
					return;
				}
				_handlingPenalty = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("LightMode")] 
		public gamebbScriptID_Int32 LightMode
		{
			get
			{
				if (_lightMode == null)
				{
					_lightMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "LightMode", cr2w, this);
				}
				return _lightMode;
			}
			set
			{
				if (_lightMode == value)
				{
					return;
				}
				_lightMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("VehicleState")] 
		public gamebbScriptID_Int32 VehicleState
		{
			get
			{
				if (_vehicleState == null)
				{
					_vehicleState = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "VehicleState", cr2w, this);
				}
				return _vehicleState;
			}
			set
			{
				if (_vehicleState == value)
				{
					return;
				}
				_vehicleState = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("VehicleReady")] 
		public gamebbScriptID_Bool VehicleReady
		{
			get
			{
				if (_vehicleReady == null)
				{
					_vehicleReady = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "VehicleReady", cr2w, this);
				}
				return _vehicleReady;
			}
			set
			{
				if (_vehicleReady == value)
				{
					return;
				}
				_vehicleReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("VehRadioState")] 
		public gamebbScriptID_Bool VehRadioState
		{
			get
			{
				if (_vehRadioState == null)
				{
					_vehRadioState = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "VehRadioState", cr2w, this);
				}
				return _vehRadioState;
			}
			set
			{
				if (_vehRadioState == value)
				{
					return;
				}
				_vehRadioState = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("VehRadioStationName")] 
		public gamebbScriptID_CName VehRadioStationName
		{
			get
			{
				if (_vehRadioStationName == null)
				{
					_vehRadioStationName = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "VehRadioStationName", cr2w, this);
				}
				return _vehRadioStationName;
			}
			set
			{
				if (_vehRadioStationName == value)
				{
					return;
				}
				_vehRadioStationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get
			{
				if (_isCrowd == null)
				{
					_isCrowd = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsCrowd", cr2w, this);
				}
				return _isCrowd;
			}
			set
			{
				if (_isCrowd == value)
				{
					return;
				}
				_isCrowd = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("IsUIActive")] 
		public gamebbScriptID_Bool IsUIActive
		{
			get
			{
				if (_isUIActive == null)
				{
					_isUIActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsUIActive", cr2w, this);
				}
				return _isUIActive;
			}
			set
			{
				if (_isUIActive == value)
				{
					return;
				}
				_isUIActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("GameTime")] 
		public gamebbScriptID_String GameTime
		{
			get
			{
				if (_gameTime == null)
				{
					_gameTime = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "GameTime", cr2w, this);
				}
				return _gameTime;
			}
			set
			{
				if (_gameTime == value)
				{
					return;
				}
				_gameTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("Collision")] 
		public gamebbScriptID_Bool Collision
		{
			get
			{
				if (_collision == null)
				{
					_collision = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Collision", cr2w, this);
				}
				return _collision;
			}
			set
			{
				if (_collision == value)
				{
					return;
				}
				_collision = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("DamageState")] 
		public gamebbScriptID_Int32 DamageState
		{
			get
			{
				if (_damageState == null)
				{
					_damageState = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "DamageState", cr2w, this);
				}
				return _damageState;
			}
			set
			{
				if (_damageState == value)
				{
					return;
				}
				_damageState = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("MeanSlipRatio")] 
		public gamebbScriptID_Float MeanSlipRatio
		{
			get
			{
				if (_meanSlipRatio == null)
				{
					_meanSlipRatio = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "MeanSlipRatio", cr2w, this);
				}
				return _meanSlipRatio;
			}
			set
			{
				if (_meanSlipRatio == value)
				{
					return;
				}
				_meanSlipRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("IsHandbraking")] 
		public gamebbScriptID_Int32 IsHandbraking
		{
			get
			{
				if (_isHandbraking == null)
				{
					_isHandbraking = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "IsHandbraking", cr2w, this);
				}
				return _isHandbraking;
			}
			set
			{
				if (_isHandbraking == value)
				{
					return;
				}
				_isHandbraking = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("EngineTemp")] 
		public gamebbScriptID_Float EngineTemp
		{
			get
			{
				if (_engineTemp == null)
				{
					_engineTemp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "EngineTemp", cr2w, this);
				}
				return _engineTemp;
			}
			set
			{
				if (_engineTemp == value)
				{
					return;
				}
				_engineTemp = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("IsInWater")] 
		public gamebbScriptID_Bool IsInWater
		{
			get
			{
				if (_isInWater == null)
				{
					_isInWater = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInWater", cr2w, this);
				}
				return _isInWater;
			}
			set
			{
				if (_isInWater == value)
				{
					return;
				}
				_isInWater = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("RaceTimer")] 
		public gamebbScriptID_String RaceTimer
		{
			get
			{
				if (_raceTimer == null)
				{
					_raceTimer = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "RaceTimer", cr2w, this);
				}
				return _raceTimer;
			}
			set
			{
				if (_raceTimer == value)
				{
					return;
				}
				_raceTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("IsTargetingFriendly")] 
		public gamebbScriptID_Bool IsTargetingFriendly
		{
			get
			{
				if (_isTargetingFriendly == null)
				{
					_isTargetingFriendly = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsTargetingFriendly", cr2w, this);
				}
				return _isTargetingFriendly;
			}
			set
			{
				if (_isTargetingFriendly == value)
				{
					return;
				}
				_isTargetingFriendly = value;
				PropertySet(this);
			}
		}

		public VehicleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

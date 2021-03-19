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
			get => GetProperty(ref _bikeTilt);
			set => SetProperty(ref _bikeTilt, value);
		}

		[Ordinal(1)] 
		[RED("SpeedValue")] 
		public gamebbScriptID_Float SpeedValue
		{
			get => GetProperty(ref _speedValue);
			set => SetProperty(ref _speedValue, value);
		}

		[Ordinal(2)] 
		[RED("GearValue")] 
		public gamebbScriptID_Int32 GearValue
		{
			get => GetProperty(ref _gearValue);
			set => SetProperty(ref _gearValue, value);
		}

		[Ordinal(3)] 
		[RED("RPMValue")] 
		public gamebbScriptID_Float RPMValue
		{
			get => GetProperty(ref _rPMValue);
			set => SetProperty(ref _rPMValue, value);
		}

		[Ordinal(4)] 
		[RED("RPMMax")] 
		public gamebbScriptID_Float RPMMax
		{
			get => GetProperty(ref _rPMMax);
			set => SetProperty(ref _rPMMax, value);
		}

		[Ordinal(5)] 
		[RED("SuspensionTransversalForce")] 
		public gamebbScriptID_Float SuspensionTransversalForce
		{
			get => GetProperty(ref _suspensionTransversalForce);
			set => SetProperty(ref _suspensionTransversalForce, value);
		}

		[Ordinal(6)] 
		[RED("SuspensionLongitudinalForce")] 
		public gamebbScriptID_Float SuspensionLongitudinalForce
		{
			get => GetProperty(ref _suspensionLongitudinalForce);
			set => SetProperty(ref _suspensionLongitudinalForce, value);
		}

		[Ordinal(7)] 
		[RED("IsAutopilotOn")] 
		public gamebbScriptID_Bool IsAutopilotOn
		{
			get => GetProperty(ref _isAutopilotOn);
			set => SetProperty(ref _isAutopilotOn, value);
		}

		[Ordinal(8)] 
		[RED("DeclutchTimer")] 
		public gamebbScriptID_Float DeclutchTimer
		{
			get => GetProperty(ref _declutchTimer);
			set => SetProperty(ref _declutchTimer, value);
		}

		[Ordinal(9)] 
		[RED("HandlingPenalty")] 
		public gamebbScriptID_Float HandlingPenalty
		{
			get => GetProperty(ref _handlingPenalty);
			set => SetProperty(ref _handlingPenalty, value);
		}

		[Ordinal(10)] 
		[RED("LightMode")] 
		public gamebbScriptID_Int32 LightMode
		{
			get => GetProperty(ref _lightMode);
			set => SetProperty(ref _lightMode, value);
		}

		[Ordinal(11)] 
		[RED("VehicleState")] 
		public gamebbScriptID_Int32 VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}

		[Ordinal(12)] 
		[RED("VehicleReady")] 
		public gamebbScriptID_Bool VehicleReady
		{
			get => GetProperty(ref _vehicleReady);
			set => SetProperty(ref _vehicleReady, value);
		}

		[Ordinal(13)] 
		[RED("VehRadioState")] 
		public gamebbScriptID_Bool VehRadioState
		{
			get => GetProperty(ref _vehRadioState);
			set => SetProperty(ref _vehRadioState, value);
		}

		[Ordinal(14)] 
		[RED("VehRadioStationName")] 
		public gamebbScriptID_CName VehRadioStationName
		{
			get => GetProperty(ref _vehRadioStationName);
			set => SetProperty(ref _vehRadioStationName, value);
		}

		[Ordinal(15)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get => GetProperty(ref _isCrowd);
			set => SetProperty(ref _isCrowd, value);
		}

		[Ordinal(16)] 
		[RED("IsUIActive")] 
		public gamebbScriptID_Bool IsUIActive
		{
			get => GetProperty(ref _isUIActive);
			set => SetProperty(ref _isUIActive, value);
		}

		[Ordinal(17)] 
		[RED("GameTime")] 
		public gamebbScriptID_String GameTime
		{
			get => GetProperty(ref _gameTime);
			set => SetProperty(ref _gameTime, value);
		}

		[Ordinal(18)] 
		[RED("Collision")] 
		public gamebbScriptID_Bool Collision
		{
			get => GetProperty(ref _collision);
			set => SetProperty(ref _collision, value);
		}

		[Ordinal(19)] 
		[RED("DamageState")] 
		public gamebbScriptID_Int32 DamageState
		{
			get => GetProperty(ref _damageState);
			set => SetProperty(ref _damageState, value);
		}

		[Ordinal(20)] 
		[RED("MeanSlipRatio")] 
		public gamebbScriptID_Float MeanSlipRatio
		{
			get => GetProperty(ref _meanSlipRatio);
			set => SetProperty(ref _meanSlipRatio, value);
		}

		[Ordinal(21)] 
		[RED("IsHandbraking")] 
		public gamebbScriptID_Int32 IsHandbraking
		{
			get => GetProperty(ref _isHandbraking);
			set => SetProperty(ref _isHandbraking, value);
		}

		[Ordinal(22)] 
		[RED("EngineTemp")] 
		public gamebbScriptID_Float EngineTemp
		{
			get => GetProperty(ref _engineTemp);
			set => SetProperty(ref _engineTemp, value);
		}

		[Ordinal(23)] 
		[RED("IsInWater")] 
		public gamebbScriptID_Bool IsInWater
		{
			get => GetProperty(ref _isInWater);
			set => SetProperty(ref _isInWater, value);
		}

		[Ordinal(24)] 
		[RED("RaceTimer")] 
		public gamebbScriptID_String RaceTimer
		{
			get => GetProperty(ref _raceTimer);
			set => SetProperty(ref _raceTimer, value);
		}

		[Ordinal(25)] 
		[RED("IsTargetingFriendly")] 
		public gamebbScriptID_Bool IsTargetingFriendly
		{
			get => GetProperty(ref _isTargetingFriendly);
			set => SetProperty(ref _isTargetingFriendly, value);
		}

		public VehicleDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

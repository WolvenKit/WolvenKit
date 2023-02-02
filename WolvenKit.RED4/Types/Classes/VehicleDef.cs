using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("BikeTilt")] 
		public gamebbScriptID_Float BikeTilt
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(1)] 
		[RED("SpeedValue")] 
		public gamebbScriptID_Float SpeedValue
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("GearValue")] 
		public gamebbScriptID_Int32 GearValue
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("RPMValue")] 
		public gamebbScriptID_Float RPMValue
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("RPMMax")] 
		public gamebbScriptID_Float RPMMax
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(5)] 
		[RED("SuspensionTransversalForce")] 
		public gamebbScriptID_Float SuspensionTransversalForce
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(6)] 
		[RED("SuspensionLongitudinalForce")] 
		public gamebbScriptID_Float SuspensionLongitudinalForce
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(7)] 
		[RED("IsAutopilotOn")] 
		public gamebbScriptID_Bool IsAutopilotOn
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("DeclutchTimer")] 
		public gamebbScriptID_Float DeclutchTimer
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(9)] 
		[RED("HandlingPenalty")] 
		public gamebbScriptID_Float HandlingPenalty
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(10)] 
		[RED("LightMode")] 
		public gamebbScriptID_Int32 LightMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("VehicleState")] 
		public gamebbScriptID_Int32 VehicleState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(12)] 
		[RED("VehicleReady")] 
		public gamebbScriptID_Bool VehicleReady
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(13)] 
		[RED("VehRadioState")] 
		public gamebbScriptID_Bool VehRadioState
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("VehRadioStationName")] 
		public gamebbScriptID_CName VehRadioStationName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(15)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("IsUIActive")] 
		public gamebbScriptID_Bool IsUIActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(17)] 
		[RED("GameTime")] 
		public gamebbScriptID_String GameTime
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(18)] 
		[RED("Collision")] 
		public gamebbScriptID_Bool Collision
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(19)] 
		[RED("DamageState")] 
		public gamebbScriptID_Int32 DamageState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(20)] 
		[RED("MeanSlipRatio")] 
		public gamebbScriptID_Float MeanSlipRatio
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(21)] 
		[RED("IsHandbraking")] 
		public gamebbScriptID_Int32 IsHandbraking
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(22)] 
		[RED("EngineTemp")] 
		public gamebbScriptID_Float EngineTemp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(23)] 
		[RED("IsInWater")] 
		public gamebbScriptID_Bool IsInWater
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(24)] 
		[RED("RaceTimer")] 
		public gamebbScriptID_String RaceTimer
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(25)] 
		[RED("IsTargetingFriendly")] 
		public gamebbScriptID_Bool IsTargetingFriendly
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public VehicleDef()
		{
			BikeTilt = new();
			SpeedValue = new();
			GearValue = new();
			RPMValue = new();
			RPMMax = new();
			SuspensionTransversalForce = new();
			SuspensionLongitudinalForce = new();
			IsAutopilotOn = new();
			DeclutchTimer = new();
			HandlingPenalty = new();
			LightMode = new();
			VehicleState = new();
			VehicleReady = new();
			VehRadioState = new();
			VehRadioStationName = new();
			IsCrowd = new();
			IsUIActive = new();
			GameTime = new();
			Collision = new();
			DamageState = new();
			MeanSlipRatio = new();
			IsHandbraking = new();
			EngineTemp = new();
			IsInWater = new();
			RaceTimer = new();
			IsTargetingFriendly = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleComponent : ScriptableDeviceComponent
	{
		[Ordinal(4)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(5)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get => GetPropertyValue<CHandle<gameScanningComponent>>();
			set => SetPropertyValue<CHandle<gameScanningComponent>>(value);
		}

		[Ordinal(6)] 
		[RED("damageLevel")] 
		public CInt32 DamageLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("coolerDestro")] 
		public CBool CoolerDestro
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("bumperFrontState")] 
		public CInt32 BumperFrontState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("bumperBackState")] 
		public CInt32 BumperBackState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("healthStatPoolListener")] 
		public CHandle<VehicleHealthStatPoolListener> HealthStatPoolListener
		{
			get => GetPropertyValue<CHandle<VehicleHealthStatPoolListener>>();
			set => SetPropertyValue<CHandle<VehicleHealthStatPoolListener>>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("radioState")] 
		public CBool RadioState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(17)] 
		[RED("ignoreAutoDoorClose")] 
		public CBool IgnoreAutoDoorClose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("vehicleTPPCallbackID")] 
		public CHandle<redCallbackObject> VehicleTPPCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("vehicleSpeedCallbackID")] 
		public CHandle<redCallbackObject> VehicleSpeedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("vehicleRPMCallbackID")] 
		public CHandle<redCallbackObject> VehicleRPMCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("broadcasting")] 
		public CBool Broadcasting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("hasSpoiler")] 
		public CBool HasSpoiler
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("spoilerUp")] 
		public CFloat SpoilerUp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("spoilerDown")] 
		public CFloat SpoilerDown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("spoilerDeployed")] 
		public CBool SpoilerDeployed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("hasTurboCharger")] 
		public CBool HasTurboCharger
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(29)] 
		[RED("overheatActive")] 
		public CBool OverheatActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("hornOn")] 
		public CBool HornOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("hasSiren")] 
		public CBool HasSiren
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("hornPressTime")] 
		public CFloat HornPressTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("radioPressTime")] 
		public CFloat RadioPressTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("raceClockTickID")] 
		public gameDelayID RaceClockTickID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(35)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetPropertyValue<CHandle<gameObjectActionsCallbackController>>();
			set => SetPropertyValue<CHandle<gameObjectActionsCallbackController>>(value);
		}

		[Ordinal(36)] 
		[RED("trunkNpcBody")] 
		public CWeakHandle<gameObject> TrunkNpcBody
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(37)] 
		[RED("mountedPlayer")] 
		public CWeakHandle<PlayerPuppet> MountedPlayer
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(38)] 
		[RED("isIgnoredInTargetingSystem")] 
		public CBool IsIgnoredInTargetingSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("arePlayerHitShapesEnabled")] 
		public CBool ArePlayerHitShapesEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("uiWantedBarBB")] 
		public CWeakHandle<gameIBlackboard> UiWantedBarBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(41)] 
		[RED("currentWantedLevelCallback")] 
		public CHandle<redCallbackObject> CurrentWantedLevelCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("vehicleController")] 
		public CHandle<vehicleController> VehicleController
		{
			get => GetPropertyValue<CHandle<vehicleController>>();
			set => SetPropertyValue<CHandle<vehicleController>>(value);
		}

		public VehicleComponent()
		{
			MappinID = new();
			RaceClockTickID = new();
			ArePlayerHitShapesEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

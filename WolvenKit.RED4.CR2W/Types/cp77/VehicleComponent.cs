using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleComponent : ScriptableDC
	{
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<gameScanningComponent> _scanningComponent;
		private CInt32 _damageLevel;
		private CBool _coolerDestro;
		private CBool _submerged;
		private CInt32 _bumperFrontState;
		private CInt32 _bumperBackState;
		private CBool _visualDestructionSet;
		private CHandle<VehicleHealthStatPoolListener> _healthStatPoolListener;
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CBool _radioState;
		private CBool _mounted;
		private CFloat _enterTime;
		private gameNewMappinID _mappinID;
		private CBool _ignoreAutoDoorClose;
		private CUInt32 _timeSystemCallbackID;
		private CUInt32 _vehicleTPPCallbackID;
		private CUInt32 _vehicleSpeedCallbackID;
		private CUInt32 _vehicleRPMCallbackID;
		private CBool _broadcasting;
		private CBool _hasSpoiler;
		private CFloat _spoilerUp;
		private CFloat _spoilerDown;
		private CBool _spoilerDeployed;
		private CBool _hasTurboCharger;
		private CHandle<worldEffectBlackboard> _overheatEffectBlackboard;
		private CBool _overheatActive;
		private CBool _hornOn;
		private CBool _hasSiren;
		private CFloat _hornPressTime;
		private CFloat _radioPressTime;
		private gameDelayID _raceClockTickID;
		private CHandle<gameObjectActionsCallbackController> _objectActionsCallbackCtrl;
		private wCHandle<PlayerPuppet> _mountedPlayer;
		private CBool _isIgnoredInTargetingSystem;
		private CBool _arePlayerHitShapesEnabled;
		private CHandle<vehicleController> _vehicleController;

		[Ordinal(4)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(5)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get => GetProperty(ref _scanningComponent);
			set => SetProperty(ref _scanningComponent, value);
		}

		[Ordinal(6)] 
		[RED("damageLevel")] 
		public CInt32 DamageLevel
		{
			get => GetProperty(ref _damageLevel);
			set => SetProperty(ref _damageLevel, value);
		}

		[Ordinal(7)] 
		[RED("coolerDestro")] 
		public CBool CoolerDestro
		{
			get => GetProperty(ref _coolerDestro);
			set => SetProperty(ref _coolerDestro, value);
		}

		[Ordinal(8)] 
		[RED("submerged")] 
		public CBool Submerged
		{
			get => GetProperty(ref _submerged);
			set => SetProperty(ref _submerged, value);
		}

		[Ordinal(9)] 
		[RED("bumperFrontState")] 
		public CInt32 BumperFrontState
		{
			get => GetProperty(ref _bumperFrontState);
			set => SetProperty(ref _bumperFrontState, value);
		}

		[Ordinal(10)] 
		[RED("bumperBackState")] 
		public CInt32 BumperBackState
		{
			get => GetProperty(ref _bumperBackState);
			set => SetProperty(ref _bumperBackState, value);
		}

		[Ordinal(11)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetProperty(ref _visualDestructionSet);
			set => SetProperty(ref _visualDestructionSet, value);
		}

		[Ordinal(12)] 
		[RED("healthStatPoolListener")] 
		public CHandle<VehicleHealthStatPoolListener> HealthStatPoolListener
		{
			get => GetProperty(ref _healthStatPoolListener);
			set => SetProperty(ref _healthStatPoolListener, value);
		}

		[Ordinal(13)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(14)] 
		[RED("radioState")] 
		public CBool RadioState
		{
			get => GetProperty(ref _radioState);
			set => SetProperty(ref _radioState, value);
		}

		[Ordinal(15)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get => GetProperty(ref _mounted);
			set => SetProperty(ref _mounted, value);
		}

		[Ordinal(16)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get => GetProperty(ref _enterTime);
			set => SetProperty(ref _enterTime, value);
		}

		[Ordinal(17)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(18)] 
		[RED("ignoreAutoDoorClose")] 
		public CBool IgnoreAutoDoorClose
		{
			get => GetProperty(ref _ignoreAutoDoorClose);
			set => SetProperty(ref _ignoreAutoDoorClose, value);
		}

		[Ordinal(19)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get => GetProperty(ref _timeSystemCallbackID);
			set => SetProperty(ref _timeSystemCallbackID, value);
		}

		[Ordinal(20)] 
		[RED("vehicleTPPCallbackID")] 
		public CUInt32 VehicleTPPCallbackID
		{
			get => GetProperty(ref _vehicleTPPCallbackID);
			set => SetProperty(ref _vehicleTPPCallbackID, value);
		}

		[Ordinal(21)] 
		[RED("vehicleSpeedCallbackID")] 
		public CUInt32 VehicleSpeedCallbackID
		{
			get => GetProperty(ref _vehicleSpeedCallbackID);
			set => SetProperty(ref _vehicleSpeedCallbackID, value);
		}

		[Ordinal(22)] 
		[RED("vehicleRPMCallbackID")] 
		public CUInt32 VehicleRPMCallbackID
		{
			get => GetProperty(ref _vehicleRPMCallbackID);
			set => SetProperty(ref _vehicleRPMCallbackID, value);
		}

		[Ordinal(23)] 
		[RED("broadcasting")] 
		public CBool Broadcasting
		{
			get => GetProperty(ref _broadcasting);
			set => SetProperty(ref _broadcasting, value);
		}

		[Ordinal(24)] 
		[RED("hasSpoiler")] 
		public CBool HasSpoiler
		{
			get => GetProperty(ref _hasSpoiler);
			set => SetProperty(ref _hasSpoiler, value);
		}

		[Ordinal(25)] 
		[RED("spoilerUp")] 
		public CFloat SpoilerUp
		{
			get => GetProperty(ref _spoilerUp);
			set => SetProperty(ref _spoilerUp, value);
		}

		[Ordinal(26)] 
		[RED("spoilerDown")] 
		public CFloat SpoilerDown
		{
			get => GetProperty(ref _spoilerDown);
			set => SetProperty(ref _spoilerDown, value);
		}

		[Ordinal(27)] 
		[RED("spoilerDeployed")] 
		public CBool SpoilerDeployed
		{
			get => GetProperty(ref _spoilerDeployed);
			set => SetProperty(ref _spoilerDeployed, value);
		}

		[Ordinal(28)] 
		[RED("hasTurboCharger")] 
		public CBool HasTurboCharger
		{
			get => GetProperty(ref _hasTurboCharger);
			set => SetProperty(ref _hasTurboCharger, value);
		}

		[Ordinal(29)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get => GetProperty(ref _overheatEffectBlackboard);
			set => SetProperty(ref _overheatEffectBlackboard, value);
		}

		[Ordinal(30)] 
		[RED("overheatActive")] 
		public CBool OverheatActive
		{
			get => GetProperty(ref _overheatActive);
			set => SetProperty(ref _overheatActive, value);
		}

		[Ordinal(31)] 
		[RED("hornOn")] 
		public CBool HornOn
		{
			get => GetProperty(ref _hornOn);
			set => SetProperty(ref _hornOn, value);
		}

		[Ordinal(32)] 
		[RED("hasSiren")] 
		public CBool HasSiren
		{
			get => GetProperty(ref _hasSiren);
			set => SetProperty(ref _hasSiren, value);
		}

		[Ordinal(33)] 
		[RED("hornPressTime")] 
		public CFloat HornPressTime
		{
			get => GetProperty(ref _hornPressTime);
			set => SetProperty(ref _hornPressTime, value);
		}

		[Ordinal(34)] 
		[RED("radioPressTime")] 
		public CFloat RadioPressTime
		{
			get => GetProperty(ref _radioPressTime);
			set => SetProperty(ref _radioPressTime, value);
		}

		[Ordinal(35)] 
		[RED("raceClockTickID")] 
		public gameDelayID RaceClockTickID
		{
			get => GetProperty(ref _raceClockTickID);
			set => SetProperty(ref _raceClockTickID, value);
		}

		[Ordinal(36)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetProperty(ref _objectActionsCallbackCtrl);
			set => SetProperty(ref _objectActionsCallbackCtrl, value);
		}

		[Ordinal(37)] 
		[RED("mountedPlayer")] 
		public wCHandle<PlayerPuppet> MountedPlayer
		{
			get => GetProperty(ref _mountedPlayer);
			set => SetProperty(ref _mountedPlayer, value);
		}

		[Ordinal(38)] 
		[RED("isIgnoredInTargetingSystem")] 
		public CBool IsIgnoredInTargetingSystem
		{
			get => GetProperty(ref _isIgnoredInTargetingSystem);
			set => SetProperty(ref _isIgnoredInTargetingSystem, value);
		}

		[Ordinal(39)] 
		[RED("arePlayerHitShapesEnabled")] 
		public CBool ArePlayerHitShapesEnabled
		{
			get => GetProperty(ref _arePlayerHitShapesEnabled);
			set => SetProperty(ref _arePlayerHitShapesEnabled, value);
		}

		[Ordinal(40)] 
		[RED("vehicleController")] 
		public CHandle<vehicleController> VehicleController
		{
			get => GetProperty(ref _vehicleController);
			set => SetProperty(ref _vehicleController, value);
		}

		public VehicleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

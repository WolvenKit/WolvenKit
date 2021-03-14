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
			get
			{
				if (_interaction == null)
				{
					_interaction = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interaction", cr2w, this);
				}
				return _interaction;
			}
			set
			{
				if (_interaction == value)
				{
					return;
				}
				_interaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get
			{
				if (_scanningComponent == null)
				{
					_scanningComponent = (CHandle<gameScanningComponent>) CR2WTypeManager.Create("handle:gameScanningComponent", "scanningComponent", cr2w, this);
				}
				return _scanningComponent;
			}
			set
			{
				if (_scanningComponent == value)
				{
					return;
				}
				_scanningComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("damageLevel")] 
		public CInt32 DamageLevel
		{
			get
			{
				if (_damageLevel == null)
				{
					_damageLevel = (CInt32) CR2WTypeManager.Create("Int32", "damageLevel", cr2w, this);
				}
				return _damageLevel;
			}
			set
			{
				if (_damageLevel == value)
				{
					return;
				}
				_damageLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("coolerDestro")] 
		public CBool CoolerDestro
		{
			get
			{
				if (_coolerDestro == null)
				{
					_coolerDestro = (CBool) CR2WTypeManager.Create("Bool", "coolerDestro", cr2w, this);
				}
				return _coolerDestro;
			}
			set
			{
				if (_coolerDestro == value)
				{
					return;
				}
				_coolerDestro = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("submerged")] 
		public CBool Submerged
		{
			get
			{
				if (_submerged == null)
				{
					_submerged = (CBool) CR2WTypeManager.Create("Bool", "submerged", cr2w, this);
				}
				return _submerged;
			}
			set
			{
				if (_submerged == value)
				{
					return;
				}
				_submerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bumperFrontState")] 
		public CInt32 BumperFrontState
		{
			get
			{
				if (_bumperFrontState == null)
				{
					_bumperFrontState = (CInt32) CR2WTypeManager.Create("Int32", "bumperFrontState", cr2w, this);
				}
				return _bumperFrontState;
			}
			set
			{
				if (_bumperFrontState == value)
				{
					return;
				}
				_bumperFrontState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bumperBackState")] 
		public CInt32 BumperBackState
		{
			get
			{
				if (_bumperBackState == null)
				{
					_bumperBackState = (CInt32) CR2WTypeManager.Create("Int32", "bumperBackState", cr2w, this);
				}
				return _bumperBackState;
			}
			set
			{
				if (_bumperBackState == value)
				{
					return;
				}
				_bumperBackState = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get
			{
				if (_visualDestructionSet == null)
				{
					_visualDestructionSet = (CBool) CR2WTypeManager.Create("Bool", "visualDestructionSet", cr2w, this);
				}
				return _visualDestructionSet;
			}
			set
			{
				if (_visualDestructionSet == value)
				{
					return;
				}
				_visualDestructionSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("healthStatPoolListener")] 
		public CHandle<VehicleHealthStatPoolListener> HealthStatPoolListener
		{
			get
			{
				if (_healthStatPoolListener == null)
				{
					_healthStatPoolListener = (CHandle<VehicleHealthStatPoolListener>) CR2WTypeManager.Create("handle:VehicleHealthStatPoolListener", "healthStatPoolListener", cr2w, this);
				}
				return _healthStatPoolListener;
			}
			set
			{
				if (_healthStatPoolListener == value)
				{
					return;
				}
				_healthStatPoolListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get
			{
				if (_vehicleBlackboard == null)
				{
					_vehicleBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "vehicleBlackboard", cr2w, this);
				}
				return _vehicleBlackboard;
			}
			set
			{
				if (_vehicleBlackboard == value)
				{
					return;
				}
				_vehicleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("radioState")] 
		public CBool RadioState
		{
			get
			{
				if (_radioState == null)
				{
					_radioState = (CBool) CR2WTypeManager.Create("Bool", "radioState", cr2w, this);
				}
				return _radioState;
			}
			set
			{
				if (_radioState == value)
				{
					return;
				}
				_radioState = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get
			{
				if (_mounted == null)
				{
					_mounted = (CBool) CR2WTypeManager.Create("Bool", "mounted", cr2w, this);
				}
				return _mounted;
			}
			set
			{
				if (_mounted == value)
				{
					return;
				}
				_mounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get
			{
				if (_enterTime == null)
				{
					_enterTime = (CFloat) CR2WTypeManager.Create("Float", "enterTime", cr2w, this);
				}
				return _enterTime;
			}
			set
			{
				if (_enterTime == value)
				{
					return;
				}
				_enterTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get
			{
				if (_mappinID == null)
				{
					_mappinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "mappinID", cr2w, this);
				}
				return _mappinID;
			}
			set
			{
				if (_mappinID == value)
				{
					return;
				}
				_mappinID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ignoreAutoDoorClose")] 
		public CBool IgnoreAutoDoorClose
		{
			get
			{
				if (_ignoreAutoDoorClose == null)
				{
					_ignoreAutoDoorClose = (CBool) CR2WTypeManager.Create("Bool", "ignoreAutoDoorClose", cr2w, this);
				}
				return _ignoreAutoDoorClose;
			}
			set
			{
				if (_ignoreAutoDoorClose == value)
				{
					return;
				}
				_ignoreAutoDoorClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get
			{
				if (_timeSystemCallbackID == null)
				{
					_timeSystemCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "timeSystemCallbackID", cr2w, this);
				}
				return _timeSystemCallbackID;
			}
			set
			{
				if (_timeSystemCallbackID == value)
				{
					return;
				}
				_timeSystemCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("vehicleTPPCallbackID")] 
		public CUInt32 VehicleTPPCallbackID
		{
			get
			{
				if (_vehicleTPPCallbackID == null)
				{
					_vehicleTPPCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleTPPCallbackID", cr2w, this);
				}
				return _vehicleTPPCallbackID;
			}
			set
			{
				if (_vehicleTPPCallbackID == value)
				{
					return;
				}
				_vehicleTPPCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("vehicleSpeedCallbackID")] 
		public CUInt32 VehicleSpeedCallbackID
		{
			get
			{
				if (_vehicleSpeedCallbackID == null)
				{
					_vehicleSpeedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleSpeedCallbackID", cr2w, this);
				}
				return _vehicleSpeedCallbackID;
			}
			set
			{
				if (_vehicleSpeedCallbackID == value)
				{
					return;
				}
				_vehicleSpeedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("vehicleRPMCallbackID")] 
		public CUInt32 VehicleRPMCallbackID
		{
			get
			{
				if (_vehicleRPMCallbackID == null)
				{
					_vehicleRPMCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleRPMCallbackID", cr2w, this);
				}
				return _vehicleRPMCallbackID;
			}
			set
			{
				if (_vehicleRPMCallbackID == value)
				{
					return;
				}
				_vehicleRPMCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("broadcasting")] 
		public CBool Broadcasting
		{
			get
			{
				if (_broadcasting == null)
				{
					_broadcasting = (CBool) CR2WTypeManager.Create("Bool", "broadcasting", cr2w, this);
				}
				return _broadcasting;
			}
			set
			{
				if (_broadcasting == value)
				{
					return;
				}
				_broadcasting = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("hasSpoiler")] 
		public CBool HasSpoiler
		{
			get
			{
				if (_hasSpoiler == null)
				{
					_hasSpoiler = (CBool) CR2WTypeManager.Create("Bool", "hasSpoiler", cr2w, this);
				}
				return _hasSpoiler;
			}
			set
			{
				if (_hasSpoiler == value)
				{
					return;
				}
				_hasSpoiler = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("spoilerUp")] 
		public CFloat SpoilerUp
		{
			get
			{
				if (_spoilerUp == null)
				{
					_spoilerUp = (CFloat) CR2WTypeManager.Create("Float", "spoilerUp", cr2w, this);
				}
				return _spoilerUp;
			}
			set
			{
				if (_spoilerUp == value)
				{
					return;
				}
				_spoilerUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("spoilerDown")] 
		public CFloat SpoilerDown
		{
			get
			{
				if (_spoilerDown == null)
				{
					_spoilerDown = (CFloat) CR2WTypeManager.Create("Float", "spoilerDown", cr2w, this);
				}
				return _spoilerDown;
			}
			set
			{
				if (_spoilerDown == value)
				{
					return;
				}
				_spoilerDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("spoilerDeployed")] 
		public CBool SpoilerDeployed
		{
			get
			{
				if (_spoilerDeployed == null)
				{
					_spoilerDeployed = (CBool) CR2WTypeManager.Create("Bool", "spoilerDeployed", cr2w, this);
				}
				return _spoilerDeployed;
			}
			set
			{
				if (_spoilerDeployed == value)
				{
					return;
				}
				_spoilerDeployed = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("hasTurboCharger")] 
		public CBool HasTurboCharger
		{
			get
			{
				if (_hasTurboCharger == null)
				{
					_hasTurboCharger = (CBool) CR2WTypeManager.Create("Bool", "hasTurboCharger", cr2w, this);
				}
				return _hasTurboCharger;
			}
			set
			{
				if (_hasTurboCharger == value)
				{
					return;
				}
				_hasTurboCharger = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get
			{
				if (_overheatEffectBlackboard == null)
				{
					_overheatEffectBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "overheatEffectBlackboard", cr2w, this);
				}
				return _overheatEffectBlackboard;
			}
			set
			{
				if (_overheatEffectBlackboard == value)
				{
					return;
				}
				_overheatEffectBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("overheatActive")] 
		public CBool OverheatActive
		{
			get
			{
				if (_overheatActive == null)
				{
					_overheatActive = (CBool) CR2WTypeManager.Create("Bool", "overheatActive", cr2w, this);
				}
				return _overheatActive;
			}
			set
			{
				if (_overheatActive == value)
				{
					return;
				}
				_overheatActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("hornOn")] 
		public CBool HornOn
		{
			get
			{
				if (_hornOn == null)
				{
					_hornOn = (CBool) CR2WTypeManager.Create("Bool", "hornOn", cr2w, this);
				}
				return _hornOn;
			}
			set
			{
				if (_hornOn == value)
				{
					return;
				}
				_hornOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("hasSiren")] 
		public CBool HasSiren
		{
			get
			{
				if (_hasSiren == null)
				{
					_hasSiren = (CBool) CR2WTypeManager.Create("Bool", "hasSiren", cr2w, this);
				}
				return _hasSiren;
			}
			set
			{
				if (_hasSiren == value)
				{
					return;
				}
				_hasSiren = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("hornPressTime")] 
		public CFloat HornPressTime
		{
			get
			{
				if (_hornPressTime == null)
				{
					_hornPressTime = (CFloat) CR2WTypeManager.Create("Float", "hornPressTime", cr2w, this);
				}
				return _hornPressTime;
			}
			set
			{
				if (_hornPressTime == value)
				{
					return;
				}
				_hornPressTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("radioPressTime")] 
		public CFloat RadioPressTime
		{
			get
			{
				if (_radioPressTime == null)
				{
					_radioPressTime = (CFloat) CR2WTypeManager.Create("Float", "radioPressTime", cr2w, this);
				}
				return _radioPressTime;
			}
			set
			{
				if (_radioPressTime == value)
				{
					return;
				}
				_radioPressTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("raceClockTickID")] 
		public gameDelayID RaceClockTickID
		{
			get
			{
				if (_raceClockTickID == null)
				{
					_raceClockTickID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "raceClockTickID", cr2w, this);
				}
				return _raceClockTickID;
			}
			set
			{
				if (_raceClockTickID == value)
				{
					return;
				}
				_raceClockTickID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get
			{
				if (_objectActionsCallbackCtrl == null)
				{
					_objectActionsCallbackCtrl = (CHandle<gameObjectActionsCallbackController>) CR2WTypeManager.Create("handle:gameObjectActionsCallbackController", "objectActionsCallbackCtrl", cr2w, this);
				}
				return _objectActionsCallbackCtrl;
			}
			set
			{
				if (_objectActionsCallbackCtrl == value)
				{
					return;
				}
				_objectActionsCallbackCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("mountedPlayer")] 
		public wCHandle<PlayerPuppet> MountedPlayer
		{
			get
			{
				if (_mountedPlayer == null)
				{
					_mountedPlayer = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "mountedPlayer", cr2w, this);
				}
				return _mountedPlayer;
			}
			set
			{
				if (_mountedPlayer == value)
				{
					return;
				}
				_mountedPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("isIgnoredInTargetingSystem")] 
		public CBool IsIgnoredInTargetingSystem
		{
			get
			{
				if (_isIgnoredInTargetingSystem == null)
				{
					_isIgnoredInTargetingSystem = (CBool) CR2WTypeManager.Create("Bool", "isIgnoredInTargetingSystem", cr2w, this);
				}
				return _isIgnoredInTargetingSystem;
			}
			set
			{
				if (_isIgnoredInTargetingSystem == value)
				{
					return;
				}
				_isIgnoredInTargetingSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("arePlayerHitShapesEnabled")] 
		public CBool ArePlayerHitShapesEnabled
		{
			get
			{
				if (_arePlayerHitShapesEnabled == null)
				{
					_arePlayerHitShapesEnabled = (CBool) CR2WTypeManager.Create("Bool", "arePlayerHitShapesEnabled", cr2w, this);
				}
				return _arePlayerHitShapesEnabled;
			}
			set
			{
				if (_arePlayerHitShapesEnabled == value)
				{
					return;
				}
				_arePlayerHitShapesEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("vehicleController")] 
		public CHandle<vehicleController> VehicleController
		{
			get
			{
				if (_vehicleController == null)
				{
					_vehicleController = (CHandle<vehicleController>) CR2WTypeManager.Create("handle:vehicleController", "vehicleController", cr2w, this);
				}
				return _vehicleController;
			}
			set
			{
				if (_vehicleController == value)
				{
					return;
				}
				_vehicleController = value;
				PropertySet(this);
			}
		}

		public VehicleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IronsightGameController : gameuiIronsightGameController
	{
		private wCHandle<gameObject> _playerPuppet;
		private inkWidgetReference _dot;
		private inkTextWidgetReference _ammo;
		private inkTextWidgetReference _ammoSpareCount;
		private inkTextWidgetReference _range;
		private CBool _seeThroughWalls;
		private inkWidgetReference _targetAttitudeFriendly;
		private inkWidgetReference _targetAttitudeHostile;
		private inkWidgetReference _targetAttitudeEnemyNonHostile;
		private CHandle<gameIBlackboard> _weaponDataBB;
		private CName _targetHitAnimationName;
		private CHandle<inkanimProxy> _targetHitAnimation;
		private CUInt32 _weaponDataTargetHitBBID;
		private CName _shootAnimationName;
		private CHandle<inkanimProxy> _shootAnimation;
		private CUInt32 _weaponDataShootBBID;
		private CInt32 _currentAmmo;
		private CHandle<inkanimProxy> _animIntro;
		private CHandle<inkanimProxy> _animLoop;
		private CHandle<inkanimProxy> _animReload;
		private CHandle<gameSlotDataHolder> _bufferedRosterData;
		private gameSlotWeaponData _activeWeapon;
		private InventoryItemData _weaponItemData;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<gameIBlackboard> _bb;
		private CUInt32 _bbID;
		private wCHandle<gameObject> _target;
		private wCHandle<gameIBlackboard> _targetBB;
		private CFloat _targetRange;
		private CUInt32 _targetRangeBBID;
		private CUInt32 _targetAttitudeBBID;
		private CUInt32 _targetAcquiredBBID;
		private CUInt32 _targetRangeObstructedBBID;
		private CUInt32 _targetAcquiredObstructedBBID;
		private CUInt32 _targetRangeDecimalPrecision;
		private wCHandle<TargetAttitudeAnimationController> _targetAttitudeAnimator;
		private inkWidgetReference _targetAttitudeContainer;
		private CHandle<IronsightTargetHealthChangeListener> _targetHealthListener;
		private wCHandle<CompassController> _compass;
		private inkWidgetReference _compassContainer;
		private wCHandle<CompassController> _compass2;
		private inkWidgetReference _compassContainer2;
		private wCHandle<AltimeterController> _altimeter;
		private inkWidgetReference _altimeterContainer;
		private wCHandle<gameIBlackboard> _weaponBB;
		private wCHandle<ChargebarController> _chargebar;
		private inkWidgetReference _chargebarContainer;
		private CUInt32 _chargebarValueChanged;
		private CUInt32 _chargebarTriggerModeChanged;
		private inkWidgetReference _aDSContainer;
		private wCHandle<AimDownSightController> _aDSAnimator;
		private CHandle<gameIBlackboard> _playerStateMachineBB;
		private CUInt32 _playerStateMachineUpperBodyBBID;
		private CUInt32 _crosshairStateChanged;
		private CEnum<gamePSMCrosshairStates> _crosshairState;
		private CBool _isTargetEnemy;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(2)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dot")] 
		public inkWidgetReference Dot
		{
			get
			{
				if (_dot == null)
				{
					_dot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dot", cr2w, this);
				}
				return _dot;
			}
			set
			{
				if (_dot == value)
				{
					return;
				}
				_dot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ammo")] 
		public inkTextWidgetReference Ammo
		{
			get
			{
				if (_ammo == null)
				{
					_ammo = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ammo", cr2w, this);
				}
				return _ammo;
			}
			set
			{
				if (_ammo == value)
				{
					return;
				}
				_ammo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ammoSpareCount")] 
		public inkTextWidgetReference AmmoSpareCount
		{
			get
			{
				if (_ammoSpareCount == null)
				{
					_ammoSpareCount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ammoSpareCount", cr2w, this);
				}
				return _ammoSpareCount;
			}
			set
			{
				if (_ammoSpareCount == value)
				{
					return;
				}
				_ammoSpareCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("range")] 
		public inkTextWidgetReference Range
		{
			get
			{
				if (_range == null)
				{
					_range = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("seeThroughWalls")] 
		public CBool SeeThroughWalls
		{
			get
			{
				if (_seeThroughWalls == null)
				{
					_seeThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "seeThroughWalls", cr2w, this);
				}
				return _seeThroughWalls;
			}
			set
			{
				if (_seeThroughWalls == value)
				{
					return;
				}
				_seeThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("targetAttitudeFriendly")] 
		public inkWidgetReference TargetAttitudeFriendly
		{
			get
			{
				if (_targetAttitudeFriendly == null)
				{
					_targetAttitudeFriendly = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetAttitudeFriendly", cr2w, this);
				}
				return _targetAttitudeFriendly;
			}
			set
			{
				if (_targetAttitudeFriendly == value)
				{
					return;
				}
				_targetAttitudeFriendly = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("targetAttitudeHostile")] 
		public inkWidgetReference TargetAttitudeHostile
		{
			get
			{
				if (_targetAttitudeHostile == null)
				{
					_targetAttitudeHostile = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetAttitudeHostile", cr2w, this);
				}
				return _targetAttitudeHostile;
			}
			set
			{
				if (_targetAttitudeHostile == value)
				{
					return;
				}
				_targetAttitudeHostile = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("targetAttitudeEnemyNonHostile")] 
		public inkWidgetReference TargetAttitudeEnemyNonHostile
		{
			get
			{
				if (_targetAttitudeEnemyNonHostile == null)
				{
					_targetAttitudeEnemyNonHostile = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetAttitudeEnemyNonHostile", cr2w, this);
				}
				return _targetAttitudeEnemyNonHostile;
			}
			set
			{
				if (_targetAttitudeEnemyNonHostile == value)
				{
					return;
				}
				_targetAttitudeEnemyNonHostile = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("weaponDataBB")] 
		public CHandle<gameIBlackboard> WeaponDataBB
		{
			get
			{
				if (_weaponDataBB == null)
				{
					_weaponDataBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponDataBB", cr2w, this);
				}
				return _weaponDataBB;
			}
			set
			{
				if (_weaponDataBB == value)
				{
					return;
				}
				_weaponDataBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("targetHitAnimationName")] 
		public CName TargetHitAnimationName
		{
			get
			{
				if (_targetHitAnimationName == null)
				{
					_targetHitAnimationName = (CName) CR2WTypeManager.Create("CName", "targetHitAnimationName", cr2w, this);
				}
				return _targetHitAnimationName;
			}
			set
			{
				if (_targetHitAnimationName == value)
				{
					return;
				}
				_targetHitAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetHitAnimation")] 
		public CHandle<inkanimProxy> TargetHitAnimation
		{
			get
			{
				if (_targetHitAnimation == null)
				{
					_targetHitAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "targetHitAnimation", cr2w, this);
				}
				return _targetHitAnimation;
			}
			set
			{
				if (_targetHitAnimation == value)
				{
					return;
				}
				_targetHitAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("weaponDataTargetHitBBID")] 
		public CUInt32 WeaponDataTargetHitBBID
		{
			get
			{
				if (_weaponDataTargetHitBBID == null)
				{
					_weaponDataTargetHitBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponDataTargetHitBBID", cr2w, this);
				}
				return _weaponDataTargetHitBBID;
			}
			set
			{
				if (_weaponDataTargetHitBBID == value)
				{
					return;
				}
				_weaponDataTargetHitBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("shootAnimationName")] 
		public CName ShootAnimationName
		{
			get
			{
				if (_shootAnimationName == null)
				{
					_shootAnimationName = (CName) CR2WTypeManager.Create("CName", "shootAnimationName", cr2w, this);
				}
				return _shootAnimationName;
			}
			set
			{
				if (_shootAnimationName == value)
				{
					return;
				}
				_shootAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("shootAnimation")] 
		public CHandle<inkanimProxy> ShootAnimation
		{
			get
			{
				if (_shootAnimation == null)
				{
					_shootAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "shootAnimation", cr2w, this);
				}
				return _shootAnimation;
			}
			set
			{
				if (_shootAnimation == value)
				{
					return;
				}
				_shootAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("weaponDataShootBBID")] 
		public CUInt32 WeaponDataShootBBID
		{
			get
			{
				if (_weaponDataShootBBID == null)
				{
					_weaponDataShootBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponDataShootBBID", cr2w, this);
				}
				return _weaponDataShootBBID;
			}
			set
			{
				if (_weaponDataShootBBID == value)
				{
					return;
				}
				_weaponDataShootBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get
			{
				if (_currentAmmo == null)
				{
					_currentAmmo = (CInt32) CR2WTypeManager.Create("Int32", "currentAmmo", cr2w, this);
				}
				return _currentAmmo;
			}
			set
			{
				if (_currentAmmo == value)
				{
					return;
				}
				_currentAmmo = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animIntro")] 
		public CHandle<inkanimProxy> AnimIntro
		{
			get
			{
				if (_animIntro == null)
				{
					_animIntro = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animIntro", cr2w, this);
				}
				return _animIntro;
			}
			set
			{
				if (_animIntro == value)
				{
					return;
				}
				_animIntro = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get
			{
				if (_animLoop == null)
				{
					_animLoop = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animLoop", cr2w, this);
				}
				return _animLoop;
			}
			set
			{
				if (_animLoop == value)
				{
					return;
				}
				_animLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("animReload")] 
		public CHandle<inkanimProxy> AnimReload
		{
			get
			{
				if (_animReload == null)
				{
					_animReload = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animReload", cr2w, this);
				}
				return _animReload;
			}
			set
			{
				if (_animReload == value)
				{
					return;
				}
				_animReload = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get
			{
				if (_bufferedRosterData == null)
				{
					_bufferedRosterData = (CHandle<gameSlotDataHolder>) CR2WTypeManager.Create("handle:gameSlotDataHolder", "BufferedRosterData", cr2w, this);
				}
				return _bufferedRosterData;
			}
			set
			{
				if (_bufferedRosterData == value)
				{
					return;
				}
				_bufferedRosterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get
			{
				if (_activeWeapon == null)
				{
					_activeWeapon = (gameSlotWeaponData) CR2WTypeManager.Create("gameSlotWeaponData", "ActiveWeapon", cr2w, this);
				}
				return _activeWeapon;
			}
			set
			{
				if (_activeWeapon == value)
				{
					return;
				}
				_activeWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("weaponItemData")] 
		public InventoryItemData WeaponItemData
		{
			get
			{
				if (_weaponItemData == null)
				{
					_weaponItemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "weaponItemData", cr2w, this);
				}
				return _weaponItemData;
			}
			set
			{
				if (_weaponItemData == value)
				{
					return;
				}
				_weaponItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get
			{
				if (_bb == null)
				{
					_bb = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bb", cr2w, this);
				}
				return _bb;
			}
			set
			{
				if (_bb == value)
				{
					return;
				}
				_bb = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("bbID")] 
		public CUInt32 BbID
		{
			get
			{
				if (_bbID == null)
				{
					_bbID = (CUInt32) CR2WTypeManager.Create("Uint32", "bbID", cr2w, this);
				}
				return _bbID;
			}
			set
			{
				if (_bbID == value)
				{
					return;
				}
				_bbID = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("targetBB")] 
		public wCHandle<gameIBlackboard> TargetBB
		{
			get
			{
				if (_targetBB == null)
				{
					_targetBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "targetBB", cr2w, this);
				}
				return _targetBB;
			}
			set
			{
				if (_targetBB == value)
				{
					return;
				}
				_targetBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("targetRange")] 
		public CFloat TargetRange
		{
			get
			{
				if (_targetRange == null)
				{
					_targetRange = (CFloat) CR2WTypeManager.Create("Float", "targetRange", cr2w, this);
				}
				return _targetRange;
			}
			set
			{
				if (_targetRange == value)
				{
					return;
				}
				_targetRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("targetRangeBBID")] 
		public CUInt32 TargetRangeBBID
		{
			get
			{
				if (_targetRangeBBID == null)
				{
					_targetRangeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetRangeBBID", cr2w, this);
				}
				return _targetRangeBBID;
			}
			set
			{
				if (_targetRangeBBID == value)
				{
					return;
				}
				_targetRangeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("targetAttitudeBBID")] 
		public CUInt32 TargetAttitudeBBID
		{
			get
			{
				if (_targetAttitudeBBID == null)
				{
					_targetAttitudeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetAttitudeBBID", cr2w, this);
				}
				return _targetAttitudeBBID;
			}
			set
			{
				if (_targetAttitudeBBID == value)
				{
					return;
				}
				_targetAttitudeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("targetAcquiredBBID")] 
		public CUInt32 TargetAcquiredBBID
		{
			get
			{
				if (_targetAcquiredBBID == null)
				{
					_targetAcquiredBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetAcquiredBBID", cr2w, this);
				}
				return _targetAcquiredBBID;
			}
			set
			{
				if (_targetAcquiredBBID == value)
				{
					return;
				}
				_targetAcquiredBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("targetRangeObstructedBBID")] 
		public CUInt32 TargetRangeObstructedBBID
		{
			get
			{
				if (_targetRangeObstructedBBID == null)
				{
					_targetRangeObstructedBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetRangeObstructedBBID", cr2w, this);
				}
				return _targetRangeObstructedBBID;
			}
			set
			{
				if (_targetRangeObstructedBBID == value)
				{
					return;
				}
				_targetRangeObstructedBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("targetAcquiredObstructedBBID")] 
		public CUInt32 TargetAcquiredObstructedBBID
		{
			get
			{
				if (_targetAcquiredObstructedBBID == null)
				{
					_targetAcquiredObstructedBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetAcquiredObstructedBBID", cr2w, this);
				}
				return _targetAcquiredObstructedBBID;
			}
			set
			{
				if (_targetAcquiredObstructedBBID == value)
				{
					return;
				}
				_targetAcquiredObstructedBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("targetRangeDecimalPrecision")] 
		public CUInt32 TargetRangeDecimalPrecision
		{
			get
			{
				if (_targetRangeDecimalPrecision == null)
				{
					_targetRangeDecimalPrecision = (CUInt32) CR2WTypeManager.Create("Uint32", "targetRangeDecimalPrecision", cr2w, this);
				}
				return _targetRangeDecimalPrecision;
			}
			set
			{
				if (_targetRangeDecimalPrecision == value)
				{
					return;
				}
				_targetRangeDecimalPrecision = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("targetAttitudeAnimator")] 
		public wCHandle<TargetAttitudeAnimationController> TargetAttitudeAnimator
		{
			get
			{
				if (_targetAttitudeAnimator == null)
				{
					_targetAttitudeAnimator = (wCHandle<TargetAttitudeAnimationController>) CR2WTypeManager.Create("whandle:TargetAttitudeAnimationController", "targetAttitudeAnimator", cr2w, this);
				}
				return _targetAttitudeAnimator;
			}
			set
			{
				if (_targetAttitudeAnimator == value)
				{
					return;
				}
				_targetAttitudeAnimator = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("targetAttitudeContainer")] 
		public inkWidgetReference TargetAttitudeContainer
		{
			get
			{
				if (_targetAttitudeContainer == null)
				{
					_targetAttitudeContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetAttitudeContainer", cr2w, this);
				}
				return _targetAttitudeContainer;
			}
			set
			{
				if (_targetAttitudeContainer == value)
				{
					return;
				}
				_targetAttitudeContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("targetHealthListener")] 
		public CHandle<IronsightTargetHealthChangeListener> TargetHealthListener
		{
			get
			{
				if (_targetHealthListener == null)
				{
					_targetHealthListener = (CHandle<IronsightTargetHealthChangeListener>) CR2WTypeManager.Create("handle:IronsightTargetHealthChangeListener", "targetHealthListener", cr2w, this);
				}
				return _targetHealthListener;
			}
			set
			{
				if (_targetHealthListener == value)
				{
					return;
				}
				_targetHealthListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("compass")] 
		public wCHandle<CompassController> Compass
		{
			get
			{
				if (_compass == null)
				{
					_compass = (wCHandle<CompassController>) CR2WTypeManager.Create("whandle:CompassController", "compass", cr2w, this);
				}
				return _compass;
			}
			set
			{
				if (_compass == value)
				{
					return;
				}
				_compass = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("compassContainer")] 
		public inkWidgetReference CompassContainer
		{
			get
			{
				if (_compassContainer == null)
				{
					_compassContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "compassContainer", cr2w, this);
				}
				return _compassContainer;
			}
			set
			{
				if (_compassContainer == value)
				{
					return;
				}
				_compassContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("compass2")] 
		public wCHandle<CompassController> Compass2
		{
			get
			{
				if (_compass2 == null)
				{
					_compass2 = (wCHandle<CompassController>) CR2WTypeManager.Create("whandle:CompassController", "compass2", cr2w, this);
				}
				return _compass2;
			}
			set
			{
				if (_compass2 == value)
				{
					return;
				}
				_compass2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("compassContainer2")] 
		public inkWidgetReference CompassContainer2
		{
			get
			{
				if (_compassContainer2 == null)
				{
					_compassContainer2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "compassContainer2", cr2w, this);
				}
				return _compassContainer2;
			}
			set
			{
				if (_compassContainer2 == value)
				{
					return;
				}
				_compassContainer2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("altimeter")] 
		public wCHandle<AltimeterController> Altimeter
		{
			get
			{
				if (_altimeter == null)
				{
					_altimeter = (wCHandle<AltimeterController>) CR2WTypeManager.Create("whandle:AltimeterController", "altimeter", cr2w, this);
				}
				return _altimeter;
			}
			set
			{
				if (_altimeter == value)
				{
					return;
				}
				_altimeter = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("altimeterContainer")] 
		public inkWidgetReference AltimeterContainer
		{
			get
			{
				if (_altimeterContainer == null)
				{
					_altimeterContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "altimeterContainer", cr2w, this);
				}
				return _altimeterContainer;
			}
			set
			{
				if (_altimeterContainer == value)
				{
					return;
				}
				_altimeterContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("weaponBB")] 
		public wCHandle<gameIBlackboard> WeaponBB
		{
			get
			{
				if (_weaponBB == null)
				{
					_weaponBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "weaponBB", cr2w, this);
				}
				return _weaponBB;
			}
			set
			{
				if (_weaponBB == value)
				{
					return;
				}
				_weaponBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("chargebar")] 
		public wCHandle<ChargebarController> Chargebar
		{
			get
			{
				if (_chargebar == null)
				{
					_chargebar = (wCHandle<ChargebarController>) CR2WTypeManager.Create("whandle:ChargebarController", "chargebar", cr2w, this);
				}
				return _chargebar;
			}
			set
			{
				if (_chargebar == value)
				{
					return;
				}
				_chargebar = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("chargebarContainer")] 
		public inkWidgetReference ChargebarContainer
		{
			get
			{
				if (_chargebarContainer == null)
				{
					_chargebarContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "chargebarContainer", cr2w, this);
				}
				return _chargebarContainer;
			}
			set
			{
				if (_chargebarContainer == value)
				{
					return;
				}
				_chargebarContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("chargebarValueChanged")] 
		public CUInt32 ChargebarValueChanged
		{
			get
			{
				if (_chargebarValueChanged == null)
				{
					_chargebarValueChanged = (CUInt32) CR2WTypeManager.Create("Uint32", "chargebarValueChanged", cr2w, this);
				}
				return _chargebarValueChanged;
			}
			set
			{
				if (_chargebarValueChanged == value)
				{
					return;
				}
				_chargebarValueChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("chargebarTriggerModeChanged")] 
		public CUInt32 ChargebarTriggerModeChanged
		{
			get
			{
				if (_chargebarTriggerModeChanged == null)
				{
					_chargebarTriggerModeChanged = (CUInt32) CR2WTypeManager.Create("Uint32", "chargebarTriggerModeChanged", cr2w, this);
				}
				return _chargebarTriggerModeChanged;
			}
			set
			{
				if (_chargebarTriggerModeChanged == value)
				{
					return;
				}
				_chargebarTriggerModeChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("ADSContainer")] 
		public inkWidgetReference ADSContainer
		{
			get
			{
				if (_aDSContainer == null)
				{
					_aDSContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ADSContainer", cr2w, this);
				}
				return _aDSContainer;
			}
			set
			{
				if (_aDSContainer == value)
				{
					return;
				}
				_aDSContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("ADSAnimator")] 
		public wCHandle<AimDownSightController> ADSAnimator
		{
			get
			{
				if (_aDSAnimator == null)
				{
					_aDSAnimator = (wCHandle<AimDownSightController>) CR2WTypeManager.Create("whandle:AimDownSightController", "ADSAnimator", cr2w, this);
				}
				return _aDSAnimator;
			}
			set
			{
				if (_aDSAnimator == value)
				{
					return;
				}
				_aDSAnimator = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("playerStateMachineBB")] 
		public CHandle<gameIBlackboard> PlayerStateMachineBB
		{
			get
			{
				if (_playerStateMachineBB == null)
				{
					_playerStateMachineBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStateMachineBB", cr2w, this);
				}
				return _playerStateMachineBB;
			}
			set
			{
				if (_playerStateMachineBB == value)
				{
					return;
				}
				_playerStateMachineBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("playerStateMachineUpperBodyBBID")] 
		public CUInt32 PlayerStateMachineUpperBodyBBID
		{
			get
			{
				if (_playerStateMachineUpperBodyBBID == null)
				{
					_playerStateMachineUpperBodyBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerStateMachineUpperBodyBBID", cr2w, this);
				}
				return _playerStateMachineUpperBodyBBID;
			}
			set
			{
				if (_playerStateMachineUpperBodyBBID == value)
				{
					return;
				}
				_playerStateMachineUpperBodyBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("crosshairStateChanged")] 
		public CUInt32 CrosshairStateChanged
		{
			get
			{
				if (_crosshairStateChanged == null)
				{
					_crosshairStateChanged = (CUInt32) CR2WTypeManager.Create("Uint32", "crosshairStateChanged", cr2w, this);
				}
				return _crosshairStateChanged;
			}
			set
			{
				if (_crosshairStateChanged == value)
				{
					return;
				}
				_crosshairStateChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get
			{
				if (_crosshairState == null)
				{
					_crosshairState = (CEnum<gamePSMCrosshairStates>) CR2WTypeManager.Create("gamePSMCrosshairStates", "crosshairState", cr2w, this);
				}
				return _crosshairState;
			}
			set
			{
				if (_crosshairState == value)
				{
					return;
				}
				_crosshairState = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("isTargetEnemy")] 
		public CBool IsTargetEnemy
		{
			get
			{
				if (_isTargetEnemy == null)
				{
					_isTargetEnemy = (CBool) CR2WTypeManager.Create("Bool", "isTargetEnemy", cr2w, this);
				}
				return _isTargetEnemy;
			}
			set
			{
				if (_isTargetEnemy == value)
				{
					return;
				}
				_isTargetEnemy = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (CEnum<EAIAttitude>) CR2WTypeManager.Create("EAIAttitude", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		public IronsightGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

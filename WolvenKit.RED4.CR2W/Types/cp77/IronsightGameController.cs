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
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(3)] 
		[RED("dot")] 
		public inkWidgetReference Dot
		{
			get => GetProperty(ref _dot);
			set => SetProperty(ref _dot, value);
		}

		[Ordinal(4)] 
		[RED("ammo")] 
		public inkTextWidgetReference Ammo
		{
			get => GetProperty(ref _ammo);
			set => SetProperty(ref _ammo, value);
		}

		[Ordinal(5)] 
		[RED("ammoSpareCount")] 
		public inkTextWidgetReference AmmoSpareCount
		{
			get => GetProperty(ref _ammoSpareCount);
			set => SetProperty(ref _ammoSpareCount, value);
		}

		[Ordinal(6)] 
		[RED("range")] 
		public inkTextWidgetReference Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(7)] 
		[RED("seeThroughWalls")] 
		public CBool SeeThroughWalls
		{
			get => GetProperty(ref _seeThroughWalls);
			set => SetProperty(ref _seeThroughWalls, value);
		}

		[Ordinal(8)] 
		[RED("targetAttitudeFriendly")] 
		public inkWidgetReference TargetAttitudeFriendly
		{
			get => GetProperty(ref _targetAttitudeFriendly);
			set => SetProperty(ref _targetAttitudeFriendly, value);
		}

		[Ordinal(9)] 
		[RED("targetAttitudeHostile")] 
		public inkWidgetReference TargetAttitudeHostile
		{
			get => GetProperty(ref _targetAttitudeHostile);
			set => SetProperty(ref _targetAttitudeHostile, value);
		}

		[Ordinal(10)] 
		[RED("targetAttitudeEnemyNonHostile")] 
		public inkWidgetReference TargetAttitudeEnemyNonHostile
		{
			get => GetProperty(ref _targetAttitudeEnemyNonHostile);
			set => SetProperty(ref _targetAttitudeEnemyNonHostile, value);
		}

		[Ordinal(11)] 
		[RED("weaponDataBB")] 
		public CHandle<gameIBlackboard> WeaponDataBB
		{
			get => GetProperty(ref _weaponDataBB);
			set => SetProperty(ref _weaponDataBB, value);
		}

		[Ordinal(12)] 
		[RED("targetHitAnimationName")] 
		public CName TargetHitAnimationName
		{
			get => GetProperty(ref _targetHitAnimationName);
			set => SetProperty(ref _targetHitAnimationName, value);
		}

		[Ordinal(13)] 
		[RED("targetHitAnimation")] 
		public CHandle<inkanimProxy> TargetHitAnimation
		{
			get => GetProperty(ref _targetHitAnimation);
			set => SetProperty(ref _targetHitAnimation, value);
		}

		[Ordinal(14)] 
		[RED("weaponDataTargetHitBBID")] 
		public CUInt32 WeaponDataTargetHitBBID
		{
			get => GetProperty(ref _weaponDataTargetHitBBID);
			set => SetProperty(ref _weaponDataTargetHitBBID, value);
		}

		[Ordinal(15)] 
		[RED("shootAnimationName")] 
		public CName ShootAnimationName
		{
			get => GetProperty(ref _shootAnimationName);
			set => SetProperty(ref _shootAnimationName, value);
		}

		[Ordinal(16)] 
		[RED("shootAnimation")] 
		public CHandle<inkanimProxy> ShootAnimation
		{
			get => GetProperty(ref _shootAnimation);
			set => SetProperty(ref _shootAnimation, value);
		}

		[Ordinal(17)] 
		[RED("weaponDataShootBBID")] 
		public CUInt32 WeaponDataShootBBID
		{
			get => GetProperty(ref _weaponDataShootBBID);
			set => SetProperty(ref _weaponDataShootBBID, value);
		}

		[Ordinal(18)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get => GetProperty(ref _currentAmmo);
			set => SetProperty(ref _currentAmmo, value);
		}

		[Ordinal(19)] 
		[RED("animIntro")] 
		public CHandle<inkanimProxy> AnimIntro
		{
			get => GetProperty(ref _animIntro);
			set => SetProperty(ref _animIntro, value);
		}

		[Ordinal(20)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get => GetProperty(ref _animLoop);
			set => SetProperty(ref _animLoop, value);
		}

		[Ordinal(21)] 
		[RED("animReload")] 
		public CHandle<inkanimProxy> AnimReload
		{
			get => GetProperty(ref _animReload);
			set => SetProperty(ref _animReload, value);
		}

		[Ordinal(22)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetProperty(ref _bufferedRosterData);
			set => SetProperty(ref _bufferedRosterData, value);
		}

		[Ordinal(23)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(24)] 
		[RED("weaponItemData")] 
		public InventoryItemData WeaponItemData
		{
			get => GetProperty(ref _weaponItemData);
			set => SetProperty(ref _weaponItemData, value);
		}

		[Ordinal(25)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(26)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		[Ordinal(27)] 
		[RED("bbID")] 
		public CUInt32 BbID
		{
			get => GetProperty(ref _bbID);
			set => SetProperty(ref _bbID, value);
		}

		[Ordinal(28)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(29)] 
		[RED("targetBB")] 
		public wCHandle<gameIBlackboard> TargetBB
		{
			get => GetProperty(ref _targetBB);
			set => SetProperty(ref _targetBB, value);
		}

		[Ordinal(30)] 
		[RED("targetRange")] 
		public CFloat TargetRange
		{
			get => GetProperty(ref _targetRange);
			set => SetProperty(ref _targetRange, value);
		}

		[Ordinal(31)] 
		[RED("targetRangeBBID")] 
		public CUInt32 TargetRangeBBID
		{
			get => GetProperty(ref _targetRangeBBID);
			set => SetProperty(ref _targetRangeBBID, value);
		}

		[Ordinal(32)] 
		[RED("targetAttitudeBBID")] 
		public CUInt32 TargetAttitudeBBID
		{
			get => GetProperty(ref _targetAttitudeBBID);
			set => SetProperty(ref _targetAttitudeBBID, value);
		}

		[Ordinal(33)] 
		[RED("targetAcquiredBBID")] 
		public CUInt32 TargetAcquiredBBID
		{
			get => GetProperty(ref _targetAcquiredBBID);
			set => SetProperty(ref _targetAcquiredBBID, value);
		}

		[Ordinal(34)] 
		[RED("targetRangeObstructedBBID")] 
		public CUInt32 TargetRangeObstructedBBID
		{
			get => GetProperty(ref _targetRangeObstructedBBID);
			set => SetProperty(ref _targetRangeObstructedBBID, value);
		}

		[Ordinal(35)] 
		[RED("targetAcquiredObstructedBBID")] 
		public CUInt32 TargetAcquiredObstructedBBID
		{
			get => GetProperty(ref _targetAcquiredObstructedBBID);
			set => SetProperty(ref _targetAcquiredObstructedBBID, value);
		}

		[Ordinal(36)] 
		[RED("targetRangeDecimalPrecision")] 
		public CUInt32 TargetRangeDecimalPrecision
		{
			get => GetProperty(ref _targetRangeDecimalPrecision);
			set => SetProperty(ref _targetRangeDecimalPrecision, value);
		}

		[Ordinal(37)] 
		[RED("targetAttitudeAnimator")] 
		public wCHandle<TargetAttitudeAnimationController> TargetAttitudeAnimator
		{
			get => GetProperty(ref _targetAttitudeAnimator);
			set => SetProperty(ref _targetAttitudeAnimator, value);
		}

		[Ordinal(38)] 
		[RED("targetAttitudeContainer")] 
		public inkWidgetReference TargetAttitudeContainer
		{
			get => GetProperty(ref _targetAttitudeContainer);
			set => SetProperty(ref _targetAttitudeContainer, value);
		}

		[Ordinal(39)] 
		[RED("targetHealthListener")] 
		public CHandle<IronsightTargetHealthChangeListener> TargetHealthListener
		{
			get => GetProperty(ref _targetHealthListener);
			set => SetProperty(ref _targetHealthListener, value);
		}

		[Ordinal(40)] 
		[RED("compass")] 
		public wCHandle<CompassController> Compass
		{
			get => GetProperty(ref _compass);
			set => SetProperty(ref _compass, value);
		}

		[Ordinal(41)] 
		[RED("compassContainer")] 
		public inkWidgetReference CompassContainer
		{
			get => GetProperty(ref _compassContainer);
			set => SetProperty(ref _compassContainer, value);
		}

		[Ordinal(42)] 
		[RED("compass2")] 
		public wCHandle<CompassController> Compass2
		{
			get => GetProperty(ref _compass2);
			set => SetProperty(ref _compass2, value);
		}

		[Ordinal(43)] 
		[RED("compassContainer2")] 
		public inkWidgetReference CompassContainer2
		{
			get => GetProperty(ref _compassContainer2);
			set => SetProperty(ref _compassContainer2, value);
		}

		[Ordinal(44)] 
		[RED("altimeter")] 
		public wCHandle<AltimeterController> Altimeter
		{
			get => GetProperty(ref _altimeter);
			set => SetProperty(ref _altimeter, value);
		}

		[Ordinal(45)] 
		[RED("altimeterContainer")] 
		public inkWidgetReference AltimeterContainer
		{
			get => GetProperty(ref _altimeterContainer);
			set => SetProperty(ref _altimeterContainer, value);
		}

		[Ordinal(46)] 
		[RED("weaponBB")] 
		public wCHandle<gameIBlackboard> WeaponBB
		{
			get => GetProperty(ref _weaponBB);
			set => SetProperty(ref _weaponBB, value);
		}

		[Ordinal(47)] 
		[RED("chargebar")] 
		public wCHandle<ChargebarController> Chargebar
		{
			get => GetProperty(ref _chargebar);
			set => SetProperty(ref _chargebar, value);
		}

		[Ordinal(48)] 
		[RED("chargebarContainer")] 
		public inkWidgetReference ChargebarContainer
		{
			get => GetProperty(ref _chargebarContainer);
			set => SetProperty(ref _chargebarContainer, value);
		}

		[Ordinal(49)] 
		[RED("chargebarValueChanged")] 
		public CUInt32 ChargebarValueChanged
		{
			get => GetProperty(ref _chargebarValueChanged);
			set => SetProperty(ref _chargebarValueChanged, value);
		}

		[Ordinal(50)] 
		[RED("chargebarTriggerModeChanged")] 
		public CUInt32 ChargebarTriggerModeChanged
		{
			get => GetProperty(ref _chargebarTriggerModeChanged);
			set => SetProperty(ref _chargebarTriggerModeChanged, value);
		}

		[Ordinal(51)] 
		[RED("ADSContainer")] 
		public inkWidgetReference ADSContainer
		{
			get => GetProperty(ref _aDSContainer);
			set => SetProperty(ref _aDSContainer, value);
		}

		[Ordinal(52)] 
		[RED("ADSAnimator")] 
		public wCHandle<AimDownSightController> ADSAnimator
		{
			get => GetProperty(ref _aDSAnimator);
			set => SetProperty(ref _aDSAnimator, value);
		}

		[Ordinal(53)] 
		[RED("playerStateMachineBB")] 
		public CHandle<gameIBlackboard> PlayerStateMachineBB
		{
			get => GetProperty(ref _playerStateMachineBB);
			set => SetProperty(ref _playerStateMachineBB, value);
		}

		[Ordinal(54)] 
		[RED("playerStateMachineUpperBodyBBID")] 
		public CUInt32 PlayerStateMachineUpperBodyBBID
		{
			get => GetProperty(ref _playerStateMachineUpperBodyBBID);
			set => SetProperty(ref _playerStateMachineUpperBodyBBID, value);
		}

		[Ordinal(55)] 
		[RED("crosshairStateChanged")] 
		public CUInt32 CrosshairStateChanged
		{
			get => GetProperty(ref _crosshairStateChanged);
			set => SetProperty(ref _crosshairStateChanged, value);
		}

		[Ordinal(56)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetProperty(ref _crosshairState);
			set => SetProperty(ref _crosshairState, value);
		}

		[Ordinal(57)] 
		[RED("isTargetEnemy")] 
		public CBool IsTargetEnemy
		{
			get => GetProperty(ref _isTargetEnemy);
			set => SetProperty(ref _isTargetEnemy, value);
		}

		[Ordinal(58)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		public IronsightGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

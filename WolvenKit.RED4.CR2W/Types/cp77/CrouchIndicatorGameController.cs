using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrouchIndicatorGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _currentAmmoRef;
		private inkTextWidgetReference _allAmmoRef;
		private inkWidgetReference _ammoWrapper;
		private inkWidgetReference _container;
		private inkWidgetReference _warningMessageWraper;
		private inkCompoundWidgetReference _smartLinkFirmwareOnline;
		private inkCompoundWidgetReference _smartLinkFirmwareOffline;
		private inkImageWidgetReference _weaponIcon;
		private CArray<inkImageWidgetReference> _fireModes;
		private CArray<inkImageWidgetReference> _weaponMods;
		private inkWidgetReference _modHolder;
		private inkTextWidgetReference _weaponName;
		private inkWidgetReference _damageTypeRef;
		private inkImageWidgetReference _crouchIcon;
		private CBool _folded;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private InventoryItemData _weaponItemData;
		private wCHandle<DamageTypeIndicator> _damageTypeIndicator;
		private CArray<CEnum<gamedataItemType>> _weaponAreas;
		private CUInt32 _bBWeaponList;
		private CUInt32 _bBAmmoLooted;
		private CUInt32 _bBCurrentWeapon;
		private CUInt32 _locomotionStateBlackboardId;
		private CUInt32 _visionStateBlackboardId;
		private CUInt32 _uIStateBlackboardId;
		private CUInt32 _playerSpawnedCallbackID;
		private CUInt32 _ammoHackedListenerId;
		private CHandle<gameSlotDataHolder> _bufferedRosterData;
		private wCHandle<gameIBlackboard> _uIBlackboard;
		private gameSlotWeaponData _activeWeapon;
		private wCHandle<gameIBlackboard> _hackingBlackboard;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _outOfAmmoAnim;
		private CHandle<inkanimProxy> _transitionAnimProxy;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UIInteractionsDef> _bbDefinition;
		private CUInt32 _onMagazineAmmoCount;
		private CUInt32 _dataListenerId;
		private wCHandle<gameIBlackboard> _weaponBlackboard;
		private CUInt32 _weaponParamsListenerId;
		private CInt32 _bufferedMaxAmmo;
		private CInt32 _bufferedAmmoId;
		private CName _genderName;

		[Ordinal(9)] 
		[RED("CurrentAmmoRef")] 
		public inkTextWidgetReference CurrentAmmoRef
		{
			get => GetProperty(ref _currentAmmoRef);
			set => SetProperty(ref _currentAmmoRef, value);
		}

		[Ordinal(10)] 
		[RED("AllAmmoRef")] 
		public inkTextWidgetReference AllAmmoRef
		{
			get => GetProperty(ref _allAmmoRef);
			set => SetProperty(ref _allAmmoRef, value);
		}

		[Ordinal(11)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get => GetProperty(ref _ammoWrapper);
			set => SetProperty(ref _ammoWrapper, value);
		}

		[Ordinal(12)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(13)] 
		[RED("warningMessageWraper")] 
		public inkWidgetReference WarningMessageWraper
		{
			get => GetProperty(ref _warningMessageWraper);
			set => SetProperty(ref _warningMessageWraper, value);
		}

		[Ordinal(14)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetProperty(ref _smartLinkFirmwareOnline);
			set => SetProperty(ref _smartLinkFirmwareOnline, value);
		}

		[Ordinal(15)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetProperty(ref _smartLinkFirmwareOffline);
			set => SetProperty(ref _smartLinkFirmwareOffline, value);
		}

		[Ordinal(16)] 
		[RED("weaponIcon")] 
		public inkImageWidgetReference WeaponIcon
		{
			get => GetProperty(ref _weaponIcon);
			set => SetProperty(ref _weaponIcon, value);
		}

		[Ordinal(17)] 
		[RED("FireModes")] 
		public CArray<inkImageWidgetReference> FireModes
		{
			get => GetProperty(ref _fireModes);
			set => SetProperty(ref _fireModes, value);
		}

		[Ordinal(18)] 
		[RED("WeaponMods")] 
		public CArray<inkImageWidgetReference> WeaponMods
		{
			get => GetProperty(ref _weaponMods);
			set => SetProperty(ref _weaponMods, value);
		}

		[Ordinal(19)] 
		[RED("modHolder")] 
		public inkWidgetReference ModHolder
		{
			get => GetProperty(ref _modHolder);
			set => SetProperty(ref _modHolder, value);
		}

		[Ordinal(20)] 
		[RED("weaponName")] 
		public inkTextWidgetReference WeaponName
		{
			get => GetProperty(ref _weaponName);
			set => SetProperty(ref _weaponName, value);
		}

		[Ordinal(21)] 
		[RED("damageTypeRef")] 
		public inkWidgetReference DamageTypeRef
		{
			get => GetProperty(ref _damageTypeRef);
			set => SetProperty(ref _damageTypeRef, value);
		}

		[Ordinal(22)] 
		[RED("crouchIcon")] 
		public inkImageWidgetReference CrouchIcon
		{
			get => GetProperty(ref _crouchIcon);
			set => SetProperty(ref _crouchIcon, value);
		}

		[Ordinal(23)] 
		[RED("folded")] 
		public CBool Folded
		{
			get => GetProperty(ref _folded);
			set => SetProperty(ref _folded, value);
		}

		[Ordinal(24)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(25)] 
		[RED("weaponItemData")] 
		public InventoryItemData WeaponItemData
		{
			get => GetProperty(ref _weaponItemData);
			set => SetProperty(ref _weaponItemData, value);
		}

		[Ordinal(26)] 
		[RED("damageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetProperty(ref _damageTypeIndicator);
			set => SetProperty(ref _damageTypeIndicator, value);
		}

		[Ordinal(27)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetProperty(ref _weaponAreas);
			set => SetProperty(ref _weaponAreas, value);
		}

		[Ordinal(28)] 
		[RED("BBWeaponList")] 
		public CUInt32 BBWeaponList
		{
			get => GetProperty(ref _bBWeaponList);
			set => SetProperty(ref _bBWeaponList, value);
		}

		[Ordinal(29)] 
		[RED("BBAmmoLooted")] 
		public CUInt32 BBAmmoLooted
		{
			get => GetProperty(ref _bBAmmoLooted);
			set => SetProperty(ref _bBAmmoLooted, value);
		}

		[Ordinal(30)] 
		[RED("BBCurrentWeapon")] 
		public CUInt32 BBCurrentWeapon
		{
			get => GetProperty(ref _bBCurrentWeapon);
			set => SetProperty(ref _bBCurrentWeapon, value);
		}

		[Ordinal(31)] 
		[RED("LocomotionStateBlackboardId")] 
		public CUInt32 LocomotionStateBlackboardId
		{
			get => GetProperty(ref _locomotionStateBlackboardId);
			set => SetProperty(ref _locomotionStateBlackboardId, value);
		}

		[Ordinal(32)] 
		[RED("VisionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		[Ordinal(33)] 
		[RED("UIStateBlackboardId")] 
		public CUInt32 UIStateBlackboardId
		{
			get => GetProperty(ref _uIStateBlackboardId);
			set => SetProperty(ref _uIStateBlackboardId, value);
		}

		[Ordinal(34)] 
		[RED("PlayerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get => GetProperty(ref _playerSpawnedCallbackID);
			set => SetProperty(ref _playerSpawnedCallbackID, value);
		}

		[Ordinal(35)] 
		[RED("ammoHackedListenerId")] 
		public CUInt32 AmmoHackedListenerId
		{
			get => GetProperty(ref _ammoHackedListenerId);
			set => SetProperty(ref _ammoHackedListenerId, value);
		}

		[Ordinal(36)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetProperty(ref _bufferedRosterData);
			set => SetProperty(ref _bufferedRosterData, value);
		}

		[Ordinal(37)] 
		[RED("UIBlackboard")] 
		public wCHandle<gameIBlackboard> UIBlackboard
		{
			get => GetProperty(ref _uIBlackboard);
			set => SetProperty(ref _uIBlackboard, value);
		}

		[Ordinal(38)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(39)] 
		[RED("hackingBlackboard")] 
		public wCHandle<gameIBlackboard> HackingBlackboard
		{
			get => GetProperty(ref _hackingBlackboard);
			set => SetProperty(ref _hackingBlackboard, value);
		}

		[Ordinal(40)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(41)] 
		[RED("outOfAmmoAnim")] 
		public CHandle<inkanimProxy> OutOfAmmoAnim
		{
			get => GetProperty(ref _outOfAmmoAnim);
			set => SetProperty(ref _outOfAmmoAnim, value);
		}

		[Ordinal(42)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetProperty(ref _transitionAnimProxy);
			set => SetProperty(ref _transitionAnimProxy, value);
		}

		[Ordinal(43)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(44)] 
		[RED("bbDefinition")] 
		public CHandle<UIInteractionsDef> BbDefinition
		{
			get => GetProperty(ref _bbDefinition);
			set => SetProperty(ref _bbDefinition, value);
		}

		[Ordinal(45)] 
		[RED("onMagazineAmmoCount")] 
		public CUInt32 OnMagazineAmmoCount
		{
			get => GetProperty(ref _onMagazineAmmoCount);
			set => SetProperty(ref _onMagazineAmmoCount, value);
		}

		[Ordinal(46)] 
		[RED("dataListenerId")] 
		public CUInt32 DataListenerId
		{
			get => GetProperty(ref _dataListenerId);
			set => SetProperty(ref _dataListenerId, value);
		}

		[Ordinal(47)] 
		[RED("weaponBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetProperty(ref _weaponBlackboard);
			set => SetProperty(ref _weaponBlackboard, value);
		}

		[Ordinal(48)] 
		[RED("weaponParamsListenerId")] 
		public CUInt32 WeaponParamsListenerId
		{
			get => GetProperty(ref _weaponParamsListenerId);
			set => SetProperty(ref _weaponParamsListenerId, value);
		}

		[Ordinal(49)] 
		[RED("bufferedMaxAmmo")] 
		public CInt32 BufferedMaxAmmo
		{
			get => GetProperty(ref _bufferedMaxAmmo);
			set => SetProperty(ref _bufferedMaxAmmo, value);
		}

		[Ordinal(50)] 
		[RED("bufferedAmmoId")] 
		public CInt32 BufferedAmmoId
		{
			get => GetProperty(ref _bufferedAmmoId);
			set => SetProperty(ref _bufferedAmmoId, value);
		}

		[Ordinal(51)] 
		[RED("genderName")] 
		public CName GenderName
		{
			get => GetProperty(ref _genderName);
			set => SetProperty(ref _genderName, value);
		}

		public CrouchIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

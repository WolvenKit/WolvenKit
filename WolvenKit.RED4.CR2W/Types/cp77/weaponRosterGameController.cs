using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class weaponRosterGameController : gameuiHUDGameController
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
		private CHandle<gameIBlackboard> _hackingBlackboard;
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
			get
			{
				if (_currentAmmoRef == null)
				{
					_currentAmmoRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CurrentAmmoRef", cr2w, this);
				}
				return _currentAmmoRef;
			}
			set
			{
				if (_currentAmmoRef == value)
				{
					return;
				}
				_currentAmmoRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("AllAmmoRef")] 
		public inkTextWidgetReference AllAmmoRef
		{
			get
			{
				if (_allAmmoRef == null)
				{
					_allAmmoRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "AllAmmoRef", cr2w, this);
				}
				return _allAmmoRef;
			}
			set
			{
				if (_allAmmoRef == value)
				{
					return;
				}
				_allAmmoRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get
			{
				if (_ammoWrapper == null)
				{
					_ammoWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ammoWrapper", cr2w, this);
				}
				return _ammoWrapper;
			}
			set
			{
				if (_ammoWrapper == value)
				{
					return;
				}
				_ammoWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("warningMessageWraper")] 
		public inkWidgetReference WarningMessageWraper
		{
			get
			{
				if (_warningMessageWraper == null)
				{
					_warningMessageWraper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "warningMessageWraper", cr2w, this);
				}
				return _warningMessageWraper;
			}
			set
			{
				if (_warningMessageWraper == value)
				{
					return;
				}
				_warningMessageWraper = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get
			{
				if (_smartLinkFirmwareOnline == null)
				{
					_smartLinkFirmwareOnline = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkFirmwareOnline", cr2w, this);
				}
				return _smartLinkFirmwareOnline;
			}
			set
			{
				if (_smartLinkFirmwareOnline == value)
				{
					return;
				}
				_smartLinkFirmwareOnline = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get
			{
				if (_smartLinkFirmwareOffline == null)
				{
					_smartLinkFirmwareOffline = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkFirmwareOffline", cr2w, this);
				}
				return _smartLinkFirmwareOffline;
			}
			set
			{
				if (_smartLinkFirmwareOffline == value)
				{
					return;
				}
				_smartLinkFirmwareOffline = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("weaponIcon")] 
		public inkImageWidgetReference WeaponIcon
		{
			get
			{
				if (_weaponIcon == null)
				{
					_weaponIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "weaponIcon", cr2w, this);
				}
				return _weaponIcon;
			}
			set
			{
				if (_weaponIcon == value)
				{
					return;
				}
				_weaponIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("FireModes")] 
		public CArray<inkImageWidgetReference> FireModes
		{
			get
			{
				if (_fireModes == null)
				{
					_fireModes = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "FireModes", cr2w, this);
				}
				return _fireModes;
			}
			set
			{
				if (_fireModes == value)
				{
					return;
				}
				_fireModes = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("WeaponMods")] 
		public CArray<inkImageWidgetReference> WeaponMods
		{
			get
			{
				if (_weaponMods == null)
				{
					_weaponMods = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "WeaponMods", cr2w, this);
				}
				return _weaponMods;
			}
			set
			{
				if (_weaponMods == value)
				{
					return;
				}
				_weaponMods = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("modHolder")] 
		public inkWidgetReference ModHolder
		{
			get
			{
				if (_modHolder == null)
				{
					_modHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "modHolder", cr2w, this);
				}
				return _modHolder;
			}
			set
			{
				if (_modHolder == value)
				{
					return;
				}
				_modHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("weaponName")] 
		public inkTextWidgetReference WeaponName
		{
			get
			{
				if (_weaponName == null)
				{
					_weaponName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weaponName", cr2w, this);
				}
				return _weaponName;
			}
			set
			{
				if (_weaponName == value)
				{
					return;
				}
				_weaponName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("damageTypeRef")] 
		public inkWidgetReference DamageTypeRef
		{
			get
			{
				if (_damageTypeRef == null)
				{
					_damageTypeRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageTypeRef", cr2w, this);
				}
				return _damageTypeRef;
			}
			set
			{
				if (_damageTypeRef == value)
				{
					return;
				}
				_damageTypeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("crouchIcon")] 
		public inkImageWidgetReference CrouchIcon
		{
			get
			{
				if (_crouchIcon == null)
				{
					_crouchIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "crouchIcon", cr2w, this);
				}
				return _crouchIcon;
			}
			set
			{
				if (_crouchIcon == value)
				{
					return;
				}
				_crouchIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("folded")] 
		public CBool Folded
		{
			get
			{
				if (_folded == null)
				{
					_folded = (CBool) CR2WTypeManager.Create("Bool", "folded", cr2w, this);
				}
				return _folded;
			}
			set
			{
				if (_folded == value)
				{
					return;
				}
				_folded = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
		[RED("damageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get
			{
				if (_damageTypeIndicator == null)
				{
					_damageTypeIndicator = (wCHandle<DamageTypeIndicator>) CR2WTypeManager.Create("whandle:DamageTypeIndicator", "damageTypeIndicator", cr2w, this);
				}
				return _damageTypeIndicator;
			}
			set
			{
				if (_damageTypeIndicator == value)
				{
					return;
				}
				_damageTypeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get
			{
				if (_weaponAreas == null)
				{
					_weaponAreas = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "WeaponAreas", cr2w, this);
				}
				return _weaponAreas;
			}
			set
			{
				if (_weaponAreas == value)
				{
					return;
				}
				_weaponAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("BBWeaponList")] 
		public CUInt32 BBWeaponList
		{
			get
			{
				if (_bBWeaponList == null)
				{
					_bBWeaponList = (CUInt32) CR2WTypeManager.Create("Uint32", "BBWeaponList", cr2w, this);
				}
				return _bBWeaponList;
			}
			set
			{
				if (_bBWeaponList == value)
				{
					return;
				}
				_bBWeaponList = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("BBAmmoLooted")] 
		public CUInt32 BBAmmoLooted
		{
			get
			{
				if (_bBAmmoLooted == null)
				{
					_bBAmmoLooted = (CUInt32) CR2WTypeManager.Create("Uint32", "BBAmmoLooted", cr2w, this);
				}
				return _bBAmmoLooted;
			}
			set
			{
				if (_bBAmmoLooted == value)
				{
					return;
				}
				_bBAmmoLooted = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("BBCurrentWeapon")] 
		public CUInt32 BBCurrentWeapon
		{
			get
			{
				if (_bBCurrentWeapon == null)
				{
					_bBCurrentWeapon = (CUInt32) CR2WTypeManager.Create("Uint32", "BBCurrentWeapon", cr2w, this);
				}
				return _bBCurrentWeapon;
			}
			set
			{
				if (_bBCurrentWeapon == value)
				{
					return;
				}
				_bBCurrentWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("LocomotionStateBlackboardId")] 
		public CUInt32 LocomotionStateBlackboardId
		{
			get
			{
				if (_locomotionStateBlackboardId == null)
				{
					_locomotionStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "LocomotionStateBlackboardId", cr2w, this);
				}
				return _locomotionStateBlackboardId;
			}
			set
			{
				if (_locomotionStateBlackboardId == value)
				{
					return;
				}
				_locomotionStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("VisionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get
			{
				if (_visionStateBlackboardId == null)
				{
					_visionStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "VisionStateBlackboardId", cr2w, this);
				}
				return _visionStateBlackboardId;
			}
			set
			{
				if (_visionStateBlackboardId == value)
				{
					return;
				}
				_visionStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("UIStateBlackboardId")] 
		public CUInt32 UIStateBlackboardId
		{
			get
			{
				if (_uIStateBlackboardId == null)
				{
					_uIStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "UIStateBlackboardId", cr2w, this);
				}
				return _uIStateBlackboardId;
			}
			set
			{
				if (_uIStateBlackboardId == value)
				{
					return;
				}
				_uIStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("PlayerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get
			{
				if (_playerSpawnedCallbackID == null)
				{
					_playerSpawnedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "PlayerSpawnedCallbackID", cr2w, this);
				}
				return _playerSpawnedCallbackID;
			}
			set
			{
				if (_playerSpawnedCallbackID == value)
				{
					return;
				}
				_playerSpawnedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("ammoHackedListenerId")] 
		public CUInt32 AmmoHackedListenerId
		{
			get
			{
				if (_ammoHackedListenerId == null)
				{
					_ammoHackedListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "ammoHackedListenerId", cr2w, this);
				}
				return _ammoHackedListenerId;
			}
			set
			{
				if (_ammoHackedListenerId == value)
				{
					return;
				}
				_ammoHackedListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
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

		[Ordinal(37)] 
		[RED("UIBlackboard")] 
		public wCHandle<gameIBlackboard> UIBlackboard
		{
			get
			{
				if (_uIBlackboard == null)
				{
					_uIBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "UIBlackboard", cr2w, this);
				}
				return _uIBlackboard;
			}
			set
			{
				if (_uIBlackboard == value)
				{
					return;
				}
				_uIBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
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

		[Ordinal(39)] 
		[RED("hackingBlackboard")] 
		public CHandle<gameIBlackboard> HackingBlackboard
		{
			get
			{
				if (_hackingBlackboard == null)
				{
					_hackingBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "hackingBlackboard", cr2w, this);
				}
				return _hackingBlackboard;
			}
			set
			{
				if (_hackingBlackboard == value)
				{
					return;
				}
				_hackingBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "Player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("outOfAmmoAnim")] 
		public CHandle<inkanimProxy> OutOfAmmoAnim
		{
			get
			{
				if (_outOfAmmoAnim == null)
				{
					_outOfAmmoAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "outOfAmmoAnim", cr2w, this);
				}
				return _outOfAmmoAnim;
			}
			set
			{
				if (_outOfAmmoAnim == value)
				{
					return;
				}
				_outOfAmmoAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get
			{
				if (_transitionAnimProxy == null)
				{
					_transitionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "transitionAnimProxy", cr2w, this);
				}
				return _transitionAnimProxy;
			}
			set
			{
				if (_transitionAnimProxy == value)
				{
					return;
				}
				_transitionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("bbDefinition")] 
		public CHandle<UIInteractionsDef> BbDefinition
		{
			get
			{
				if (_bbDefinition == null)
				{
					_bbDefinition = (CHandle<UIInteractionsDef>) CR2WTypeManager.Create("handle:UIInteractionsDef", "bbDefinition", cr2w, this);
				}
				return _bbDefinition;
			}
			set
			{
				if (_bbDefinition == value)
				{
					return;
				}
				_bbDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("onMagazineAmmoCount")] 
		public CUInt32 OnMagazineAmmoCount
		{
			get
			{
				if (_onMagazineAmmoCount == null)
				{
					_onMagazineAmmoCount = (CUInt32) CR2WTypeManager.Create("Uint32", "onMagazineAmmoCount", cr2w, this);
				}
				return _onMagazineAmmoCount;
			}
			set
			{
				if (_onMagazineAmmoCount == value)
				{
					return;
				}
				_onMagazineAmmoCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("dataListenerId")] 
		public CUInt32 DataListenerId
		{
			get
			{
				if (_dataListenerId == null)
				{
					_dataListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "dataListenerId", cr2w, this);
				}
				return _dataListenerId;
			}
			set
			{
				if (_dataListenerId == value)
				{
					return;
				}
				_dataListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("weaponBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponBlackboard
		{
			get
			{
				if (_weaponBlackboard == null)
				{
					_weaponBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "weaponBlackboard", cr2w, this);
				}
				return _weaponBlackboard;
			}
			set
			{
				if (_weaponBlackboard == value)
				{
					return;
				}
				_weaponBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("weaponParamsListenerId")] 
		public CUInt32 WeaponParamsListenerId
		{
			get
			{
				if (_weaponParamsListenerId == null)
				{
					_weaponParamsListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponParamsListenerId", cr2w, this);
				}
				return _weaponParamsListenerId;
			}
			set
			{
				if (_weaponParamsListenerId == value)
				{
					return;
				}
				_weaponParamsListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("bufferedMaxAmmo")] 
		public CInt32 BufferedMaxAmmo
		{
			get
			{
				if (_bufferedMaxAmmo == null)
				{
					_bufferedMaxAmmo = (CInt32) CR2WTypeManager.Create("Int32", "bufferedMaxAmmo", cr2w, this);
				}
				return _bufferedMaxAmmo;
			}
			set
			{
				if (_bufferedMaxAmmo == value)
				{
					return;
				}
				_bufferedMaxAmmo = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("bufferedAmmoId")] 
		public CInt32 BufferedAmmoId
		{
			get
			{
				if (_bufferedAmmoId == null)
				{
					_bufferedAmmoId = (CInt32) CR2WTypeManager.Create("Int32", "bufferedAmmoId", cr2w, this);
				}
				return _bufferedAmmoId;
			}
			set
			{
				if (_bufferedAmmoId == value)
				{
					return;
				}
				_bufferedAmmoId = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("genderName")] 
		public CName GenderName
		{
			get
			{
				if (_genderName == null)
				{
					_genderName = (CName) CR2WTypeManager.Create("CName", "genderName", cr2w, this);
				}
				return _genderName;
			}
			set
			{
				if (_genderName == value)
				{
					return;
				}
				_genderName = value;
				PropertySet(this);
			}
		}

		public weaponRosterGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

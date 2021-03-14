using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModePlayerEntityComponent : gameScriptableComponent
	{
		private gameItemID _usedWeaponItemId;
		private gameItemID _currentWeaponInSlot;
		private CArray<CEnum<gamedataItemType>> _availableItemTypesList;
		private CArray<wCHandle<gameItemData>> _availableItemsList;
		private gameItemID _swapMeeleWeaponItemId;
		private gameItemID _swapHangunWeaponItemId;
		private gameItemID _swapRifleWeaponItemId;
		private gameItemID _swapShootgunWeaponItemId;
		private wCHandle<gamePuppet> _fakePuppet;
		private wCHandle<PlayerPuppet> _playerPuppet;
		private CHandle<gameTransactionSystem> _tS;
		private CArray<gameItemID> _loadingItems;
		private CFloat _itemsLoadingTimeout;
		private CBool _muzzleEffectEnabled;

		[Ordinal(5)] 
		[RED("usedWeaponItemId")] 
		public gameItemID UsedWeaponItemId
		{
			get
			{
				if (_usedWeaponItemId == null)
				{
					_usedWeaponItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "usedWeaponItemId", cr2w, this);
				}
				return _usedWeaponItemId;
			}
			set
			{
				if (_usedWeaponItemId == value)
				{
					return;
				}
				_usedWeaponItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentWeaponInSlot")] 
		public gameItemID CurrentWeaponInSlot
		{
			get
			{
				if (_currentWeaponInSlot == null)
				{
					_currentWeaponInSlot = (gameItemID) CR2WTypeManager.Create("gameItemID", "currentWeaponInSlot", cr2w, this);
				}
				return _currentWeaponInSlot;
			}
			set
			{
				if (_currentWeaponInSlot == value)
				{
					return;
				}
				_currentWeaponInSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("availableItemTypesList")] 
		public CArray<CEnum<gamedataItemType>> AvailableItemTypesList
		{
			get
			{
				if (_availableItemTypesList == null)
				{
					_availableItemTypesList = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "availableItemTypesList", cr2w, this);
				}
				return _availableItemTypesList;
			}
			set
			{
				if (_availableItemTypesList == value)
				{
					return;
				}
				_availableItemTypesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("availableItemsList")] 
		public CArray<wCHandle<gameItemData>> AvailableItemsList
		{
			get
			{
				if (_availableItemsList == null)
				{
					_availableItemsList = (CArray<wCHandle<gameItemData>>) CR2WTypeManager.Create("array:whandle:gameItemData", "availableItemsList", cr2w, this);
				}
				return _availableItemsList;
			}
			set
			{
				if (_availableItemsList == value)
				{
					return;
				}
				_availableItemsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("swapMeeleWeaponItemId")] 
		public gameItemID SwapMeeleWeaponItemId
		{
			get
			{
				if (_swapMeeleWeaponItemId == null)
				{
					_swapMeeleWeaponItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "swapMeeleWeaponItemId", cr2w, this);
				}
				return _swapMeeleWeaponItemId;
			}
			set
			{
				if (_swapMeeleWeaponItemId == value)
				{
					return;
				}
				_swapMeeleWeaponItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("swapHangunWeaponItemId")] 
		public gameItemID SwapHangunWeaponItemId
		{
			get
			{
				if (_swapHangunWeaponItemId == null)
				{
					_swapHangunWeaponItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "swapHangunWeaponItemId", cr2w, this);
				}
				return _swapHangunWeaponItemId;
			}
			set
			{
				if (_swapHangunWeaponItemId == value)
				{
					return;
				}
				_swapHangunWeaponItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("swapRifleWeaponItemId")] 
		public gameItemID SwapRifleWeaponItemId
		{
			get
			{
				if (_swapRifleWeaponItemId == null)
				{
					_swapRifleWeaponItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "swapRifleWeaponItemId", cr2w, this);
				}
				return _swapRifleWeaponItemId;
			}
			set
			{
				if (_swapRifleWeaponItemId == value)
				{
					return;
				}
				_swapRifleWeaponItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("swapShootgunWeaponItemId")] 
		public gameItemID SwapShootgunWeaponItemId
		{
			get
			{
				if (_swapShootgunWeaponItemId == null)
				{
					_swapShootgunWeaponItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "swapShootgunWeaponItemId", cr2w, this);
				}
				return _swapShootgunWeaponItemId;
			}
			set
			{
				if (_swapShootgunWeaponItemId == value)
				{
					return;
				}
				_swapShootgunWeaponItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fakePuppet")] 
		public wCHandle<gamePuppet> FakePuppet
		{
			get
			{
				if (_fakePuppet == null)
				{
					_fakePuppet = (wCHandle<gamePuppet>) CR2WTypeManager.Create("whandle:gamePuppet", "fakePuppet", cr2w, this);
				}
				return _fakePuppet;
			}
			set
			{
				if (_fakePuppet == value)
				{
					return;
				}
				_fakePuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "playerPuppet", cr2w, this);
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

		[Ordinal(15)] 
		[RED("TS")] 
		public CHandle<gameTransactionSystem> TS
		{
			get
			{
				if (_tS == null)
				{
					_tS = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "TS", cr2w, this);
				}
				return _tS;
			}
			set
			{
				if (_tS == value)
				{
					return;
				}
				_tS = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("loadingItems")] 
		public CArray<gameItemID> LoadingItems
		{
			get
			{
				if (_loadingItems == null)
				{
					_loadingItems = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "loadingItems", cr2w, this);
				}
				return _loadingItems;
			}
			set
			{
				if (_loadingItems == value)
				{
					return;
				}
				_loadingItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("itemsLoadingTimeout")] 
		public CFloat ItemsLoadingTimeout
		{
			get
			{
				if (_itemsLoadingTimeout == null)
				{
					_itemsLoadingTimeout = (CFloat) CR2WTypeManager.Create("Float", "itemsLoadingTimeout", cr2w, this);
				}
				return _itemsLoadingTimeout;
			}
			set
			{
				if (_itemsLoadingTimeout == value)
				{
					return;
				}
				_itemsLoadingTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("muzzleEffectEnabled")] 
		public CBool MuzzleEffectEnabled
		{
			get
			{
				if (_muzzleEffectEnabled == null)
				{
					_muzzleEffectEnabled = (CBool) CR2WTypeManager.Create("Bool", "muzzleEffectEnabled", cr2w, this);
				}
				return _muzzleEffectEnabled;
			}
			set
			{
				if (_muzzleEffectEnabled == value)
				{
					return;
				}
				_muzzleEffectEnabled = value;
				PropertySet(this);
			}
		}

		public PhotoModePlayerEntityComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

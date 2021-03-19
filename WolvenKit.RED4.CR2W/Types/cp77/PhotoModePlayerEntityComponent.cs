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
			get => GetProperty(ref _usedWeaponItemId);
			set => SetProperty(ref _usedWeaponItemId, value);
		}

		[Ordinal(6)] 
		[RED("currentWeaponInSlot")] 
		public gameItemID CurrentWeaponInSlot
		{
			get => GetProperty(ref _currentWeaponInSlot);
			set => SetProperty(ref _currentWeaponInSlot, value);
		}

		[Ordinal(7)] 
		[RED("availableItemTypesList")] 
		public CArray<CEnum<gamedataItemType>> AvailableItemTypesList
		{
			get => GetProperty(ref _availableItemTypesList);
			set => SetProperty(ref _availableItemTypesList, value);
		}

		[Ordinal(8)] 
		[RED("availableItemsList")] 
		public CArray<wCHandle<gameItemData>> AvailableItemsList
		{
			get => GetProperty(ref _availableItemsList);
			set => SetProperty(ref _availableItemsList, value);
		}

		[Ordinal(9)] 
		[RED("swapMeeleWeaponItemId")] 
		public gameItemID SwapMeeleWeaponItemId
		{
			get => GetProperty(ref _swapMeeleWeaponItemId);
			set => SetProperty(ref _swapMeeleWeaponItemId, value);
		}

		[Ordinal(10)] 
		[RED("swapHangunWeaponItemId")] 
		public gameItemID SwapHangunWeaponItemId
		{
			get => GetProperty(ref _swapHangunWeaponItemId);
			set => SetProperty(ref _swapHangunWeaponItemId, value);
		}

		[Ordinal(11)] 
		[RED("swapRifleWeaponItemId")] 
		public gameItemID SwapRifleWeaponItemId
		{
			get => GetProperty(ref _swapRifleWeaponItemId);
			set => SetProperty(ref _swapRifleWeaponItemId, value);
		}

		[Ordinal(12)] 
		[RED("swapShootgunWeaponItemId")] 
		public gameItemID SwapShootgunWeaponItemId
		{
			get => GetProperty(ref _swapShootgunWeaponItemId);
			set => SetProperty(ref _swapShootgunWeaponItemId, value);
		}

		[Ordinal(13)] 
		[RED("fakePuppet")] 
		public wCHandle<gamePuppet> FakePuppet
		{
			get => GetProperty(ref _fakePuppet);
			set => SetProperty(ref _fakePuppet, value);
		}

		[Ordinal(14)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(15)] 
		[RED("TS")] 
		public CHandle<gameTransactionSystem> TS
		{
			get => GetProperty(ref _tS);
			set => SetProperty(ref _tS, value);
		}

		[Ordinal(16)] 
		[RED("loadingItems")] 
		public CArray<gameItemID> LoadingItems
		{
			get => GetProperty(ref _loadingItems);
			set => SetProperty(ref _loadingItems, value);
		}

		[Ordinal(17)] 
		[RED("itemsLoadingTimeout")] 
		public CFloat ItemsLoadingTimeout
		{
			get => GetProperty(ref _itemsLoadingTimeout);
			set => SetProperty(ref _itemsLoadingTimeout, value);
		}

		[Ordinal(18)] 
		[RED("muzzleEffectEnabled")] 
		public CBool MuzzleEffectEnabled
		{
			get => GetProperty(ref _muzzleEffectEnabled);
			set => SetProperty(ref _muzzleEffectEnabled, value);
		}

		public PhotoModePlayerEntityComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

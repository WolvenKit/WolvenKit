using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootingGameController : gameuiWidgetGameController
	{
		private CHandle<InventoryDataManagerV2> _dataManager;
		private CWeakHandle<gameIBlackboard> _bbInteractions;
		private CWeakHandle<gameIBlackboard> _bbEquipmentData;
		private CWeakHandle<gameIBlackboard> _bbEquipment;
		private CHandle<UIInteractionsDef> _bbInteractionsDefinition;
		private CHandle<UI_EquipmentDataDef> _bbEquipmentDataDefinition;
		private CHandle<UI_EquipmentDef> _bbEquipmentDefinition;
		private CHandle<redCallbackObject> _dataListenerId;
		private CHandle<redCallbackObject> _activeListenerId;
		private CHandle<redCallbackObject> _activeHubListenerId;
		private CHandle<redCallbackObject> _weaponDataListenerId;
		private CHandle<redCallbackObject> _itemEquippedListenerId;
		private CWeakHandle<LootingController> _controller;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _introAnim;
		private CHandle<inkanimProxy> _outroAnim;
		private gameSlotWeaponData _lastActiveWeapon;
		private InventoryItemData _lastActiveWeaponData;
		private gameinteractionsvisLootData _previousData;
		private entEntityID _lastActiveOwnerId;

		[Ordinal(2)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(3)] 
		[RED("bbInteractions")] 
		public CWeakHandle<gameIBlackboard> BbInteractions
		{
			get => GetProperty(ref _bbInteractions);
			set => SetProperty(ref _bbInteractions, value);
		}

		[Ordinal(4)] 
		[RED("bbEquipmentData")] 
		public CWeakHandle<gameIBlackboard> BbEquipmentData
		{
			get => GetProperty(ref _bbEquipmentData);
			set => SetProperty(ref _bbEquipmentData, value);
		}

		[Ordinal(5)] 
		[RED("bbEquipment")] 
		public CWeakHandle<gameIBlackboard> BbEquipment
		{
			get => GetProperty(ref _bbEquipment);
			set => SetProperty(ref _bbEquipment, value);
		}

		[Ordinal(6)] 
		[RED("bbInteractionsDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionsDefinition
		{
			get => GetProperty(ref _bbInteractionsDefinition);
			set => SetProperty(ref _bbInteractionsDefinition, value);
		}

		[Ordinal(7)] 
		[RED("bbEquipmentDataDefinition")] 
		public CHandle<UI_EquipmentDataDef> BbEquipmentDataDefinition
		{
			get => GetProperty(ref _bbEquipmentDataDefinition);
			set => SetProperty(ref _bbEquipmentDataDefinition, value);
		}

		[Ordinal(8)] 
		[RED("bbEquipmentDefinition")] 
		public CHandle<UI_EquipmentDef> BbEquipmentDefinition
		{
			get => GetProperty(ref _bbEquipmentDefinition);
			set => SetProperty(ref _bbEquipmentDefinition, value);
		}

		[Ordinal(9)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetProperty(ref _dataListenerId);
			set => SetProperty(ref _dataListenerId, value);
		}

		[Ordinal(10)] 
		[RED("activeListenerId")] 
		public CHandle<redCallbackObject> ActiveListenerId
		{
			get => GetProperty(ref _activeListenerId);
			set => SetProperty(ref _activeListenerId, value);
		}

		[Ordinal(11)] 
		[RED("activeHubListenerId")] 
		public CHandle<redCallbackObject> ActiveHubListenerId
		{
			get => GetProperty(ref _activeHubListenerId);
			set => SetProperty(ref _activeHubListenerId, value);
		}

		[Ordinal(12)] 
		[RED("weaponDataListenerId")] 
		public CHandle<redCallbackObject> WeaponDataListenerId
		{
			get => GetProperty(ref _weaponDataListenerId);
			set => SetProperty(ref _weaponDataListenerId, value);
		}

		[Ordinal(13)] 
		[RED("itemEquippedListenerId")] 
		public CHandle<redCallbackObject> ItemEquippedListenerId
		{
			get => GetProperty(ref _itemEquippedListenerId);
			set => SetProperty(ref _itemEquippedListenerId, value);
		}

		[Ordinal(14)] 
		[RED("controller")] 
		public CWeakHandle<LootingController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetProperty(ref _introAnim);
			set => SetProperty(ref _introAnim, value);
		}

		[Ordinal(17)] 
		[RED("outroAnim")] 
		public CHandle<inkanimProxy> OutroAnim
		{
			get => GetProperty(ref _outroAnim);
			set => SetProperty(ref _outroAnim, value);
		}

		[Ordinal(18)] 
		[RED("lastActiveWeapon")] 
		public gameSlotWeaponData LastActiveWeapon
		{
			get => GetProperty(ref _lastActiveWeapon);
			set => SetProperty(ref _lastActiveWeapon, value);
		}

		[Ordinal(19)] 
		[RED("lastActiveWeaponData")] 
		public InventoryItemData LastActiveWeaponData
		{
			get => GetProperty(ref _lastActiveWeaponData);
			set => SetProperty(ref _lastActiveWeaponData, value);
		}

		[Ordinal(20)] 
		[RED("previousData")] 
		public gameinteractionsvisLootData PreviousData
		{
			get => GetProperty(ref _previousData);
			set => SetProperty(ref _previousData, value);
		}

		[Ordinal(21)] 
		[RED("lastActiveOwnerId")] 
		public entEntityID LastActiveOwnerId
		{
			get => GetProperty(ref _lastActiveOwnerId);
			set => SetProperty(ref _lastActiveOwnerId, value);
		}
	}
}

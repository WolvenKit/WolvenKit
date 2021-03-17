using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingGameController : gameuiWidgetGameController
	{
		private CHandle<InventoryDataManagerV2> _dataManager;
		private wCHandle<gameIBlackboard> _bbInteractions;
		private wCHandle<gameIBlackboard> _bbEquipmentData;
		private CHandle<UIInteractionsDef> _bbInteractionsDefinition;
		private CHandle<UI_EquipmentDataDef> _bbEquipmentDefinition;
		private CUInt32 _dataListenerId;
		private CUInt32 _activeListenerId;
		private CUInt32 _activeHubListenerId;
		private CUInt32 _weaponDataListenerId;
		private CHandle<LootingController> _controller;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _introAnim;
		private CHandle<inkanimProxy> _outroAnim;
		private gameSlotWeaponData _lastActiveWeapon;
		private InventoryItemData _lastActiveWeaponData;
		private gameinteractionsvisLootData _previousData;

		[Ordinal(2)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(3)] 
		[RED("bbInteractions")] 
		public wCHandle<gameIBlackboard> BbInteractions
		{
			get => GetProperty(ref _bbInteractions);
			set => SetProperty(ref _bbInteractions, value);
		}

		[Ordinal(4)] 
		[RED("bbEquipmentData")] 
		public wCHandle<gameIBlackboard> BbEquipmentData
		{
			get => GetProperty(ref _bbEquipmentData);
			set => SetProperty(ref _bbEquipmentData, value);
		}

		[Ordinal(5)] 
		[RED("bbInteractionsDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionsDefinition
		{
			get => GetProperty(ref _bbInteractionsDefinition);
			set => SetProperty(ref _bbInteractionsDefinition, value);
		}

		[Ordinal(6)] 
		[RED("bbEquipmentDefinition")] 
		public CHandle<UI_EquipmentDataDef> BbEquipmentDefinition
		{
			get => GetProperty(ref _bbEquipmentDefinition);
			set => SetProperty(ref _bbEquipmentDefinition, value);
		}

		[Ordinal(7)] 
		[RED("dataListenerId")] 
		public CUInt32 DataListenerId
		{
			get => GetProperty(ref _dataListenerId);
			set => SetProperty(ref _dataListenerId, value);
		}

		[Ordinal(8)] 
		[RED("activeListenerId")] 
		public CUInt32 ActiveListenerId
		{
			get => GetProperty(ref _activeListenerId);
			set => SetProperty(ref _activeListenerId, value);
		}

		[Ordinal(9)] 
		[RED("activeHubListenerId")] 
		public CUInt32 ActiveHubListenerId
		{
			get => GetProperty(ref _activeHubListenerId);
			set => SetProperty(ref _activeHubListenerId, value);
		}

		[Ordinal(10)] 
		[RED("weaponDataListenerId")] 
		public CUInt32 WeaponDataListenerId
		{
			get => GetProperty(ref _weaponDataListenerId);
			set => SetProperty(ref _weaponDataListenerId, value);
		}

		[Ordinal(11)] 
		[RED("controller")] 
		public CHandle<LootingController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(12)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(13)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetProperty(ref _introAnim);
			set => SetProperty(ref _introAnim, value);
		}

		[Ordinal(14)] 
		[RED("outroAnim")] 
		public CHandle<inkanimProxy> OutroAnim
		{
			get => GetProperty(ref _outroAnim);
			set => SetProperty(ref _outroAnim, value);
		}

		[Ordinal(15)] 
		[RED("lastActiveWeapon")] 
		public gameSlotWeaponData LastActiveWeapon
		{
			get => GetProperty(ref _lastActiveWeapon);
			set => SetProperty(ref _lastActiveWeapon, value);
		}

		[Ordinal(16)] 
		[RED("lastActiveWeaponData")] 
		public InventoryItemData LastActiveWeaponData
		{
			get => GetProperty(ref _lastActiveWeaponData);
			set => SetProperty(ref _lastActiveWeaponData, value);
		}

		[Ordinal(17)] 
		[RED("previousData")] 
		public gameinteractionsvisLootData PreviousData
		{
			get => GetProperty(ref _previousData);
			set => SetProperty(ref _previousData, value);
		}

		public LootingGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

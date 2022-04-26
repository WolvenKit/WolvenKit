using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootingGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(3)] 
		[RED("bbInteractions")] 
		public CWeakHandle<gameIBlackboard> BbInteractions
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(4)] 
		[RED("bbEquipmentData")] 
		public CWeakHandle<gameIBlackboard> BbEquipmentData
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(5)] 
		[RED("bbEquipment")] 
		public CWeakHandle<gameIBlackboard> BbEquipment
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("bbInteractionsDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionsDefinition
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(7)] 
		[RED("bbEquipmentDataDefinition")] 
		public CHandle<UI_EquipmentDataDef> BbEquipmentDataDefinition
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDataDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDataDef>>(value);
		}

		[Ordinal(8)] 
		[RED("bbEquipmentDefinition")] 
		public CHandle<UI_EquipmentDef> BbEquipmentDefinition
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(9)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("activeListenerId")] 
		public CHandle<redCallbackObject> ActiveListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("activeHubListenerId")] 
		public CHandle<redCallbackObject> ActiveHubListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("weaponDataListenerId")] 
		public CHandle<redCallbackObject> WeaponDataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("itemEquippedListenerId")] 
		public CHandle<redCallbackObject> ItemEquippedListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("controller")] 
		public CWeakHandle<LootingController> Controller
		{
			get => GetPropertyValue<CWeakHandle<LootingController>>();
			set => SetPropertyValue<CWeakHandle<LootingController>>(value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(16)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("outroAnim")] 
		public CHandle<inkanimProxy> OutroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("lastActiveWeapon")] 
		public gameSlotWeaponData LastActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(19)] 
		[RED("lastActiveWeaponData")] 
		public InventoryItemData LastActiveWeaponData
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(20)] 
		[RED("previousData")] 
		public gameinteractionsvisLootData PreviousData
		{
			get => GetPropertyValue<gameinteractionsvisLootData>();
			set => SetPropertyValue<gameinteractionsvisLootData>(value);
		}

		[Ordinal(21)] 
		[RED("lastActiveOwnerId")] 
		public entEntityID LastActiveOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public LootingGameController()
		{
			LastActiveWeapon = new() { WeaponID = new(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };
			LastActiveWeaponData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			PreviousData = new() { IsListOpen = true, Choices = new(), ItemIDs = new(), OwnerId = new() };
			LastActiveOwnerId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

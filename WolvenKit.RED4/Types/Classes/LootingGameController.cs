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
		[RED("uiInventorySystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("bbInteractions")] 
		public CWeakHandle<gameIBlackboard> BbInteractions
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(5)] 
		[RED("bbEquipmentData")] 
		public CWeakHandle<gameIBlackboard> BbEquipmentData
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("bbEquipment")] 
		public CWeakHandle<gameIBlackboard> BbEquipment
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(7)] 
		[RED("bbInteractionsDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionsDefinition
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(8)] 
		[RED("bbEquipmentDataDefinition")] 
		public CHandle<UI_EquipmentDataDef> BbEquipmentDataDefinition
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDataDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDataDef>>(value);
		}

		[Ordinal(9)] 
		[RED("bbEquipmentDefinition")] 
		public CHandle<UI_EquipmentDef> BbEquipmentDefinition
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(10)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("activeListenerId")] 
		public CHandle<redCallbackObject> ActiveListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("activeHubListenerId")] 
		public CHandle<redCallbackObject> ActiveHubListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("weaponDataListenerId")] 
		public CHandle<redCallbackObject> WeaponDataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("itemEquippedListenerId")] 
		public CHandle<redCallbackObject> ItemEquippedListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("controller")] 
		public CWeakHandle<LootingController> Controller
		{
			get => GetPropertyValue<CWeakHandle<LootingController>>();
			set => SetPropertyValue<CWeakHandle<LootingController>>(value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(17)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("outroAnim")] 
		public CHandle<inkanimProxy> OutroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("lastActiveWeapon")] 
		public gameSlotWeaponData LastActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(20)] 
		[RED("lastActiveWeaponID")] 
		public gameItemID LastActiveWeaponID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(21)] 
		[RED("previousData")] 
		public gameinteractionsvisLootData PreviousData
		{
			get => GetPropertyValue<gameinteractionsvisLootData>();
			set => SetPropertyValue<gameinteractionsvisLootData>(value);
		}

		[Ordinal(22)] 
		[RED("lastActiveOwnerId")] 
		public entEntityID LastActiveOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public LootingGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

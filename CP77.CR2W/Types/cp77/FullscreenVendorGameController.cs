using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FullscreenVendorGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(2)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(3)]  [RED("playerFiltersContainer")] public inkWidgetReference PlayerFiltersContainer { get; set; }
		[Ordinal(4)]  [RED("vendorFiltersContainer")] public inkWidgetReference VendorFiltersContainer { get; set; }
		[Ordinal(5)]  [RED("inventoryGridList")] public inkVirtualCompoundWidgetReference InventoryGridList { get; set; }
		[Ordinal(6)]  [RED("vendorSpecialOffersInventoryGridList")] public inkCompoundWidgetReference VendorSpecialOffersInventoryGridList { get; set; }
		[Ordinal(7)]  [RED("vendorInventoryGridList")] public inkVirtualCompoundWidgetReference VendorInventoryGridList { get; set; }
		[Ordinal(8)]  [RED("specialOffersWrapper")] public inkWidgetReference SpecialOffersWrapper { get; set; }
		[Ordinal(9)]  [RED("playerInventoryGridScroll")] public inkWidgetReference PlayerInventoryGridScroll { get; set; }
		[Ordinal(10)]  [RED("vendorInventoryGridScroll")] public inkWidgetReference VendorInventoryGridScroll { get; set; }
		[Ordinal(11)]  [RED("notificationRoot")] public inkWidgetReference NotificationRoot { get; set; }
		[Ordinal(12)]  [RED("emptyStock")] public inkWidgetReference EmptyStock { get; set; }
		[Ordinal(13)]  [RED("buyWrapper")] public inkWidgetReference BuyWrapper { get; set; }
		[Ordinal(14)]  [RED("vendorMoney")] public inkTextWidgetReference VendorMoney { get; set; }
		[Ordinal(15)]  [RED("vendorName")] public inkTextWidgetReference VendorName { get; set; }
		[Ordinal(16)]  [RED("playerMoney")] public inkTextWidgetReference PlayerMoney { get; set; }
		[Ordinal(17)]  [RED("quantityPicker")] public inkWidgetReference QuantityPicker { get; set; }
		[Ordinal(18)]  [RED("playerSortingButton")] public inkWidgetReference PlayerSortingButton { get; set; }
		[Ordinal(19)]  [RED("vendorSortingButton")] public inkWidgetReference VendorSortingButton { get; set; }
		[Ordinal(20)]  [RED("sortingDropdown")] public inkWidgetReference SortingDropdown { get; set; }
		[Ordinal(21)]  [RED("playerBalance")] public inkWidgetReference PlayerBalance { get; set; }
		[Ordinal(22)]  [RED("vendorBalance")] public inkWidgetReference VendorBalance { get; set; }
		[Ordinal(23)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(24)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(25)]  [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }
		[Ordinal(26)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(27)]  [RED("itemTypeSorting")] public CArray<CEnum<gamedataItemType>> ItemTypeSorting { get; set; }
		[Ordinal(28)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(29)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(30)]  [RED("playerInventoryitemControllers")] public CArray<CHandle<InventoryItemDisplayController>> PlayerInventoryitemControllers { get; set; }
		[Ordinal(31)]  [RED("vendorInventoryitemControllers")] public CArray<CHandle<InventoryItemDisplayController>> VendorInventoryitemControllers { get; set; }
		[Ordinal(32)]  [RED("vendorSpecialOfferInventoryitemControllers")] public CArray<CHandle<InventoryItemDisplayController>> VendorSpecialOfferInventoryitemControllers { get; set; }
		[Ordinal(33)]  [RED("playerDataSource")] public CHandle<inkScriptableDataSourceWrapper> PlayerDataSource { get; set; }
		[Ordinal(34)]  [RED("virtualPlayerListController")] public CHandle<inkVirtualGridController> VirtualPlayerListController { get; set; }
		[Ordinal(35)]  [RED("vendorDataSource")] public CHandle<inkScriptableDataSourceWrapper> VendorDataSource { get; set; }
		[Ordinal(36)]  [RED("virtualVendorListController")] public CHandle<inkVirtualGridController> VirtualVendorListController { get; set; }
		[Ordinal(37)]  [RED("playerItemsDataView")] public CHandle<VendorDataView> PlayerItemsDataView { get; set; }
		[Ordinal(38)]  [RED("vendorItemsDataView")] public CHandle<VendorDataView> VendorItemsDataView { get; set; }
		[Ordinal(39)]  [RED("itemsClassifier")] public CHandle<ItemDisplayTemplateClassifier> ItemsClassifier { get; set; }
		[Ordinal(40)]  [RED("totalBuyCost")] public CFloat TotalBuyCost { get; set; }
		[Ordinal(41)]  [RED("totalSellCost")] public CFloat TotalSellCost { get; set; }
		[Ordinal(42)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(43)]  [RED("vendorUserData")] public CHandle<VendorUserData> VendorUserData { get; set; }
		[Ordinal(44)]  [RED("storageUserData")] public CHandle<StorageUserData> StorageUserData { get; set; }
		[Ordinal(45)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(46)]  [RED("sellJunkPopupToken")] public CHandle<inkGameNotificationToken> SellJunkPopupToken { get; set; }
		[Ordinal(47)]  [RED("quantityPickerPopupToken")] public CHandle<inkGameNotificationToken> QuantityPickerPopupToken { get; set; }
		[Ordinal(48)]  [RED("confirmationPopupToken")] public CHandle<inkGameNotificationToken> ConfirmationPopupToken { get; set; }
		[Ordinal(49)]  [RED("itemPreviewPopupToken")] public CHandle<inkGameNotificationToken> ItemPreviewPopupToken { get; set; }
		[Ordinal(50)]  [RED("VendorBlackboard")] public CHandle<gameIBlackboard> VendorBlackboard { get; set; }
		[Ordinal(51)]  [RED("VendorBlackboardDef")] public CHandle<UI_VendorDef> VendorBlackboardDef { get; set; }
		[Ordinal(52)]  [RED("VendorUpdatedCallbackID")] public CUInt32 VendorUpdatedCallbackID { get; set; }
		[Ordinal(53)]  [RED("craftingBlackboard")] public CHandle<gameIBlackboard> CraftingBlackboard { get; set; }
		[Ordinal(54)]  [RED("craftingBlackboardDef")] public CHandle<UI_CraftingDef> CraftingBlackboardDef { get; set; }
		[Ordinal(55)]  [RED("craftingCallbackID")] public CUInt32 CraftingCallbackID { get; set; }
		[Ordinal(56)]  [RED("playerFilterManager")] public CHandle<ItemCategoryFliterManager> PlayerFilterManager { get; set; }
		[Ordinal(57)]  [RED("vendorFilterManager")] public CHandle<ItemCategoryFliterManager> VendorFilterManager { get; set; }
		[Ordinal(58)]  [RED("lastPlayerFilter")] public CEnum<ItemFilterCategory> LastPlayerFilter { get; set; }
		[Ordinal(59)]  [RED("lastVendorFilter")] public CEnum<ItemFilterCategory> LastVendorFilter { get; set; }
		[Ordinal(60)]  [RED("uiScriptableSystem")] public CHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(61)]  [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(62)]  [RED("storageDef")] public CHandle<StorageBlackboardDef> StorageDef { get; set; }
		[Ordinal(63)]  [RED("storageBlackboard")] public CHandle<gameIBlackboard> StorageBlackboard { get; set; }
		[Ordinal(64)]  [RED("itemDropQueue")] public CArray<gameItemModParams> ItemDropQueue { get; set; }
		[Ordinal(65)]  [RED("soldItems")] public CHandle<SoldItemsCache> SoldItems { get; set; }
		[Ordinal(66)]  [RED("isActivePanel")] public CBool IsActivePanel { get; set; }
		[Ordinal(67)]  [RED("sellQueue")] public CArray<ItemID> SellQueue { get; set; }
		[Ordinal(68)]  [RED("buyQueue")] public CArray<ItemID> BuyQueue { get; set; }

		public FullscreenVendorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

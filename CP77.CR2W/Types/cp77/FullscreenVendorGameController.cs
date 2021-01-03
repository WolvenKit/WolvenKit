using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FullscreenVendorGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(1)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(2)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(3)]  [RED("VendorBlackboard")] public CHandle<gameIBlackboard> VendorBlackboard { get; set; }
		[Ordinal(4)]  [RED("VendorBlackboardDef")] public CHandle<UI_VendorDef> VendorBlackboardDef { get; set; }
		[Ordinal(5)]  [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }
		[Ordinal(6)]  [RED("VendorUpdatedCallbackID")] public CUInt32 VendorUpdatedCallbackID { get; set; }
		[Ordinal(7)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(8)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(9)]  [RED("buyQueue")] public CArray<gameItemID> BuyQueue { get; set; }
		[Ordinal(10)]  [RED("buyWrapper")] public inkWidgetReference BuyWrapper { get; set; }
		[Ordinal(11)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(12)]  [RED("confirmationPopupToken")] public CHandle<inkGameNotificationToken> ConfirmationPopupToken { get; set; }
		[Ordinal(13)]  [RED("craftingBlackboard")] public CHandle<gameIBlackboard> CraftingBlackboard { get; set; }
		[Ordinal(14)]  [RED("craftingBlackboardDef")] public CHandle<UI_CraftingDef> CraftingBlackboardDef { get; set; }
		[Ordinal(15)]  [RED("craftingCallbackID")] public CUInt32 CraftingCallbackID { get; set; }
		[Ordinal(16)]  [RED("emptyStock")] public inkWidgetReference EmptyStock { get; set; }
		[Ordinal(17)]  [RED("inventoryGridList")] public inkVirtualCompoundWidgetReference InventoryGridList { get; set; }
		[Ordinal(18)]  [RED("isActivePanel")] public CBool IsActivePanel { get; set; }
		[Ordinal(19)]  [RED("itemDropQueue")] public CArray<gameItemModParams> ItemDropQueue { get; set; }
		[Ordinal(20)]  [RED("itemPreviewPopupToken")] public CHandle<inkGameNotificationToken> ItemPreviewPopupToken { get; set; }
		[Ordinal(21)]  [RED("itemTypeSorting")] public CArray<CEnum<gamedataItemType>> ItemTypeSorting { get; set; }
		[Ordinal(22)]  [RED("itemsClassifier")] public CHandle<ItemDisplayTemplateClassifier> ItemsClassifier { get; set; }
		[Ordinal(23)]  [RED("lastPlayerFilter")] public CEnum<ItemFilterCategory> LastPlayerFilter { get; set; }
		[Ordinal(24)]  [RED("lastVendorFilter")] public CEnum<ItemFilterCategory> LastVendorFilter { get; set; }
		[Ordinal(25)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(26)]  [RED("notificationRoot")] public inkWidgetReference NotificationRoot { get; set; }
		[Ordinal(27)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(28)]  [RED("playerBalance")] public inkWidgetReference PlayerBalance { get; set; }
		[Ordinal(29)]  [RED("playerDataSource")] public CHandle<inkScriptableDataSourceWrapper> PlayerDataSource { get; set; }
		[Ordinal(30)]  [RED("playerFilterManager")] public CHandle<ItemCategoryFliterManager> PlayerFilterManager { get; set; }
		[Ordinal(31)]  [RED("playerFiltersContainer")] public inkWidgetReference PlayerFiltersContainer { get; set; }
		[Ordinal(32)]  [RED("playerInventoryGridScroll")] public inkWidgetReference PlayerInventoryGridScroll { get; set; }
		[Ordinal(33)]  [RED("playerInventoryitemControllers")] public CArray<CHandle<InventoryItemDisplayController>> PlayerInventoryitemControllers { get; set; }
		[Ordinal(34)]  [RED("playerItemsDataView")] public CHandle<VendorDataView> PlayerItemsDataView { get; set; }
		[Ordinal(35)]  [RED("playerMoney")] public inkTextWidgetReference PlayerMoney { get; set; }
		[Ordinal(36)]  [RED("playerSortingButton")] public inkWidgetReference PlayerSortingButton { get; set; }
		[Ordinal(37)]  [RED("quantityPicker")] public inkWidgetReference QuantityPicker { get; set; }
		[Ordinal(38)]  [RED("quantityPickerPopupToken")] public CHandle<inkGameNotificationToken> QuantityPickerPopupToken { get; set; }
		[Ordinal(39)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(40)]  [RED("sellJunkPopupToken")] public CHandle<inkGameNotificationToken> SellJunkPopupToken { get; set; }
		[Ordinal(41)]  [RED("sellQueue")] public CArray<gameItemID> SellQueue { get; set; }
		[Ordinal(42)]  [RED("soldItems")] public CHandle<SoldItemsCache> SoldItems { get; set; }
		[Ordinal(43)]  [RED("sortingDropdown")] public inkWidgetReference SortingDropdown { get; set; }
		[Ordinal(44)]  [RED("specialOffersWrapper")] public inkWidgetReference SpecialOffersWrapper { get; set; }
		[Ordinal(45)]  [RED("storageBlackboard")] public CHandle<gameIBlackboard> StorageBlackboard { get; set; }
		[Ordinal(46)]  [RED("storageDef")] public CHandle<StorageBlackboardDef> StorageDef { get; set; }
		[Ordinal(47)]  [RED("storageUserData")] public CHandle<StorageUserData> StorageUserData { get; set; }
		[Ordinal(48)]  [RED("totalBuyCost")] public CFloat TotalBuyCost { get; set; }
		[Ordinal(49)]  [RED("totalSellCost")] public CFloat TotalSellCost { get; set; }
		[Ordinal(50)]  [RED("uiScriptableSystem")] public CHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(51)]  [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(52)]  [RED("vendorBalance")] public inkWidgetReference VendorBalance { get; set; }
		[Ordinal(53)]  [RED("vendorDataSource")] public CHandle<inkScriptableDataSourceWrapper> VendorDataSource { get; set; }
		[Ordinal(54)]  [RED("vendorFilterManager")] public CHandle<ItemCategoryFliterManager> VendorFilterManager { get; set; }
		[Ordinal(55)]  [RED("vendorFiltersContainer")] public inkWidgetReference VendorFiltersContainer { get; set; }
		[Ordinal(56)]  [RED("vendorInventoryGridList")] public inkVirtualCompoundWidgetReference VendorInventoryGridList { get; set; }
		[Ordinal(57)]  [RED("vendorInventoryGridScroll")] public inkWidgetReference VendorInventoryGridScroll { get; set; }
		[Ordinal(58)]  [RED("vendorInventoryitemControllers")] public CArray<CHandle<InventoryItemDisplayController>> VendorInventoryitemControllers { get; set; }
		[Ordinal(59)]  [RED("vendorItemsDataView")] public CHandle<VendorDataView> VendorItemsDataView { get; set; }
		[Ordinal(60)]  [RED("vendorMoney")] public inkTextWidgetReference VendorMoney { get; set; }
		[Ordinal(61)]  [RED("vendorName")] public inkTextWidgetReference VendorName { get; set; }
		[Ordinal(62)]  [RED("vendorSortingButton")] public inkWidgetReference VendorSortingButton { get; set; }
		[Ordinal(63)]  [RED("vendorSpecialOfferInventoryitemControllers")] public CArray<CHandle<InventoryItemDisplayController>> VendorSpecialOfferInventoryitemControllers { get; set; }
		[Ordinal(64)]  [RED("vendorSpecialOffersInventoryGridList")] public inkCompoundWidgetReference VendorSpecialOffersInventoryGridList { get; set; }
		[Ordinal(65)]  [RED("vendorUserData")] public CHandle<VendorUserData> VendorUserData { get; set; }
		[Ordinal(66)]  [RED("virtualPlayerListController")] public CHandle<inkVirtualGridController> VirtualPlayerListController { get; set; }
		[Ordinal(67)]  [RED("virtualVendorListController")] public CHandle<inkVirtualGridController> VirtualVendorListController { get; set; }

		public FullscreenVendorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

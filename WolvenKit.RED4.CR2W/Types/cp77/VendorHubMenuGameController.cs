using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorHubMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("selectorWidget")] public inkWidgetReference SelectorWidget { get; set; }
		[Ordinal(4)] [RED("playerCurrency")] public inkTextWidgetReference PlayerCurrency { get; set; }
		[Ordinal(5)] [RED("vendorShopLabel")] public inkTextWidgetReference VendorShopLabel { get; set; }
		[Ordinal(6)] [RED("notificationRoot")] public inkWidgetReference NotificationRoot { get; set; }
		[Ordinal(7)] [RED("playerWeight")] public inkTextWidgetReference PlayerWeight { get; set; }
		[Ordinal(8)] [RED("levelValue")] public inkTextWidgetReference LevelValue { get; set; }
		[Ordinal(9)] [RED("streetCredLabel")] public inkTextWidgetReference StreetCredLabel { get; set; }
		[Ordinal(10)] [RED("levelBarProgress")] public inkWidgetReference LevelBarProgress { get; set; }
		[Ordinal(11)] [RED("levelBarSpacer")] public inkWidgetReference LevelBarSpacer { get; set; }
		[Ordinal(12)] [RED("streetCredBarProgress")] public inkWidgetReference StreetCredBarProgress { get; set; }
		[Ordinal(13)] [RED("streetCredBarSpacer")] public inkWidgetReference StreetCredBarSpacer { get; set; }
		[Ordinal(14)] [RED("selectorCtrl")] public wCHandle<hubSelectorSingleSmallCarouselController> SelectorCtrl { get; set; }
		[Ordinal(15)] [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }
		[Ordinal(16)] [RED("vendorUserData")] public CHandle<VendorUserData> VendorUserData { get; set; }
		[Ordinal(17)] [RED("vendorPanelData")] public CHandle<questVendorPanelData> VendorPanelData { get; set; }
		[Ordinal(18)] [RED("storageUserData")] public CHandle<StorageUserData> StorageUserData { get; set; }
		[Ordinal(19)] [RED("PDS")] public CHandle<PlayerDevelopmentSystem> PDS { get; set; }
		[Ordinal(20)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(21)] [RED("VendorBlackboard")] public CHandle<gameIBlackboard> VendorBlackboard { get; set; }
		[Ordinal(22)] [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(23)] [RED("VendorBlackboardDef")] public CHandle<UI_VendorDef> VendorBlackboardDef { get; set; }
		[Ordinal(24)] [RED("VendorUpdatedCallbackID")] public CUInt32 VendorUpdatedCallbackID { get; set; }
		[Ordinal(25)] [RED("weightListener")] public CUInt32 WeightListener { get; set; }
		[Ordinal(26)] [RED("characterLevelListener")] public CUInt32 CharacterLevelListener { get; set; }
		[Ordinal(27)] [RED("characterCurrentXPListener")] public CUInt32 CharacterCurrentXPListener { get; set; }
		[Ordinal(28)] [RED("characterCredListener")] public CUInt32 CharacterCredListener { get; set; }
		[Ordinal(29)] [RED("characterCredPointsListener")] public CUInt32 CharacterCredPointsListener { get; set; }
		[Ordinal(30)] [RED("characterCurrentHealthListener")] public CUInt32 CharacterCurrentHealthListener { get; set; }
		[Ordinal(31)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(32)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(33)] [RED("menuData")] public CArray<MenuData> MenuData { get; set; }
		[Ordinal(34)] [RED("storageDef")] public CHandle<StorageBlackboardDef> StorageDef { get; set; }
		[Ordinal(35)] [RED("storageBlackboard")] public CHandle<gameIBlackboard> StorageBlackboard { get; set; }

		public VendorHubMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

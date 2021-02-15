using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RipperDocGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(4)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(5)] [RED("defaultTab")] public inkWidgetReference DefaultTab { get; set; }
		[Ordinal(6)] [RED("itemTab")] public inkWidgetReference ItemTab { get; set; }
		[Ordinal(7)] [RED("femaleHovers")] public inkWidgetReference FemaleHovers { get; set; }
		[Ordinal(8)] [RED("maleHovers")] public inkWidgetReference MaleHovers { get; set; }
		[Ordinal(9)] [RED("F_frontalCortexHoverTexture")] public inkWidgetReference F_frontalCortexHoverTexture { get; set; }
		[Ordinal(10)] [RED("F_eyesHoverTexture")] public inkWidgetReference F_eyesHoverTexture { get; set; }
		[Ordinal(11)] [RED("F_cardiovascularHoverTexture")] public inkWidgetReference F_cardiovascularHoverTexture { get; set; }
		[Ordinal(12)] [RED("F_immuneHoverTexture")] public inkWidgetReference F_immuneHoverTexture { get; set; }
		[Ordinal(13)] [RED("F_nervousHoverTexture")] public inkWidgetReference F_nervousHoverTexture { get; set; }
		[Ordinal(14)] [RED("F_integumentaryHoverTexture")] public inkWidgetReference F_integumentaryHoverTexture { get; set; }
		[Ordinal(15)] [RED("F_systemReplacementHoverTexture")] public inkWidgetReference F_systemReplacementHoverTexture { get; set; }
		[Ordinal(16)] [RED("F_musculoskeletalHoverTexture")] public inkWidgetReference F_musculoskeletalHoverTexture { get; set; }
		[Ordinal(17)] [RED("F_handsHoverTexture")] public inkWidgetReference F_handsHoverTexture { get; set; }
		[Ordinal(18)] [RED("F_armsHoverTexture")] public inkWidgetReference F_armsHoverTexture { get; set; }
		[Ordinal(19)] [RED("F_legsHoverTexture")] public inkWidgetReference F_legsHoverTexture { get; set; }
		[Ordinal(20)] [RED("M_frontalCortexHoverTexture")] public inkWidgetReference M_frontalCortexHoverTexture { get; set; }
		[Ordinal(21)] [RED("M_eyesHoverTexture")] public inkWidgetReference M_eyesHoverTexture { get; set; }
		[Ordinal(22)] [RED("M_cardiovascularHoverTexture")] public inkWidgetReference M_cardiovascularHoverTexture { get; set; }
		[Ordinal(23)] [RED("M_immuneHoverTexture")] public inkWidgetReference M_immuneHoverTexture { get; set; }
		[Ordinal(24)] [RED("M_nervousHoverTexture")] public inkWidgetReference M_nervousHoverTexture { get; set; }
		[Ordinal(25)] [RED("M_integumentaryHoverTexture")] public inkWidgetReference M_integumentaryHoverTexture { get; set; }
		[Ordinal(26)] [RED("M_systemReplacementHoverTexture")] public inkWidgetReference M_systemReplacementHoverTexture { get; set; }
		[Ordinal(27)] [RED("M_musculoskeletalHoverTexture")] public inkWidgetReference M_musculoskeletalHoverTexture { get; set; }
		[Ordinal(28)] [RED("M_handsHoverTexture")] public inkWidgetReference M_handsHoverTexture { get; set; }
		[Ordinal(29)] [RED("M_armsHoverTexture")] public inkWidgetReference M_armsHoverTexture { get; set; }
		[Ordinal(30)] [RED("M_legsHoverTexture")] public inkWidgetReference M_legsHoverTexture { get; set; }
		[Ordinal(31)] [RED("man_wiresTexture")] public inkWidgetReference Man_wiresTexture { get; set; }
		[Ordinal(32)] [RED("woman_wiresTexture")] public inkWidgetReference Woman_wiresTexture { get; set; }
		[Ordinal(33)] [RED("frontalCortexAnchor")] public inkCompoundWidgetReference FrontalCortexAnchor { get; set; }
		[Ordinal(34)] [RED("ocularCortexAnchor")] public inkCompoundWidgetReference OcularCortexAnchor { get; set; }
		[Ordinal(35)] [RED("leftMiddleGridAnchor")] public inkCompoundWidgetReference LeftMiddleGridAnchor { get; set; }
		[Ordinal(36)] [RED("leftButtomGridAnchor")] public inkCompoundWidgetReference LeftButtomGridAnchor { get; set; }
		[Ordinal(37)] [RED("rightTopGridAnchor")] public inkCompoundWidgetReference RightTopGridAnchor { get; set; }
		[Ordinal(38)] [RED("rightButtomGridAnchor")] public inkCompoundWidgetReference RightButtomGridAnchor { get; set; }
		[Ordinal(39)] [RED("skeletonAnchor")] public inkCompoundWidgetReference SkeletonAnchor { get; set; }
		[Ordinal(40)] [RED("handsAnchor")] public inkCompoundWidgetReference HandsAnchor { get; set; }
		[Ordinal(41)] [RED("ripperdocIdRoot")] public inkWidgetReference RipperdocIdRoot { get; set; }
		[Ordinal(42)] [RED("playerMoney")] public inkTextWidgetReference PlayerMoney { get; set; }
		[Ordinal(43)] [RED("playerMoneyHolder")] public inkWidgetReference PlayerMoneyHolder { get; set; }
		[Ordinal(44)] [RED("cyberwareSlotsList")] public inkCompoundWidgetReference CyberwareSlotsList { get; set; }
		[Ordinal(45)] [RED("cyberwareVirtualGrid")] public inkVirtualCompoundWidgetReference CyberwareVirtualGrid { get; set; }
		[Ordinal(46)] [RED("radioGroupRef")] public inkWidgetReference RadioGroupRef { get; set; }
		[Ordinal(47)] [RED("cyberwareInfoContainer")] public inkCompoundWidgetReference CyberwareInfoContainer { get; set; }
		[Ordinal(48)] [RED("itemsListScrollAreaContainer")] public inkWidgetReference ItemsListScrollAreaContainer { get; set; }
		[Ordinal(49)] [RED("sortingButton")] public inkWidgetReference SortingButton { get; set; }
		[Ordinal(50)] [RED("sortingDropdown")] public inkWidgetReference SortingDropdown { get; set; }
		[Ordinal(51)] [RED("mode")] public CEnum<RipperdocModes> Mode { get; set; }
		[Ordinal(52)] [RED("screen")] public CEnum<CyberwareScreenType> Screen { get; set; }
		[Ordinal(53)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(54)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(55)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(56)] [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(57)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(58)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(59)] [RED("vendorUserData")] public CHandle<VendorUserData> VendorUserData { get; set; }
		[Ordinal(60)] [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }
		[Ordinal(61)] [RED("selectedArea")] public CEnum<gamedataEquipmentArea> SelectedArea { get; set; }
		[Ordinal(62)] [RED("equipmentGrid")] public CHandle<CyberwareInventoryMiniGrid> EquipmentGrid { get; set; }
		[Ordinal(63)] [RED("VendorBlackboard")] public CHandle<gameIBlackboard> VendorBlackboard { get; set; }
		[Ordinal(64)] [RED("equipmentBlackboard")] public CHandle<gameIBlackboard> EquipmentBlackboard { get; set; }
		[Ordinal(65)] [RED("equipmentBlackboardCallback")] public CUInt32 EquipmentBlackboardCallback { get; set; }
		[Ordinal(66)] [RED("cyberwareInfo")] public wCHandle<AGenericTooltipController> CyberwareInfo { get; set; }
		[Ordinal(67)] [RED("cyberwareInfoType")] public CEnum<CyberwareInfoType> CyberwareInfoType { get; set; }
		[Ordinal(68)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(69)] [RED("virtualCyberwareListController")] public CHandle<inkVirtualGridController> VirtualCyberwareListController { get; set; }
		[Ordinal(70)] [RED("cyberwareClassifier")] public CHandle<CyberwareTemplateClassifier> CyberwareClassifier { get; set; }
		[Ordinal(71)] [RED("cyberwareDataSource")] public CHandle<inkScriptableDataSourceWrapper> CyberwareDataSource { get; set; }
		[Ordinal(72)] [RED("cyberwaregDataView")] public CHandle<CyberwareDataView> CyberwaregDataView { get; set; }
		[Ordinal(73)] [RED("currentFilter")] public CEnum<RipperdocFilter> CurrentFilter { get; set; }
		[Ordinal(74)] [RED("radioGroup")] public wCHandle<FilterRadioGroup> RadioGroup { get; set; }
		[Ordinal(75)] [RED("ripperId")] public CHandle<RipperdocIdPanel> RipperId { get; set; }
		[Ordinal(76)] [RED("hoverAnimation")] public CHandle<inkanimProxy> HoverAnimation { get; set; }
		[Ordinal(77)] [RED("introDefaultAnimation")] public CHandle<inkanimProxy> IntroDefaultAnimation { get; set; }
		[Ordinal(78)] [RED("outroDefaultAnimation")] public CHandle<inkanimProxy> OutroDefaultAnimation { get; set; }
		[Ordinal(79)] [RED("introPaperdollAnimation")] public CHandle<inkanimProxy> IntroPaperdollAnimation { get; set; }
		[Ordinal(80)] [RED("outroPaperdollAnimation")] public CHandle<inkanimProxy> OutroPaperdollAnimation { get; set; }
		[Ordinal(81)] [RED("inventoryListener")] public CHandle<gameInventoryScriptListener> InventoryListener { get; set; }
		[Ordinal(82)] [RED("cyberareGrids")] public CArray<CHandle<CyberwareInventoryMiniGrid>> CyberareGrids { get; set; }
		[Ordinal(83)] [RED("isActivePanel")] public CBool IsActivePanel { get; set; }
		[Ordinal(84)] [RED("equiped")] public CBool Equiped { get; set; }
		[Ordinal(85)] [RED("selectedPreviewSlot")] public CInt32 SelectedPreviewSlot { get; set; }

		public RipperDocGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

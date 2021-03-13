using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SubMenuPanelLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("levelValue")] public inkTextWidgetReference LevelValue { get; set; }
		[Ordinal(2)] [RED("streetCredLabel")] public inkTextWidgetReference StreetCredLabel { get; set; }
		[Ordinal(3)] [RED("currencyValue")] public inkTextWidgetReference CurrencyValue { get; set; }
		[Ordinal(4)] [RED("weightValue")] public inkTextWidgetReference WeightValue { get; set; }
		[Ordinal(5)] [RED("subMenuLabel")] public inkTextWidgetReference SubMenuLabel { get; set; }
		[Ordinal(6)] [RED("centralLine")] public inkWidgetReference CentralLine { get; set; }
		[Ordinal(7)] [RED("levelBarProgress")] public inkWidgetReference LevelBarProgress { get; set; }
		[Ordinal(8)] [RED("levelBarSpacer")] public inkWidgetReference LevelBarSpacer { get; set; }
		[Ordinal(9)] [RED("streetCredBarProgress")] public inkWidgetReference StreetCredBarProgress { get; set; }
		[Ordinal(10)] [RED("streetCredBarSpacer")] public inkWidgetReference StreetCredBarSpacer { get; set; }
		[Ordinal(11)] [RED("menuselectorWidget")] public inkWidgetReference MenuselectorWidget { get; set; }
		[Ordinal(12)] [RED("subMenuselectorWidget")] public inkWidgetReference SubMenuselectorWidget { get; set; }
		[Ordinal(13)] [RED("topPanel")] public inkWidgetReference TopPanel { get; set; }
		[Ordinal(14)] [RED("leftHolder")] public inkWidgetReference LeftHolder { get; set; }
		[Ordinal(15)] [RED("rightHolder")] public inkWidgetReference RightHolder { get; set; }
		[Ordinal(16)] [RED("lineBarsContainer")] public inkCompoundWidgetReference LineBarsContainer { get; set; }
		[Ordinal(17)] [RED("lineWidget")] public inkCompoundWidgetReference LineWidget { get; set; }
		[Ordinal(18)] [RED("menusList")] public CArray<MenuData> MenusList { get; set; }
		[Ordinal(19)] [RED("menuSelectorCtrl")] public wCHandle<hubSelectorSingleCarouselController> MenuSelectorCtrl { get; set; }
		[Ordinal(20)] [RED("subMenuActive")] public CBool SubMenuActive { get; set; }
		[Ordinal(21)] [RED("previousLineBar")] public wCHandle<inkWidget> PreviousLineBar { get; set; }
		[Ordinal(22)] [RED("IsSetActive")] public CBool IsSetActive { get; set; }
		[Ordinal(23)] [RED("selectorMode")] public CBool SelectorMode { get; set; }
		[Ordinal(24)] [RED("menusData")] public CHandle<MenuDataBuilder> MenusData { get; set; }
		[Ordinal(25)] [RED("curMenuData")] public MenuData CurMenuData { get; set; }
		[Ordinal(26)] [RED("curSubMenuData")] public MenuData CurSubMenuData { get; set; }

		public SubMenuPanelLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SubMenuPanelLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("IsSetActive")] public CBool IsSetActive { get; set; }
		[Ordinal(1)]  [RED("centralLine")] public inkWidgetReference CentralLine { get; set; }
		[Ordinal(2)]  [RED("curMenuData")] public MenuData CurMenuData { get; set; }
		[Ordinal(3)]  [RED("curSubMenuData")] public MenuData CurSubMenuData { get; set; }
		[Ordinal(4)]  [RED("currencyValue")] public inkTextWidgetReference CurrencyValue { get; set; }
		[Ordinal(5)]  [RED("leftHolder")] public inkWidgetReference LeftHolder { get; set; }
		[Ordinal(6)]  [RED("levelBarProgress")] public inkWidgetReference LevelBarProgress { get; set; }
		[Ordinal(7)]  [RED("levelBarSpacer")] public inkWidgetReference LevelBarSpacer { get; set; }
		[Ordinal(8)]  [RED("levelValue")] public inkTextWidgetReference LevelValue { get; set; }
		[Ordinal(9)]  [RED("lineBarsContainer")] public inkCompoundWidgetReference LineBarsContainer { get; set; }
		[Ordinal(10)]  [RED("lineWidget")] public inkCompoundWidgetReference LineWidget { get; set; }
		[Ordinal(11)]  [RED("menuSelectorCtrl")] public wCHandle<hubSelectorSingleCarouselController> MenuSelectorCtrl { get; set; }
		[Ordinal(12)]  [RED("menusData")] public CHandle<MenuDataBuilder> MenusData { get; set; }
		[Ordinal(13)]  [RED("menusList")] public CArray<MenuData> MenusList { get; set; }
		[Ordinal(14)]  [RED("menuselectorWidget")] public inkWidgetReference MenuselectorWidget { get; set; }
		[Ordinal(15)]  [RED("previousLineBar")] public wCHandle<inkWidget> PreviousLineBar { get; set; }
		[Ordinal(16)]  [RED("rightHolder")] public inkWidgetReference RightHolder { get; set; }
		[Ordinal(17)]  [RED("selectorMode")] public CBool SelectorMode { get; set; }
		[Ordinal(18)]  [RED("streetCredBarProgress")] public inkWidgetReference StreetCredBarProgress { get; set; }
		[Ordinal(19)]  [RED("streetCredBarSpacer")] public inkWidgetReference StreetCredBarSpacer { get; set; }
		[Ordinal(20)]  [RED("streetCredLabel")] public inkTextWidgetReference StreetCredLabel { get; set; }
		[Ordinal(21)]  [RED("subMenuActive")] public CBool SubMenuActive { get; set; }
		[Ordinal(22)]  [RED("subMenuLabel")] public inkTextWidgetReference SubMenuLabel { get; set; }
		[Ordinal(23)]  [RED("subMenuselectorWidget")] public inkWidgetReference SubMenuselectorWidget { get; set; }
		[Ordinal(24)]  [RED("topPanel")] public inkWidgetReference TopPanel { get; set; }
		[Ordinal(25)]  [RED("weightValue")] public inkTextWidgetReference WeightValue { get; set; }

		public SubMenuPanelLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

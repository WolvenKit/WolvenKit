using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hubSelectorSingleCarouselController : inkSelectorController
	{
		[Ordinal(10)]  [RED("NUMBER_OF_WIDGETS")] public CInt32 NUMBER_OF_WIDGETS { get; set; }
		[Ordinal(11)]  [RED("WIDGETS_PADDING")] public CFloat WIDGETS_PADDING { get; set; }
		[Ordinal(12)]  [RED("SMALL_WIDGET_SCALE")] public CFloat SMALL_WIDGET_SCALE { get; set; }
		[Ordinal(13)]  [RED("SMALL_WIDGET_OPACITY")] public CFloat SMALL_WIDGET_OPACITY { get; set; }
		[Ordinal(14)]  [RED("ANIMATION_TIME")] public CFloat ANIMATION_TIME { get; set; }
		[Ordinal(15)]  [RED("DEFAULT_WIDGET_COLOR")] public HDRColor DEFAULT_WIDGET_COLOR { get; set; }
		[Ordinal(16)]  [RED("SELECTED_WIDGET_COLOR")] public HDRColor SELECTED_WIDGET_COLOR { get; set; }
		[Ordinal(17)]  [RED("leftArrowWidget")] public inkWidgetReference LeftArrowWidget { get; set; }
		[Ordinal(18)]  [RED("rightArrowWidget")] public inkWidgetReference RightArrowWidget { get; set; }
		[Ordinal(19)]  [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(20)]  [RED("defaultColorDummy")] public inkWidgetReference DefaultColorDummy { get; set; }
		[Ordinal(21)]  [RED("activeColorDummy")] public inkWidgetReference ActiveColorDummy { get; set; }
		[Ordinal(22)]  [RED("leftArrowController")] public CHandle<inkInputDisplayController> LeftArrowController { get; set; }
		[Ordinal(23)]  [RED("rightArrowController")] public CHandle<inkInputDisplayController> RightArrowController { get; set; }
		[Ordinal(24)]  [RED("elements")] public CArray<MenuData> Elements { get; set; }
		[Ordinal(25)]  [RED("centerElementIndex")] public CInt32 CenterElementIndex { get; set; }
		[Ordinal(26)]  [RED("widgetsControllers")] public CArray<CHandle<HubMenuLabelContentContainer>> WidgetsControllers { get; set; }
		[Ordinal(27)]  [RED("waitForSizes")] public CBool WaitForSizes { get; set; }
		[Ordinal(28)]  [RED("translationOnce")] public CBool TranslationOnce { get; set; }
		[Ordinal(29)]  [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }
		[Ordinal(30)]  [RED("activeAnimations")] public CArray<CHandle<inkanimProxy>> ActiveAnimations { get; set; }

		public hubSelectorSingleCarouselController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

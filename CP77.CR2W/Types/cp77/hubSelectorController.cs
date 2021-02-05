using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hubSelectorController : inkSelectorController
	{
		[Ordinal(0)]  [RED("labelPath")] public CName LabelPath { get; set; }
		[Ordinal(1)]  [RED("valuePath")] public CName ValuePath { get; set; }
		[Ordinal(2)]  [RED("leftArrowPath")] public CName LeftArrowPath { get; set; }
		[Ordinal(3)]  [RED("rightArrowPath")] public CName RightArrowPath { get; set; }
		[Ordinal(4)]  [RED("label")] public wCHandle<inkTextWidget> Label { get; set; }
		[Ordinal(5)]  [RED("value")] public wCHandle<inkTextWidget> Value { get; set; }
		[Ordinal(6)]  [RED("leftArrow")] public wCHandle<inkWidget> LeftArrow { get; set; }
		[Ordinal(7)]  [RED("rightArrow")] public wCHandle<inkWidget> RightArrow { get; set; }
		[Ordinal(8)]  [RED("rightArrowButton")] public wCHandle<inkButtonController> RightArrowButton { get; set; }
		[Ordinal(9)]  [RED("leftArrowButton")] public wCHandle<inkButtonController> LeftArrowButton { get; set; }
		[Ordinal(10)]  [RED("leftArrowWidget")] public inkWidgetReference LeftArrowWidget { get; set; }
		[Ordinal(11)]  [RED("rightArrowWidget")] public inkWidgetReference RightArrowWidget { get; set; }
		[Ordinal(12)]  [RED("menuLabelHolder")] public inkHorizontalPanelWidgetReference MenuLabelHolder { get; set; }
		[Ordinal(13)]  [RED("selectedMenuLabel")] public wCHandle<HubMenuLabelController> SelectedMenuLabel { get; set; }
		[Ordinal(14)]  [RED("previouslySelectedMenuLabel")] public wCHandle<HubMenuLabelController> PreviouslySelectedMenuLabel { get; set; }
		[Ordinal(15)]  [RED("hubElementsData")] public CArray<MenuData> HubElementsData { get; set; }
		[Ordinal(16)]  [RED("previousIndex")] public CInt32 PreviousIndex { get; set; }

		public hubSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

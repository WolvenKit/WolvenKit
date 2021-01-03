using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkSelectorController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("SelectionChanged")] public inkSelectionChangeCallback SelectionChanged { get; set; }
		[Ordinal(1)]  [RED("cycledNavigation")] public CBool CycledNavigation { get; set; }
		[Ordinal(2)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(3)]  [RED("label")] public wCHandle<inkTextWidget> Label { get; set; }
		[Ordinal(4)]  [RED("labelPath")] public CName LabelPath { get; set; }
		[Ordinal(5)]  [RED("leftArrow")] public wCHandle<inkWidget> LeftArrow { get; set; }
		[Ordinal(6)]  [RED("leftArrowButton")] public wCHandle<inkButtonController> LeftArrowButton { get; set; }
		[Ordinal(7)]  [RED("leftArrowPath")] public CName LeftArrowPath { get; set; }
		[Ordinal(8)]  [RED("rightArrow")] public wCHandle<inkWidget> RightArrow { get; set; }
		[Ordinal(9)]  [RED("rightArrowButton")] public wCHandle<inkButtonController> RightArrowButton { get; set; }
		[Ordinal(10)]  [RED("rightArrowPath")] public CName RightArrowPath { get; set; }
		[Ordinal(11)]  [RED("value")] public wCHandle<inkTextWidget> Value { get; set; }
		[Ordinal(12)]  [RED("valuePath")] public CName ValuePath { get; set; }
		[Ordinal(13)]  [RED("values")] public CArray<CString> Values { get; set; }

		public inkSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

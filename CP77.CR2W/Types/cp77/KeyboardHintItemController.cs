using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KeyboardHintItemController : AHintItemController
	{
		[Ordinal(0)]  [RED("Icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(1)]  [RED("UnavaliableText")] public inkTextWidgetReference UnavaliableText { get; set; }
		[Ordinal(2)]  [RED("Root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(3)]  [RED("NumberText")] public inkTextWidgetReference NumberText { get; set; }
		[Ordinal(4)]  [RED("Frame")] public inkImageWidgetReference Frame { get; set; }
		[Ordinal(5)]  [RED("DisabledStateName")] public CName DisabledStateName { get; set; }
		[Ordinal(6)]  [RED("SelectedStateName")] public CName SelectedStateName { get; set; }
		[Ordinal(7)]  [RED("FrameSelectedName")] public CName FrameSelectedName { get; set; }
		[Ordinal(8)]  [RED("FrameUnselectedName")] public CName FrameUnselectedName { get; set; }
		[Ordinal(9)]  [RED("AnimationName")] public CName AnimationName { get; set; }

		public KeyboardHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KeyboardHintItemController : AHintItemController
	{
		[Ordinal(4)] [RED("NumberText")] public inkTextWidgetReference NumberText { get; set; }
		[Ordinal(5)] [RED("Frame")] public inkImageWidgetReference Frame { get; set; }
		[Ordinal(6)] [RED("DisabledStateName")] public CName DisabledStateName { get; set; }
		[Ordinal(7)] [RED("SelectedStateName")] public CName SelectedStateName { get; set; }
		[Ordinal(8)] [RED("FrameSelectedName")] public CName FrameSelectedName { get; set; }
		[Ordinal(9)] [RED("FrameUnselectedName")] public CName FrameUnselectedName { get; set; }
		[Ordinal(10)] [RED("AnimationName")] public CName AnimationName { get; set; }

		public KeyboardHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

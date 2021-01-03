using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class KeyboardHintItemController : AHintItemController
	{
		[Ordinal(0)]  [RED("AnimationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("DisabledStateName")] public CName DisabledStateName { get; set; }
		[Ordinal(2)]  [RED("Frame")] public inkImageWidgetReference Frame { get; set; }
		[Ordinal(3)]  [RED("FrameSelectedName")] public CName FrameSelectedName { get; set; }
		[Ordinal(4)]  [RED("FrameUnselectedName")] public CName FrameUnselectedName { get; set; }
		[Ordinal(5)]  [RED("NumberText")] public inkTextWidgetReference NumberText { get; set; }
		[Ordinal(6)]  [RED("SelectedStateName")] public CName SelectedStateName { get; set; }

		public KeyboardHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

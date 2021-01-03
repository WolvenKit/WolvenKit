using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintData : CVariable
	{
		[Ordinal(0)]  [RED("action")] public CName Action { get; set; }
		[Ordinal(1)]  [RED("enableHoldAnimation")] public CBool EnableHoldAnimation { get; set; }
		[Ordinal(2)]  [RED("groupId")] public CName GroupId { get; set; }
		[Ordinal(3)]  [RED("holdIndicationType")] public CEnum<inkInputHintHoldIndicationType> HoldIndicationType { get; set; }
		[Ordinal(4)]  [RED("localizedLabel")] public CString LocalizedLabel { get; set; }
		[Ordinal(5)]  [RED("queuePriority")] public CInt32 QueuePriority { get; set; }
		[Ordinal(6)]  [RED("sortingPriority")] public CInt32 SortingPriority { get; set; }
		[Ordinal(7)]  [RED("source")] public CName Source { get; set; }
		[Ordinal(8)]  [RED("tutorialAction")] public CName TutorialAction { get; set; }
		[Ordinal(9)]  [RED("tutorialActionCount")] public CInt32 TutorialActionCount { get; set; }

		public gameuiInputHintData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

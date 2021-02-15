using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SCodexRecordPart : CVariable
	{
		[Ordinal(0)] [RED("PartName")] public CName PartName { get; set; }
		[Ordinal(1)] [RED("PartContent")] public CString PartContent { get; set; }
		[Ordinal(2)] [RED("Unlocked")] public CBool Unlocked { get; set; }

		public SCodexRecordPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

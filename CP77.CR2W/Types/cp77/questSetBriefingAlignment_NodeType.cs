using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetBriefingAlignment_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("briefingAlignment")] public CEnum<questJournalAlignmentEventType> BriefingAlignment { get; set; }

		public questSetBriefingAlignment_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

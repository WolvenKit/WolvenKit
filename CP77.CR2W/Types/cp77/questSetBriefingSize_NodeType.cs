using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetBriefingSize_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("briefingSize")] public CEnum<questJournalSizeEventType> BriefingSize { get; set; }

		public questSetBriefingSize_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MetaQuestStatus : CVariable
	{
		[Ordinal(0)] [RED("MetaQuest1Hidden")] public CBool MetaQuest1Hidden { get; set; }
		[Ordinal(1)] [RED("MetaQuest1Value")] public CInt32 MetaQuest1Value { get; set; }
		[Ordinal(2)] [RED("MetaQuest1Description")] public CString MetaQuest1Description { get; set; }
		[Ordinal(3)] [RED("MetaQuest2Hidden")] public CBool MetaQuest2Hidden { get; set; }
		[Ordinal(4)] [RED("MetaQuest2Description")] public CString MetaQuest2Description { get; set; }
		[Ordinal(5)] [RED("MetaQuest2Value")] public CInt32 MetaQuest2Value { get; set; }
		[Ordinal(6)] [RED("MetaQuest3Hidden")] public CBool MetaQuest3Hidden { get; set; }
		[Ordinal(7)] [RED("MetaQuest3Description")] public CString MetaQuest3Description { get; set; }
		[Ordinal(8)] [RED("MetaQuest3Value")] public CInt32 MetaQuest3Value { get; set; }

		public MetaQuestStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

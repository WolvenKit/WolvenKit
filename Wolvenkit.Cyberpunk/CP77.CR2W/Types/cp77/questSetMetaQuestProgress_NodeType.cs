using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetMetaQuestProgress_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("metaQuestId")] public CEnum<gamedataMetaQuest> MetaQuestId { get; set; }
		[Ordinal(1)]  [RED("percent")] public CUInt32 Percent { get; set; }
		[Ordinal(2)]  [RED("text")] public LocalizationString Text { get; set; }

		public questSetMetaQuestProgress_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

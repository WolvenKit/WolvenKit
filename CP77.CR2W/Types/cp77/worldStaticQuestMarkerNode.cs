using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticQuestMarkerNode : worldNode
	{
		[Ordinal(0)]  [RED("questType")] public CEnum<worldQuestType> QuestType { get; set; }
		[Ordinal(1)]  [RED("questLabel")] public CString QuestLabel { get; set; }
		[Ordinal(2)]  [RED("questMarkerHeight")] public CFloat QuestMarkerHeight { get; set; }

		public worldStaticQuestMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

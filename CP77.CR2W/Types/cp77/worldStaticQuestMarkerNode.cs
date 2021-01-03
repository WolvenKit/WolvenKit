using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStaticQuestMarkerNode : worldNode
	{
		[Ordinal(0)]  [RED("questLabel")] public CString QuestLabel { get; set; }
		[Ordinal(1)]  [RED("questMarkerHeight")] public CFloat QuestMarkerHeight { get; set; }
		[Ordinal(2)]  [RED("questType")] public CEnum<worldQuestType> QuestType { get; set; }

		public worldStaticQuestMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

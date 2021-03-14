using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticQuestMarkerNode : worldNode
	{
		[Ordinal(4)] [RED("questType")] public CEnum<worldQuestType> QuestType { get; set; }
		[Ordinal(5)] [RED("questLabel")] public CString QuestLabel { get; set; }
		[Ordinal(6)] [RED("questMarkerHeight")] public CFloat QuestMarkerHeight { get; set; }

		public worldStaticQuestMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

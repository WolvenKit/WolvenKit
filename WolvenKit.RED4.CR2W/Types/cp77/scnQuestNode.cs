using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnQuestNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("questNode")] public CHandle<questNodeDefinition> QuestNode { get; set; }
		[Ordinal(4)] [RED("isockMappings")] public CArray<CName> IsockMappings { get; set; }
		[Ordinal(5)] [RED("osockMappings")] public CArray<CName> OsockMappings { get; set; }

		public scnQuestNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

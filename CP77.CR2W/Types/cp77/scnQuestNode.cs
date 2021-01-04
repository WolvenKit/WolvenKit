using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnQuestNode : scnSceneGraphNode
	{
		[Ordinal(0)]  [RED("isockMappings")] public CArray<CName> IsockMappings { get; set; }
		[Ordinal(1)]  [RED("osockMappings")] public CArray<CName> OsockMappings { get; set; }
		[Ordinal(2)]  [RED("questNode")] public CHandle<questNodeDefinition> QuestNode { get; set; }

		public scnQuestNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

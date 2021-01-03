using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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

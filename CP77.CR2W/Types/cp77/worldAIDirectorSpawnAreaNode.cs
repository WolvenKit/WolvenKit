using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] [RED("groupKey")] public CName GroupKey { get; set; }

		public worldAIDirectorSpawnAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

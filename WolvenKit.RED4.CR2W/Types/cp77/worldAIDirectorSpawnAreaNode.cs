using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] [RED("groupKey")] public CName GroupKey { get; set; }

		public worldAIDirectorSpawnAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("groupKey")] public CName GroupKey { get; set; }

		public worldAIDirectorSpawnAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

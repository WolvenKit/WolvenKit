using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class graphGraphDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)] [RED("nodes")] public CArray<CHandle<graphGraphNodeDefinition>> Nodes { get; set; }

		public graphGraphDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

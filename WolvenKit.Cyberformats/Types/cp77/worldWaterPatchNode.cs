using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNode : worldMeshNode
	{
		[Ordinal(15)] [RED("type")] public worldWaterPatchNodeType Type { get; set; }
		[Ordinal(16)] [RED("depth")] public CFloat Depth { get; set; }

		public worldWaterPatchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

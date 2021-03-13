using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNode : worldMeshNode
	{
		[Ordinal(15)] [RED("type")] public worldWaterPatchNodeType Type { get; set; }
		[Ordinal(16)] [RED("depth")] public CFloat Depth { get; set; }

		public worldWaterPatchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

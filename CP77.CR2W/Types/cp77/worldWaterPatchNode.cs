using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNode : worldMeshNode
	{
		[Ordinal(0)]  [RED("depth")] public CFloat Depth { get; set; }
		[Ordinal(1)]  [RED("type")] public worldWaterPatchNodeType Type { get; set; }

		public worldWaterPatchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapDataNode : worldNode
	{
		[Ordinal(4)] [RED("encodedShapesRef")] public raRef<minimapEncodedShapes> EncodedShapesRef { get; set; }
		[Ordinal(5)] [RED("localBounds")] public Box LocalBounds { get; set; }
		[Ordinal(6)] [RED("allInteriorShapes")] public CBool AllInteriorShapes { get; set; }

		public MinimapDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MinimapDataNode : worldNode
	{
		[Ordinal(0)]  [RED("allInteriorShapes")] public CBool AllInteriorShapes { get; set; }
		[Ordinal(1)]  [RED("encodedShapesRef")] public raRef<minimapEncodedShapes> EncodedShapesRef { get; set; }
		[Ordinal(2)]  [RED("localBounds")] public Box LocalBounds { get; set; }

		public MinimapDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

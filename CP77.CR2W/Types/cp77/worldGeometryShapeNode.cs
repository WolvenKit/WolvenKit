using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldGeometryShapeNode : worldNode
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(1)]  [RED("shape")] public CHandle<GeometryShape> Shape { get; set; }

		public worldGeometryShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

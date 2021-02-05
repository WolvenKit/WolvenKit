using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkBaseShapeWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("vertexList")] public CArray<Vector2> VertexList { get; set; }

		public inkBaseShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

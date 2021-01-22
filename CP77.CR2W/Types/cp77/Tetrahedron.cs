using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Tetrahedron : CVariable
	{
		[Ordinal(0)]  [RED("point1")] public Vector4 Point1 { get; set; }
		[Ordinal(1)]  [RED("point2")] public Vector4 Point2 { get; set; }
		[Ordinal(2)]  [RED("point3")] public Vector4 Point3 { get; set; }
		[Ordinal(3)]  [RED("point4")] public Vector4 Point4 { get; set; }

		public Tetrahedron(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

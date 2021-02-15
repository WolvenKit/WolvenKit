using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePolygonRepresentation : CVariable
	{
		[Ordinal(0)] [RED("outline")] public CArray<Vector3> Outline { get; set; }
		[Ordinal(1)] [RED("polygon")] public CArray<Vector2> Polygon { get; set; }

		public worldTrafficLanePolygonRepresentation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

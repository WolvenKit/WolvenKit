using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsPieDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("baseLength")] public CFloat BaseLength { get; set; }
		[Ordinal(2)]  [RED("center")] public Vector4 Center { get; set; }
		[Ordinal(3)]  [RED("halfExtentZ")] public CFloat HalfExtentZ { get; set; }
		[Ordinal(4)]  [RED("radius")] public CFloat Radius { get; set; }

		public gameinteractionsPieDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

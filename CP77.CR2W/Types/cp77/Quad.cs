using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Quad : CVariable
	{
		[Ordinal(0)] [RED("p1")] public Vector4 P1 { get; set; }
		[Ordinal(1)] [RED("p2")] public Vector4 P2 { get; set; }
		[Ordinal(2)] [RED("p3")] public Vector4 P3 { get; set; }
		[Ordinal(3)] [RED("p4")] public Vector4 P4 { get; set; }

		public Quad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

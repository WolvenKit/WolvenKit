using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseSimpleCone : senseIShape
	{
		[Ordinal(0)]  [RED("position1")] public Vector4 Position1 { get; set; }
		[Ordinal(1)]  [RED("position2")] public Vector4 Position2 { get; set; }
		[Ordinal(2)]  [RED("radius1")] public CFloat Radius1 { get; set; }
		[Ordinal(3)]  [RED("radius2")] public CFloat Radius2 { get; set; }

		public senseSimpleCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

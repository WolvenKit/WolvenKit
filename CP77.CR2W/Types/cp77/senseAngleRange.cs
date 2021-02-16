using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseAngleRange : senseIShape
	{
		[Ordinal(1)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)] [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(3)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(4)] [RED("halfHeight")] public CFloat HalfHeight { get; set; }

		public senseAngleRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

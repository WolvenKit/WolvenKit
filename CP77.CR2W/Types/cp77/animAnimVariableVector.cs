using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableVector : animAnimVariable
	{
		[Ordinal(1)] [RED("x")] public CFloat X { get; set; }
		[Ordinal(2)] [RED("y")] public CFloat Y { get; set; }
		[Ordinal(3)] [RED("z")] public CFloat Z { get; set; }
		[Ordinal(4)] [RED("w")] public CFloat W { get; set; }
		[Ordinal(5)] [RED("default")] public Vector4 Default { get; set; }
		[Ordinal(6)] [RED("min")] public Vector4 Min { get; set; }
		[Ordinal(7)] [RED("max")] public Vector4 Max { get; set; }

		public animAnimVariableVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableInt : animAnimVariable
	{
		[Ordinal(0)]  [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(1)]  [RED("default")] public CInt32 Default { get; set; }
		[Ordinal(2)]  [RED("min")] public CInt32 Min { get; set; }
		[Ordinal(3)]  [RED("max")] public CInt32 Max { get; set; }

		public animAnimVariableInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

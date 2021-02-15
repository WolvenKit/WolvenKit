using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableFloat : animAnimVariable
	{
		[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(2)] [RED("default")] public CFloat Default { get; set; }
		[Ordinal(3)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(4)] [RED("max")] public CFloat Max { get; set; }

		public animAnimVariableFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CompareBuilder : IScriptable
	{
		[Ordinal(0)]  [RED("FLOAT_EQUAL_EPSILON")] public CFloat FLOAT_EQUAL_EPSILON { get; set; }
		[Ordinal(1)]  [RED("value")] public CInt32 Value { get; set; }

		public CompareBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopUint64Pair : CVariable
	{
		[Ordinal(0)]  [RED("first")] public CUInt64 First { get; set; }
		[Ordinal(1)]  [RED("second")] public CUInt64 Second { get; set; }

		public interopUint64Pair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

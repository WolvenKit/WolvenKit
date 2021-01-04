using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopStringUint64Pair : CVariable
	{
		[Ordinal(0)]  [RED("number")] public CUInt64 Number { get; set; }
		[Ordinal(1)]  [RED("string")] public CString String { get; set; }

		public interopStringUint64Pair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

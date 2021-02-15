using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class netTime : CVariable
	{
		[Ordinal(0)] [RED("milliSecs")] public CUInt64 MilliSecs { get; set; }

		public netTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

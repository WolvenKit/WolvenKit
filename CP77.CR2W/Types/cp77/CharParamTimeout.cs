using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharParamTimeout : AITimeoutCondition
	{
		[Ordinal(0)]  [RED("timestamp")] public CFloat Timestamp { get; set; }
		[Ordinal(1)]  [RED("timeoutParamName")] public CString TimeoutParamName { get; set; }

		public CharParamTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

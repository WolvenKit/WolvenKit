using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MappingTimeout : AITimeoutCondition
	{
		[Ordinal(1)]  [RED("timeoutMapping")] public CHandle<AIArgumentMapping> TimeoutMapping { get; set; }
		[Ordinal(2)]  [RED("timeoutValue")] public CFloat TimeoutValue { get; set; }

		public MappingTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

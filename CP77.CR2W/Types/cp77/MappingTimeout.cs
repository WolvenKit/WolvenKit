using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MappingTimeout : AITimeoutCondition
	{
		[Ordinal(0)]  [RED("timeoutMapping")] public CHandle<AIArgumentMapping> TimeoutMapping { get; set; }
		[Ordinal(1)]  [RED("timeoutValue")] public CFloat TimeoutValue { get; set; }

		public MappingTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

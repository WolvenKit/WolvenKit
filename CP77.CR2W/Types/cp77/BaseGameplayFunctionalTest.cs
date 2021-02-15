using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseGameplayFunctionalTest : IScriptable
	{
		[Ordinal(0)] [RED("maxExecutionTimeSec")] public CFloat MaxExecutionTimeSec { get; set; }
		[Ordinal(1)] [RED("executionTimeSec")] public CFloat ExecutionTimeSec { get; set; }

		public BaseGameplayFunctionalTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

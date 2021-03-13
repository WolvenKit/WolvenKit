using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseGameplayFunctionalTest : IScriptable
	{
		[Ordinal(0)] [RED("maxExecutionTimeSec")] public CFloat MaxExecutionTimeSec { get; set; }
		[Ordinal(1)] [RED("executionTimeSec")] public CFloat ExecutionTimeSec { get; set; }

		public BaseGameplayFunctionalTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

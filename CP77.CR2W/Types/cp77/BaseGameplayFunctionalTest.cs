using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseGameplayFunctionalTest : IScriptable
	{
		[Ordinal(0)]  [RED("executionTimeSec")] public CFloat ExecutionTimeSec { get; set; }
		[Ordinal(1)]  [RED("maxExecutionTimeSec")] public CFloat MaxExecutionTimeSec { get; set; }

		public BaseGameplayFunctionalTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

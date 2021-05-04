using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseGameplayFunctionalTest : IScriptable
	{
		private CFloat _maxExecutionTimeSec;
		private CFloat _executionTimeSec;

		[Ordinal(0)] 
		[RED("maxExecutionTimeSec")] 
		public CFloat MaxExecutionTimeSec
		{
			get => GetProperty(ref _maxExecutionTimeSec);
			set => SetProperty(ref _maxExecutionTimeSec, value);
		}

		[Ordinal(1)] 
		[RED("executionTimeSec")] 
		public CFloat ExecutionTimeSec
		{
			get => GetProperty(ref _executionTimeSec);
			set => SetProperty(ref _executionTimeSec, value);
		}

		public BaseGameplayFunctionalTest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

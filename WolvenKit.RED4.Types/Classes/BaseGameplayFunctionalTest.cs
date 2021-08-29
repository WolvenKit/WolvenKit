using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseGameplayFunctionalTest : IScriptable
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
	}
}

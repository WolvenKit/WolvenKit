using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseGameplayFunctionalTest : IScriptable
	{
		[Ordinal(0)] 
		[RED("maxExecutionTimeSec")] 
		public CFloat MaxExecutionTimeSec
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("executionTimeSec")] 
		public CFloat ExecutionTimeSec
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}

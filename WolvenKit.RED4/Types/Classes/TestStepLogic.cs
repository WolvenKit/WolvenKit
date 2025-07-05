using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TestStepLogic : IScriptable
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

		[Ordinal(2)] 
		[RED("paramsData")] 
		public CArray<ParamData> ParamsData
		{
			get => GetPropertyValue<CArray<ParamData>>();
			set => SetPropertyValue<CArray<ParamData>>(value);
		}

		public TestStepLogic()
		{
			MaxExecutionTimeSec = 250.000000F;
			ParamsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

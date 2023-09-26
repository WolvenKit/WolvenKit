using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TestStep : IScriptable
	{
		[Ordinal(0)] 
		[RED("stepName")] 
		public CName StepName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("scriptId")] 
		public CUInt16 ScriptId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("reproStep")] 
		public CString ReproStep
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("args")] 
		public CArray<CVariant> Args
		{
			get => GetPropertyValue<CArray<CVariant>>();
			set => SetPropertyValue<CArray<CVariant>>(value);
		}

		[Ordinal(4)] 
		[RED("stepTimeout")] 
		public CFloat StepTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("stopTestOnFailure")] 
		public CBool StopTestOnFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TestStep()
		{
			Args = new();
			StepTimeout = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectEffectParameterEvaluatorColor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<IEvaluatorColor> Evaluator
		{
			get => GetPropertyValue<CHandle<IEvaluatorColor>>();
			set => SetPropertyValue<CHandle<IEvaluatorColor>>(value);
		}

		[Ordinal(1)] 
		[RED("inputParameterOverride")] 
		public CName InputParameterOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}

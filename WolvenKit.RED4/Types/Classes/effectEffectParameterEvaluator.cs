using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectEffectParameterEvaluator : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<IEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<IEvaluator>>();
			set => SetPropertyValue<CHandle<IEvaluator>>(value);
		}

		[Ordinal(1)] 
		[RED("inputParameterOverride")] 
		public CName InputParameterOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public effectEffectParameterEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

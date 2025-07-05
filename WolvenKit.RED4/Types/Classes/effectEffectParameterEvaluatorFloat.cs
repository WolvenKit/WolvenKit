using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectEffectParameterEvaluatorFloat : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<IEvaluatorFloat> Evaluator
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("inputParameterOverride")] 
		public CName InputParameterOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("inputParameterIsPostMultiplier")] 
		public CBool InputParameterIsPostMultiplier
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public effectEffectParameterEvaluatorFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

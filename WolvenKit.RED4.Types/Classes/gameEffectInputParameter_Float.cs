using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectInputParameter_Float : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_FloatEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_FloatEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_FloatEvaluator>>(value);
		}

		public gameEffectInputParameter_Float()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

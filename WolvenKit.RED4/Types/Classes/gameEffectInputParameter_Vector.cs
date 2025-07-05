using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectInputParameter_Vector : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_VectorEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_VectorEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_VectorEvaluator>>(value);
		}

		public gameEffectInputParameter_Vector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

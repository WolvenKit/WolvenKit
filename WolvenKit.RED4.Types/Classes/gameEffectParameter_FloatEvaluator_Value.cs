using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_FloatEvaluator_Value : gameIEffectParameter_FloatEvaluator
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectParameter_FloatEvaluator_Value()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

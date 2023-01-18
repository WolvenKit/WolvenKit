using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_BoolEvaluator_Value : gameIEffectParameter_BoolEvaluator
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectParameter_BoolEvaluator_Value()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

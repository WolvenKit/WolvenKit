using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_QuatEvaluator_Value : gameIEffectParameter_QuatEvaluator
	{
		[Ordinal(0)] 
		[RED("value")] 
		public Quaternion Value
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public gameEffectParameter_QuatEvaluator_Value()
		{
			Value = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

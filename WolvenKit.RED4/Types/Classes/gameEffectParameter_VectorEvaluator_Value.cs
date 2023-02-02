using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_VectorEvaluator_Value : gameIEffectParameter_VectorEvaluator
	{
		[Ordinal(0)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameEffectParameter_VectorEvaluator_Value()
		{
			Value = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimScaleInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] 
		[RED("startValue")] 
		public Vector2 StartValue
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public Vector2 EndValue
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public inkanimScaleInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;
			StartValue = new();
			EndValue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

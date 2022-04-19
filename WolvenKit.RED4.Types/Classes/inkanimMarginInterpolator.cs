using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimMarginInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] 
		[RED("startValue")] 
		public inkMargin StartValue
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public inkMargin EndValue
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public inkanimMarginInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;
			StartValue = new();
			EndValue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

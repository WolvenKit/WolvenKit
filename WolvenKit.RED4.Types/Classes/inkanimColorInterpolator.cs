using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimColorInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] 
		[RED("startValue")] 
		public HDRColor StartValue
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public HDRColor EndValue
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public inkanimColorInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;
			StartValue = new();
			EndValue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

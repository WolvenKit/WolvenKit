using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGradientWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] 
		[RED("gradientMode")] 
		public CEnum<inkGradientMode> GradientMode
		{
			get => GetPropertyValue<CEnum<inkGradientMode>>();
			set => SetPropertyValue<CEnum<inkGradientMode>>(value);
		}

		[Ordinal(21)] 
		[RED("startColor")] 
		public HDRColor StartColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(22)] 
		[RED("endColor")] 
		public HDRColor EndColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(23)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkGradientWidget()
		{
			StartColor = new HDRColor { Alpha = 1.000000F };
			EndColor = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

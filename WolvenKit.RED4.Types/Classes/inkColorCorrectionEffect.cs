using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkColorCorrectionEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("brightness")] 
		public CFloat Brightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkColorCorrectionEffect()
		{
			Brightness = 1.000000F;
			Contrast = 1.000000F;
			Saturation = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkBoxBlurEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("samples")] 
		public CUInt8 Samples
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("blurDimension")] 
		public CEnum<inkEBlurDimension> BlurDimension
		{
			get => GetPropertyValue<CEnum<inkEBlurDimension>>();
			set => SetPropertyValue<CEnum<inkEBlurDimension>>(value);
		}

		public inkBoxBlurEffect()
		{
			Samples = 10;
			Intensity = 0.050000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

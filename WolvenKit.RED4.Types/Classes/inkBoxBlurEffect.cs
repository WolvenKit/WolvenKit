using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBoxBlurEffect : inkIEffect
	{
		private CUInt8 _samples;
		private CFloat _intensity;
		private CEnum<inkEBlurDimension> _blurDimension;

		[Ordinal(2)] 
		[RED("samples")] 
		public CUInt8 Samples
		{
			get => GetProperty(ref _samples);
			set => SetProperty(ref _samples, value);
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(4)] 
		[RED("blurDimension")] 
		public CEnum<inkEBlurDimension> BlurDimension
		{
			get => GetProperty(ref _blurDimension);
			set => SetProperty(ref _blurDimension, value);
		}

		public inkBoxBlurEffect()
		{
			_samples = 10;
			_intensity = 0.050000F;
		}
	}
}

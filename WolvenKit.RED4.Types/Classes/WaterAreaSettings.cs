using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaterAreaSettings : IAreaSettings
	{
		private CFloat _blurMin;
		private CFloat _blurMax;
		private CFloat _blurExponent;
		private CFloat _depth;
		private CFloat _density;
		private HDRColor _lightAbsorptionColor;
		private HDRColor _lightDecayColor;
		private CResourceReference<CBitmapTexture> _globalWaterMask;

		[Ordinal(2)] 
		[RED("blurMin")] 
		public CFloat BlurMin
		{
			get => GetProperty(ref _blurMin);
			set => SetProperty(ref _blurMin, value);
		}

		[Ordinal(3)] 
		[RED("blurMax")] 
		public CFloat BlurMax
		{
			get => GetProperty(ref _blurMax);
			set => SetProperty(ref _blurMax, value);
		}

		[Ordinal(4)] 
		[RED("blurExponent")] 
		public CFloat BlurExponent
		{
			get => GetProperty(ref _blurExponent);
			set => SetProperty(ref _blurExponent, value);
		}

		[Ordinal(5)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(7)] 
		[RED("lightAbsorptionColor")] 
		public HDRColor LightAbsorptionColor
		{
			get => GetProperty(ref _lightAbsorptionColor);
			set => SetProperty(ref _lightAbsorptionColor, value);
		}

		[Ordinal(8)] 
		[RED("lightDecayColor")] 
		public HDRColor LightDecayColor
		{
			get => GetProperty(ref _lightDecayColor);
			set => SetProperty(ref _lightDecayColor, value);
		}

		[Ordinal(9)] 
		[RED("globalWaterMask")] 
		public CResourceReference<CBitmapTexture> GlobalWaterMask
		{
			get => GetProperty(ref _globalWaterMask);
			set => SetProperty(ref _globalWaterMask, value);
		}

		public WaterAreaSettings()
		{
			_blurMax = 10.000000F;
			_blurExponent = 1.000000F;
			_depth = 50.000000F;
			_density = 10.000000F;
		}
	}
}

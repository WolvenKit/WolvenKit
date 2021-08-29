using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistantFogAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _range;
		private CLegacySingleChannelCurve<HDRColor> _albedoNear;
		private CLegacySingleChannelCurve<HDRColor> _albedoFar;
		private CLegacySingleChannelCurve<CFloat> _nearDistance;
		private CLegacySingleChannelCurve<CFloat> _farDistance;
		private CLegacySingleChannelCurve<CFloat> _density;
		private CLegacySingleChannelCurve<CFloat> _height;
		private CLegacySingleChannelCurve<CFloat> _heightFallof;
		private CLegacySingleChannelCurve<CFloat> _densitySecond;
		private CLegacySingleChannelCurve<CFloat> _heightSecond;
		private CLegacySingleChannelCurve<CFloat> _heightFallofSecond;
		private CLegacySingleChannelCurve<HDRColor> _simpleColor;
		private CLegacySingleChannelCurve<CFloat> _simpleDensity;
		private CLegacySingleChannelCurve<HDRColor> _envProbeColor;
		private CLegacySingleChannelCurve<CFloat> _envProbeDensity;

		[Ordinal(2)] 
		[RED("range")] 
		public CLegacySingleChannelCurve<CFloat> Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(3)] 
		[RED("albedoNear")] 
		public CLegacySingleChannelCurve<HDRColor> AlbedoNear
		{
			get => GetProperty(ref _albedoNear);
			set => SetProperty(ref _albedoNear, value);
		}

		[Ordinal(4)] 
		[RED("albedoFar")] 
		public CLegacySingleChannelCurve<HDRColor> AlbedoFar
		{
			get => GetProperty(ref _albedoFar);
			set => SetProperty(ref _albedoFar, value);
		}

		[Ordinal(5)] 
		[RED("nearDistance")] 
		public CLegacySingleChannelCurve<CFloat> NearDistance
		{
			get => GetProperty(ref _nearDistance);
			set => SetProperty(ref _nearDistance, value);
		}

		[Ordinal(6)] 
		[RED("farDistance")] 
		public CLegacySingleChannelCurve<CFloat> FarDistance
		{
			get => GetProperty(ref _farDistance);
			set => SetProperty(ref _farDistance, value);
		}

		[Ordinal(7)] 
		[RED("density")] 
		public CLegacySingleChannelCurve<CFloat> Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(8)] 
		[RED("height")] 
		public CLegacySingleChannelCurve<CFloat> Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(9)] 
		[RED("heightFallof")] 
		public CLegacySingleChannelCurve<CFloat> HeightFallof
		{
			get => GetProperty(ref _heightFallof);
			set => SetProperty(ref _heightFallof, value);
		}

		[Ordinal(10)] 
		[RED("densitySecond")] 
		public CLegacySingleChannelCurve<CFloat> DensitySecond
		{
			get => GetProperty(ref _densitySecond);
			set => SetProperty(ref _densitySecond, value);
		}

		[Ordinal(11)] 
		[RED("heightSecond")] 
		public CLegacySingleChannelCurve<CFloat> HeightSecond
		{
			get => GetProperty(ref _heightSecond);
			set => SetProperty(ref _heightSecond, value);
		}

		[Ordinal(12)] 
		[RED("heightFallofSecond")] 
		public CLegacySingleChannelCurve<CFloat> HeightFallofSecond
		{
			get => GetProperty(ref _heightFallofSecond);
			set => SetProperty(ref _heightFallofSecond, value);
		}

		[Ordinal(13)] 
		[RED("simpleColor")] 
		public CLegacySingleChannelCurve<HDRColor> SimpleColor
		{
			get => GetProperty(ref _simpleColor);
			set => SetProperty(ref _simpleColor, value);
		}

		[Ordinal(14)] 
		[RED("simpleDensity")] 
		public CLegacySingleChannelCurve<CFloat> SimpleDensity
		{
			get => GetProperty(ref _simpleDensity);
			set => SetProperty(ref _simpleDensity, value);
		}

		[Ordinal(15)] 
		[RED("envProbeColor")] 
		public CLegacySingleChannelCurve<HDRColor> EnvProbeColor
		{
			get => GetProperty(ref _envProbeColor);
			set => SetProperty(ref _envProbeColor, value);
		}

		[Ordinal(16)] 
		[RED("envProbeDensity")] 
		public CLegacySingleChannelCurve<CFloat> EnvProbeDensity
		{
			get => GetProperty(ref _envProbeDensity);
			set => SetProperty(ref _envProbeDensity, value);
		}
	}
}

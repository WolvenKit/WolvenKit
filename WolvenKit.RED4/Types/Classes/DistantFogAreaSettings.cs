using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistantFogAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("range")] 
		public CLegacySingleChannelCurve<CFloat> Range
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("albedoNear")] 
		public CLegacySingleChannelCurve<HDRColor> AlbedoNear
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(4)] 
		[RED("albedoFar")] 
		public CLegacySingleChannelCurve<HDRColor> AlbedoFar
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(5)] 
		[RED("nearDistance")] 
		public CLegacySingleChannelCurve<CFloat> NearDistance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("farDistance")] 
		public CLegacySingleChannelCurve<CFloat> FarDistance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("density")] 
		public CLegacySingleChannelCurve<CFloat> Density
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("height")] 
		public CLegacySingleChannelCurve<CFloat> Height
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("heightFallof")] 
		public CLegacySingleChannelCurve<CFloat> HeightFallof
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("densitySecond")] 
		public CLegacySingleChannelCurve<CFloat> DensitySecond
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("heightSecond")] 
		public CLegacySingleChannelCurve<CFloat> HeightSecond
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("heightFallofSecond")] 
		public CLegacySingleChannelCurve<CFloat> HeightFallofSecond
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(13)] 
		[RED("simpleColor")] 
		public CLegacySingleChannelCurve<HDRColor> SimpleColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(14)] 
		[RED("simpleDensity")] 
		public CLegacySingleChannelCurve<CFloat> SimpleDensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("envProbeColor")] 
		public CLegacySingleChannelCurve<HDRColor> EnvProbeColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(16)] 
		[RED("envProbeDensity")] 
		public CLegacySingleChannelCurve<CFloat> EnvProbeDensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("skyAltitudeBegin")] 
		public CLegacySingleChannelCurve<CFloat> SkyAltitudeBegin
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(18)] 
		[RED("skyAltitudeEnd")] 
		public CLegacySingleChannelCurve<CFloat> SkyAltitudeEnd
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("skyOpacity")] 
		public CLegacySingleChannelCurve<CFloat> SkyOpacity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public DistantFogAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

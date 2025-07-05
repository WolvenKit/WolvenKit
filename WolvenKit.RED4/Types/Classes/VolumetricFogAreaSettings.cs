using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VolumetricFogAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("albedo")] 
		public CLegacySingleChannelCurve<HDRColor> Albedo
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(3)] 
		[RED("range")] 
		public CLegacySingleChannelCurve<CFloat> Range
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("fogHeight")] 
		public CLegacySingleChannelCurve<CFloat> FogHeight
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("fogHeightFalloff")] 
		public CLegacySingleChannelCurve<CFloat> FogHeightFalloff
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("fogHeightMaxCut")] 
		public CLegacySingleChannelCurve<CFloat> FogHeightMaxCut
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
		[RED("absorption")] 
		public CLegacySingleChannelCurve<CFloat> Absorption
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("ambientScale")] 
		public CLegacySingleChannelCurve<CFloat> AmbientScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("localAmbientScale")] 
		public CLegacySingleChannelCurve<CFloat> LocalAmbientScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("globalLightScale")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("globalLightAnisotropy")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightAnisotropy
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(13)] 
		[RED("globalLightAnisotropyBase")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightAnisotropyBase
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(14)] 
		[RED("globalLightAnisotropyScale")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightAnisotropyScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("localLightRange")] 
		public CLegacySingleChannelCurve<CFloat> LocalLightRange
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(16)] 
		[RED("localLightScale")] 
		public CLegacySingleChannelCurve<CFloat> LocalLightScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("distantAlbedo")] 
		public CLegacySingleChannelCurve<HDRColor> DistantAlbedo
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(18)] 
		[RED("distantGlobalLightScale")] 
		public CLegacySingleChannelCurve<CFloat> DistantGlobalLightScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("distantGroundIrradiance")] 
		public CLegacySingleChannelCurve<CFloat> DistantGroundIrradiance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(20)] 
		[RED("distantGroundSaturation")] 
		public CLegacySingleChannelCurve<CFloat> DistantGroundSaturation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(21)] 
		[RED("distantSkyIrradiance")] 
		public CLegacySingleChannelCurve<CFloat> DistantSkyIrradiance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(22)] 
		[RED("distantShadowAmbientDarkening")] 
		public CLegacySingleChannelCurve<CFloat> DistantShadowAmbientDarkening
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public VolumetricFogAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

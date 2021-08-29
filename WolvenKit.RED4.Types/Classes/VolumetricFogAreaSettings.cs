using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VolumetricFogAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<HDRColor> _albedo;
		private CLegacySingleChannelCurve<CFloat> _range;
		private CLegacySingleChannelCurve<CFloat> _fogHeight;
		private CLegacySingleChannelCurve<CFloat> _fogHeightFalloff;
		private CLegacySingleChannelCurve<CFloat> _fogHeightMaxCut;
		private CLegacySingleChannelCurve<CFloat> _density;
		private CLegacySingleChannelCurve<CFloat> _absorption;
		private CLegacySingleChannelCurve<CFloat> _ambientScale;
		private CLegacySingleChannelCurve<CFloat> _localAmbientScale;
		private CLegacySingleChannelCurve<CFloat> _globalLightScale;
		private CLegacySingleChannelCurve<CFloat> _globalLightAnisotropy;
		private CLegacySingleChannelCurve<CFloat> _globalLightAnisotropyBase;
		private CLegacySingleChannelCurve<CFloat> _globalLightAnisotropyScale;
		private CLegacySingleChannelCurve<CFloat> _localLightRange;
		private CLegacySingleChannelCurve<CFloat> _localLightScale;
		private CLegacySingleChannelCurve<HDRColor> _distantAlbedo;
		private CLegacySingleChannelCurve<CFloat> _distantGlobalLightScale;
		private CLegacySingleChannelCurve<CFloat> _distantGroundIrradiance;
		private CLegacySingleChannelCurve<CFloat> _distantGroundSaturation;
		private CLegacySingleChannelCurve<CFloat> _distantSkyIrradiance;
		private CLegacySingleChannelCurve<CFloat> _distantShadowAmbientDarkening;

		[Ordinal(2)] 
		[RED("albedo")] 
		public CLegacySingleChannelCurve<HDRColor> Albedo
		{
			get => GetProperty(ref _albedo);
			set => SetProperty(ref _albedo, value);
		}

		[Ordinal(3)] 
		[RED("range")] 
		public CLegacySingleChannelCurve<CFloat> Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(4)] 
		[RED("fogHeight")] 
		public CLegacySingleChannelCurve<CFloat> FogHeight
		{
			get => GetProperty(ref _fogHeight);
			set => SetProperty(ref _fogHeight, value);
		}

		[Ordinal(5)] 
		[RED("fogHeightFalloff")] 
		public CLegacySingleChannelCurve<CFloat> FogHeightFalloff
		{
			get => GetProperty(ref _fogHeightFalloff);
			set => SetProperty(ref _fogHeightFalloff, value);
		}

		[Ordinal(6)] 
		[RED("fogHeightMaxCut")] 
		public CLegacySingleChannelCurve<CFloat> FogHeightMaxCut
		{
			get => GetProperty(ref _fogHeightMaxCut);
			set => SetProperty(ref _fogHeightMaxCut, value);
		}

		[Ordinal(7)] 
		[RED("density")] 
		public CLegacySingleChannelCurve<CFloat> Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(8)] 
		[RED("absorption")] 
		public CLegacySingleChannelCurve<CFloat> Absorption
		{
			get => GetProperty(ref _absorption);
			set => SetProperty(ref _absorption, value);
		}

		[Ordinal(9)] 
		[RED("ambientScale")] 
		public CLegacySingleChannelCurve<CFloat> AmbientScale
		{
			get => GetProperty(ref _ambientScale);
			set => SetProperty(ref _ambientScale, value);
		}

		[Ordinal(10)] 
		[RED("localAmbientScale")] 
		public CLegacySingleChannelCurve<CFloat> LocalAmbientScale
		{
			get => GetProperty(ref _localAmbientScale);
			set => SetProperty(ref _localAmbientScale, value);
		}

		[Ordinal(11)] 
		[RED("globalLightScale")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightScale
		{
			get => GetProperty(ref _globalLightScale);
			set => SetProperty(ref _globalLightScale, value);
		}

		[Ordinal(12)] 
		[RED("globalLightAnisotropy")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightAnisotropy
		{
			get => GetProperty(ref _globalLightAnisotropy);
			set => SetProperty(ref _globalLightAnisotropy, value);
		}

		[Ordinal(13)] 
		[RED("globalLightAnisotropyBase")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightAnisotropyBase
		{
			get => GetProperty(ref _globalLightAnisotropyBase);
			set => SetProperty(ref _globalLightAnisotropyBase, value);
		}

		[Ordinal(14)] 
		[RED("globalLightAnisotropyScale")] 
		public CLegacySingleChannelCurve<CFloat> GlobalLightAnisotropyScale
		{
			get => GetProperty(ref _globalLightAnisotropyScale);
			set => SetProperty(ref _globalLightAnisotropyScale, value);
		}

		[Ordinal(15)] 
		[RED("localLightRange")] 
		public CLegacySingleChannelCurve<CFloat> LocalLightRange
		{
			get => GetProperty(ref _localLightRange);
			set => SetProperty(ref _localLightRange, value);
		}

		[Ordinal(16)] 
		[RED("localLightScale")] 
		public CLegacySingleChannelCurve<CFloat> LocalLightScale
		{
			get => GetProperty(ref _localLightScale);
			set => SetProperty(ref _localLightScale, value);
		}

		[Ordinal(17)] 
		[RED("distantAlbedo")] 
		public CLegacySingleChannelCurve<HDRColor> DistantAlbedo
		{
			get => GetProperty(ref _distantAlbedo);
			set => SetProperty(ref _distantAlbedo, value);
		}

		[Ordinal(18)] 
		[RED("distantGlobalLightScale")] 
		public CLegacySingleChannelCurve<CFloat> DistantGlobalLightScale
		{
			get => GetProperty(ref _distantGlobalLightScale);
			set => SetProperty(ref _distantGlobalLightScale, value);
		}

		[Ordinal(19)] 
		[RED("distantGroundIrradiance")] 
		public CLegacySingleChannelCurve<CFloat> DistantGroundIrradiance
		{
			get => GetProperty(ref _distantGroundIrradiance);
			set => SetProperty(ref _distantGroundIrradiance, value);
		}

		[Ordinal(20)] 
		[RED("distantGroundSaturation")] 
		public CLegacySingleChannelCurve<CFloat> DistantGroundSaturation
		{
			get => GetProperty(ref _distantGroundSaturation);
			set => SetProperty(ref _distantGroundSaturation, value);
		}

		[Ordinal(21)] 
		[RED("distantSkyIrradiance")] 
		public CLegacySingleChannelCurve<CFloat> DistantSkyIrradiance
		{
			get => GetProperty(ref _distantSkyIrradiance);
			set => SetProperty(ref _distantSkyIrradiance, value);
		}

		[Ordinal(22)] 
		[RED("distantShadowAmbientDarkening")] 
		public CLegacySingleChannelCurve<CFloat> DistantShadowAmbientDarkening
		{
			get => GetProperty(ref _distantShadowAmbientDarkening);
			set => SetProperty(ref _distantShadowAmbientDarkening, value);
		}
	}
}

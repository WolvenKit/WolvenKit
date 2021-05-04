using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VolumetricFogAreaSettings : IAreaSettings
	{
		private curveData<HDRColor> _albedo;
		private curveData<CFloat> _range;
		private curveData<CFloat> _fogHeight;
		private curveData<CFloat> _fogHeightFalloff;
		private curveData<CFloat> _fogHeightMaxCut;
		private curveData<CFloat> _density;
		private curveData<CFloat> _absorption;
		private curveData<CFloat> _ambientScale;
		private curveData<CFloat> _localAmbientScale;
		private curveData<CFloat> _globalLightScale;
		private curveData<CFloat> _globalLightAnisotropy;
		private curveData<CFloat> _globalLightAnisotropyBase;
		private curveData<CFloat> _globalLightAnisotropyScale;
		private curveData<CFloat> _localLightRange;
		private curveData<CFloat> _localLightScale;
		private curveData<HDRColor> _distantAlbedo;
		private curveData<CFloat> _distantGlobalLightScale;
		private curveData<CFloat> _distantGroundIrradiance;
		private curveData<CFloat> _distantGroundSaturation;
		private curveData<CFloat> _distantSkyIrradiance;
		private curveData<CFloat> _distantShadowAmbientDarkening;

		[Ordinal(2)] 
		[RED("albedo")] 
		public curveData<HDRColor> Albedo
		{
			get => GetProperty(ref _albedo);
			set => SetProperty(ref _albedo, value);
		}

		[Ordinal(3)] 
		[RED("range")] 
		public curveData<CFloat> Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(4)] 
		[RED("fogHeight")] 
		public curveData<CFloat> FogHeight
		{
			get => GetProperty(ref _fogHeight);
			set => SetProperty(ref _fogHeight, value);
		}

		[Ordinal(5)] 
		[RED("fogHeightFalloff")] 
		public curveData<CFloat> FogHeightFalloff
		{
			get => GetProperty(ref _fogHeightFalloff);
			set => SetProperty(ref _fogHeightFalloff, value);
		}

		[Ordinal(6)] 
		[RED("fogHeightMaxCut")] 
		public curveData<CFloat> FogHeightMaxCut
		{
			get => GetProperty(ref _fogHeightMaxCut);
			set => SetProperty(ref _fogHeightMaxCut, value);
		}

		[Ordinal(7)] 
		[RED("density")] 
		public curveData<CFloat> Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(8)] 
		[RED("absorption")] 
		public curveData<CFloat> Absorption
		{
			get => GetProperty(ref _absorption);
			set => SetProperty(ref _absorption, value);
		}

		[Ordinal(9)] 
		[RED("ambientScale")] 
		public curveData<CFloat> AmbientScale
		{
			get => GetProperty(ref _ambientScale);
			set => SetProperty(ref _ambientScale, value);
		}

		[Ordinal(10)] 
		[RED("localAmbientScale")] 
		public curveData<CFloat> LocalAmbientScale
		{
			get => GetProperty(ref _localAmbientScale);
			set => SetProperty(ref _localAmbientScale, value);
		}

		[Ordinal(11)] 
		[RED("globalLightScale")] 
		public curveData<CFloat> GlobalLightScale
		{
			get => GetProperty(ref _globalLightScale);
			set => SetProperty(ref _globalLightScale, value);
		}

		[Ordinal(12)] 
		[RED("globalLightAnisotropy")] 
		public curveData<CFloat> GlobalLightAnisotropy
		{
			get => GetProperty(ref _globalLightAnisotropy);
			set => SetProperty(ref _globalLightAnisotropy, value);
		}

		[Ordinal(13)] 
		[RED("globalLightAnisotropyBase")] 
		public curveData<CFloat> GlobalLightAnisotropyBase
		{
			get => GetProperty(ref _globalLightAnisotropyBase);
			set => SetProperty(ref _globalLightAnisotropyBase, value);
		}

		[Ordinal(14)] 
		[RED("globalLightAnisotropyScale")] 
		public curveData<CFloat> GlobalLightAnisotropyScale
		{
			get => GetProperty(ref _globalLightAnisotropyScale);
			set => SetProperty(ref _globalLightAnisotropyScale, value);
		}

		[Ordinal(15)] 
		[RED("localLightRange")] 
		public curveData<CFloat> LocalLightRange
		{
			get => GetProperty(ref _localLightRange);
			set => SetProperty(ref _localLightRange, value);
		}

		[Ordinal(16)] 
		[RED("localLightScale")] 
		public curveData<CFloat> LocalLightScale
		{
			get => GetProperty(ref _localLightScale);
			set => SetProperty(ref _localLightScale, value);
		}

		[Ordinal(17)] 
		[RED("distantAlbedo")] 
		public curveData<HDRColor> DistantAlbedo
		{
			get => GetProperty(ref _distantAlbedo);
			set => SetProperty(ref _distantAlbedo, value);
		}

		[Ordinal(18)] 
		[RED("distantGlobalLightScale")] 
		public curveData<CFloat> DistantGlobalLightScale
		{
			get => GetProperty(ref _distantGlobalLightScale);
			set => SetProperty(ref _distantGlobalLightScale, value);
		}

		[Ordinal(19)] 
		[RED("distantGroundIrradiance")] 
		public curveData<CFloat> DistantGroundIrradiance
		{
			get => GetProperty(ref _distantGroundIrradiance);
			set => SetProperty(ref _distantGroundIrradiance, value);
		}

		[Ordinal(20)] 
		[RED("distantGroundSaturation")] 
		public curveData<CFloat> DistantGroundSaturation
		{
			get => GetProperty(ref _distantGroundSaturation);
			set => SetProperty(ref _distantGroundSaturation, value);
		}

		[Ordinal(21)] 
		[RED("distantSkyIrradiance")] 
		public curveData<CFloat> DistantSkyIrradiance
		{
			get => GetProperty(ref _distantSkyIrradiance);
			set => SetProperty(ref _distantSkyIrradiance, value);
		}

		[Ordinal(22)] 
		[RED("distantShadowAmbientDarkening")] 
		public curveData<CFloat> DistantShadowAmbientDarkening
		{
			get => GetProperty(ref _distantShadowAmbientDarkening);
			set => SetProperty(ref _distantShadowAmbientDarkening, value);
		}

		public VolumetricFogAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

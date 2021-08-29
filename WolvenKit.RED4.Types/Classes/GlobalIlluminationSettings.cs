using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlobalIlluminationSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _multiBouceScale;
		private CLegacySingleChannelCurve<CFloat> _multiBouceSaturation;
		private CLegacySingleChannelCurve<CFloat> _emissiveScale;
		private CLegacySingleChannelCurve<CFloat> _diffuseScale;
		private CLegacySingleChannelCurve<CFloat> _localLightsScale;
		private CLegacySingleChannelCurve<CFloat> _lightScaleCompenensation;
		private CLegacySingleChannelCurve<CFloat> _reflectionCompensation;
		private CLegacySingleChannelCurve<HDRColor> _ambientBase;
		private CLegacySingleChannelCurve<CFloat> _rayTracedSkyRadianceScale;

		[Ordinal(2)] 
		[RED("multiBouceScale")] 
		public CLegacySingleChannelCurve<CFloat> MultiBouceScale
		{
			get => GetProperty(ref _multiBouceScale);
			set => SetProperty(ref _multiBouceScale, value);
		}

		[Ordinal(3)] 
		[RED("multiBouceSaturation")] 
		public CLegacySingleChannelCurve<CFloat> MultiBouceSaturation
		{
			get => GetProperty(ref _multiBouceSaturation);
			set => SetProperty(ref _multiBouceSaturation, value);
		}

		[Ordinal(4)] 
		[RED("emissiveScale")] 
		public CLegacySingleChannelCurve<CFloat> EmissiveScale
		{
			get => GetProperty(ref _emissiveScale);
			set => SetProperty(ref _emissiveScale, value);
		}

		[Ordinal(5)] 
		[RED("diffuseScale")] 
		public CLegacySingleChannelCurve<CFloat> DiffuseScale
		{
			get => GetProperty(ref _diffuseScale);
			set => SetProperty(ref _diffuseScale, value);
		}

		[Ordinal(6)] 
		[RED("localLightsScale")] 
		public CLegacySingleChannelCurve<CFloat> LocalLightsScale
		{
			get => GetProperty(ref _localLightsScale);
			set => SetProperty(ref _localLightsScale, value);
		}

		[Ordinal(7)] 
		[RED("lightScaleCompenensation")] 
		public CLegacySingleChannelCurve<CFloat> LightScaleCompenensation
		{
			get => GetProperty(ref _lightScaleCompenensation);
			set => SetProperty(ref _lightScaleCompenensation, value);
		}

		[Ordinal(8)] 
		[RED("reflectionCompensation")] 
		public CLegacySingleChannelCurve<CFloat> ReflectionCompensation
		{
			get => GetProperty(ref _reflectionCompensation);
			set => SetProperty(ref _reflectionCompensation, value);
		}

		[Ordinal(9)] 
		[RED("ambientBase")] 
		public CLegacySingleChannelCurve<HDRColor> AmbientBase
		{
			get => GetProperty(ref _ambientBase);
			set => SetProperty(ref _ambientBase, value);
		}

		[Ordinal(10)] 
		[RED("rayTracedSkyRadianceScale")] 
		public CLegacySingleChannelCurve<CFloat> RayTracedSkyRadianceScale
		{
			get => GetProperty(ref _rayTracedSkyRadianceScale);
			set => SetProperty(ref _rayTracedSkyRadianceScale, value);
		}
	}
}

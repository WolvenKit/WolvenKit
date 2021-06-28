using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlobalIlluminationSettings : IAreaSettings
	{
		private curveData<CFloat> _multiBouceScale;
		private curveData<CFloat> _multiBouceSaturation;
		private curveData<CFloat> _emissiveScale;
		private curveData<CFloat> _diffuseScale;
		private curveData<CFloat> _localLightsScale;
		private curveData<CFloat> _lightScaleCompenensation;
		private curveData<CFloat> _reflectionCompensation;
		private curveData<HDRColor> _ambientBase;
		private curveData<CFloat> _rayTracedSkyRadianceScale;

		[Ordinal(2)] 
		[RED("multiBouceScale")] 
		public curveData<CFloat> MultiBouceScale
		{
			get => GetProperty(ref _multiBouceScale);
			set => SetProperty(ref _multiBouceScale, value);
		}

		[Ordinal(3)] 
		[RED("multiBouceSaturation")] 
		public curveData<CFloat> MultiBouceSaturation
		{
			get => GetProperty(ref _multiBouceSaturation);
			set => SetProperty(ref _multiBouceSaturation, value);
		}

		[Ordinal(4)] 
		[RED("emissiveScale")] 
		public curveData<CFloat> EmissiveScale
		{
			get => GetProperty(ref _emissiveScale);
			set => SetProperty(ref _emissiveScale, value);
		}

		[Ordinal(5)] 
		[RED("diffuseScale")] 
		public curveData<CFloat> DiffuseScale
		{
			get => GetProperty(ref _diffuseScale);
			set => SetProperty(ref _diffuseScale, value);
		}

		[Ordinal(6)] 
		[RED("localLightsScale")] 
		public curveData<CFloat> LocalLightsScale
		{
			get => GetProperty(ref _localLightsScale);
			set => SetProperty(ref _localLightsScale, value);
		}

		[Ordinal(7)] 
		[RED("lightScaleCompenensation")] 
		public curveData<CFloat> LightScaleCompenensation
		{
			get => GetProperty(ref _lightScaleCompenensation);
			set => SetProperty(ref _lightScaleCompenensation, value);
		}

		[Ordinal(8)] 
		[RED("reflectionCompensation")] 
		public curveData<CFloat> ReflectionCompensation
		{
			get => GetProperty(ref _reflectionCompensation);
			set => SetProperty(ref _reflectionCompensation, value);
		}

		[Ordinal(9)] 
		[RED("ambientBase")] 
		public curveData<HDRColor> AmbientBase
		{
			get => GetProperty(ref _ambientBase);
			set => SetProperty(ref _ambientBase, value);
		}

		[Ordinal(10)] 
		[RED("rayTracedSkyRadianceScale")] 
		public curveData<CFloat> RayTracedSkyRadianceScale
		{
			get => GetProperty(ref _rayTracedSkyRadianceScale);
			set => SetProperty(ref _rayTracedSkyRadianceScale, value);
		}

		public GlobalIlluminationSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

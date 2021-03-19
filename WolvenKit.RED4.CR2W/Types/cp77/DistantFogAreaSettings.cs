using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantFogAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _range;
		private curveData<HDRColor> _albedoNear;
		private curveData<HDRColor> _albedoFar;
		private curveData<CFloat> _nearDistance;
		private curveData<CFloat> _farDistance;
		private curveData<CFloat> _density;
		private curveData<CFloat> _height;
		private curveData<CFloat> _heightFallof;
		private curveData<CFloat> _densitySecond;
		private curveData<CFloat> _heightSecond;
		private curveData<CFloat> _heightFallofSecond;
		private curveData<HDRColor> _simpleColor;
		private curveData<CFloat> _simpleDensity;
		private curveData<HDRColor> _envProbeColor;
		private curveData<CFloat> _envProbeDensity;

		[Ordinal(2)] 
		[RED("range")] 
		public curveData<CFloat> Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(3)] 
		[RED("albedoNear")] 
		public curveData<HDRColor> AlbedoNear
		{
			get => GetProperty(ref _albedoNear);
			set => SetProperty(ref _albedoNear, value);
		}

		[Ordinal(4)] 
		[RED("albedoFar")] 
		public curveData<HDRColor> AlbedoFar
		{
			get => GetProperty(ref _albedoFar);
			set => SetProperty(ref _albedoFar, value);
		}

		[Ordinal(5)] 
		[RED("nearDistance")] 
		public curveData<CFloat> NearDistance
		{
			get => GetProperty(ref _nearDistance);
			set => SetProperty(ref _nearDistance, value);
		}

		[Ordinal(6)] 
		[RED("farDistance")] 
		public curveData<CFloat> FarDistance
		{
			get => GetProperty(ref _farDistance);
			set => SetProperty(ref _farDistance, value);
		}

		[Ordinal(7)] 
		[RED("density")] 
		public curveData<CFloat> Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(8)] 
		[RED("height")] 
		public curveData<CFloat> Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(9)] 
		[RED("heightFallof")] 
		public curveData<CFloat> HeightFallof
		{
			get => GetProperty(ref _heightFallof);
			set => SetProperty(ref _heightFallof, value);
		}

		[Ordinal(10)] 
		[RED("densitySecond")] 
		public curveData<CFloat> DensitySecond
		{
			get => GetProperty(ref _densitySecond);
			set => SetProperty(ref _densitySecond, value);
		}

		[Ordinal(11)] 
		[RED("heightSecond")] 
		public curveData<CFloat> HeightSecond
		{
			get => GetProperty(ref _heightSecond);
			set => SetProperty(ref _heightSecond, value);
		}

		[Ordinal(12)] 
		[RED("heightFallofSecond")] 
		public curveData<CFloat> HeightFallofSecond
		{
			get => GetProperty(ref _heightFallofSecond);
			set => SetProperty(ref _heightFallofSecond, value);
		}

		[Ordinal(13)] 
		[RED("simpleColor")] 
		public curveData<HDRColor> SimpleColor
		{
			get => GetProperty(ref _simpleColor);
			set => SetProperty(ref _simpleColor, value);
		}

		[Ordinal(14)] 
		[RED("simpleDensity")] 
		public curveData<CFloat> SimpleDensity
		{
			get => GetProperty(ref _simpleDensity);
			set => SetProperty(ref _simpleDensity, value);
		}

		[Ordinal(15)] 
		[RED("envProbeColor")] 
		public curveData<HDRColor> EnvProbeColor
		{
			get => GetProperty(ref _envProbeColor);
			set => SetProperty(ref _envProbeColor, value);
		}

		[Ordinal(16)] 
		[RED("envProbeDensity")] 
		public curveData<CFloat> EnvProbeDensity
		{
			get => GetProperty(ref _envProbeDensity);
			set => SetProperty(ref _envProbeDensity, value);
		}

		public DistantFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

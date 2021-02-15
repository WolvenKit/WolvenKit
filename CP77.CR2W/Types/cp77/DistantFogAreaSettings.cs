using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DistantFogAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("range")] public curveData<CFloat> Range { get; set; }
		[Ordinal(3)] [RED("albedoNear")] public curveData<HDRColor> AlbedoNear { get; set; }
		[Ordinal(4)] [RED("albedoFar")] public curveData<HDRColor> AlbedoFar { get; set; }
		[Ordinal(5)] [RED("nearDistance")] public curveData<CFloat> NearDistance { get; set; }
		[Ordinal(6)] [RED("farDistance")] public curveData<CFloat> FarDistance { get; set; }
		[Ordinal(7)] [RED("density")] public curveData<CFloat> Density { get; set; }
		[Ordinal(8)] [RED("height")] public curveData<CFloat> Height { get; set; }
		[Ordinal(9)] [RED("heightFallof")] public curveData<CFloat> HeightFallof { get; set; }
		[Ordinal(10)] [RED("densitySecond")] public curveData<CFloat> DensitySecond { get; set; }
		[Ordinal(11)] [RED("heightSecond")] public curveData<CFloat> HeightSecond { get; set; }
		[Ordinal(12)] [RED("heightFallofSecond")] public curveData<CFloat> HeightFallofSecond { get; set; }
		[Ordinal(13)] [RED("simpleColor")] public curveData<HDRColor> SimpleColor { get; set; }
		[Ordinal(14)] [RED("simpleDensity")] public curveData<CFloat> SimpleDensity { get; set; }
		[Ordinal(15)] [RED("envProbeColor")] public curveData<HDRColor> EnvProbeColor { get; set; }
		[Ordinal(16)] [RED("envProbeDensity")] public curveData<CFloat> EnvProbeDensity { get; set; }

		public DistantFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GlobalIlluminationSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("multiBouceScale")] public curveData<CFloat> MultiBouceScale { get; set; }
		[Ordinal(1)]  [RED("multiBouceSaturation")] public curveData<CFloat> MultiBouceSaturation { get; set; }
		[Ordinal(2)]  [RED("emissiveScale")] public curveData<CFloat> EmissiveScale { get; set; }
		[Ordinal(3)]  [RED("diffuseScale")] public curveData<CFloat> DiffuseScale { get; set; }
		[Ordinal(4)]  [RED("localLightsScale")] public curveData<CFloat> LocalLightsScale { get; set; }
		[Ordinal(5)]  [RED("lightScaleCompenensation")] public curveData<CFloat> LightScaleCompenensation { get; set; }
		[Ordinal(6)]  [RED("reflectionCompensation")] public curveData<CFloat> ReflectionCompensation { get; set; }
		[Ordinal(7)]  [RED("ambientBase")] public curveData<HDRColor> AmbientBase { get; set; }
		[Ordinal(8)]  [RED("rayTracedSkyRadianceScale")] public curveData<CFloat> RayTracedSkyRadianceScale { get; set; }

		public GlobalIlluminationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

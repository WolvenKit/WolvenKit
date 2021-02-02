using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LightAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("latitude")] public curveData<CFloat> Latitude { get; set; }
		[Ordinal(1)]  [RED("sunRotationOffset")] public curveData<CFloat> SunRotationOffset { get; set; }
		[Ordinal(2)]  [RED("moonRotationOffset")] public curveData<CFloat> MoonRotationOffset { get; set; }
		[Ordinal(3)]  [RED("season")] public CEnum<ETimeOfYearSeason> Season { get; set; }
		[Ordinal(4)]  [RED("sunColor")] public curveData<HDRColor> SunColor { get; set; }
		[Ordinal(5)]  [RED("moonColor")] public curveData<HDRColor> MoonColor { get; set; }
		[Ordinal(6)]  [RED("specularTint")] public curveData<HDRColor> SpecularTint { get; set; }
		[Ordinal(7)]  [RED("sunSize")] public curveData<CFloat> SunSize { get; set; }
		[Ordinal(8)]  [RED("moonSize")] public curveData<CFloat> MoonSize { get; set; }

		public LightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

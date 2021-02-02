using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightParameters : CVariable
	{
		[Ordinal(0)]  [RED("unit")] public CEnum<ELightUnit> Unit { get; set; }
		[Ordinal(1)]  [RED("sunColor")] public curveData<HDRColor> SunColor { get; set; }
		[Ordinal(2)]  [RED("moonColor")] public curveData<HDRColor> MoonColor { get; set; }
		[Ordinal(3)]  [RED("specularTint")] public curveData<HDRColor> SpecularTint { get; set; }
		[Ordinal(4)]  [RED("sunSize")] public curveData<CFloat> SunSize { get; set; }
		[Ordinal(5)]  [RED("moonSize")] public curveData<CFloat> MoonSize { get; set; }

		public worldWorldGlobalLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

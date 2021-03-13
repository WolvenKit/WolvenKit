using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldQualitySetting : CVariable
	{
		[Ordinal(0)] [RED("QualityLevel")] public CEnum<ConfigGraphicsQualityLevel> QualityLevel { get; set; }
		[Ordinal(1)] [RED("xEntitiesBudget")] public CUInt32 XEntitiesBudget { get; set; }

		public worldQualitySetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

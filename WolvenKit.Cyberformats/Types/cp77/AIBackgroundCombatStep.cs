using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatStep : CVariable
	{
		[Ordinal(0)] [RED("timeMin")] public CFloat TimeMin { get; set; }
		[Ordinal(1)] [RED("timeMax")] public CFloat TimeMax { get; set; }
		[Ordinal(2)] [RED("type")] public CEnum<EAIBackgroundCombatStep> Type { get; set; }
		[Ordinal(3)] [RED("argument")] public gameEntityReference Argument { get; set; }
		[Ordinal(4)] [RED("exposureMethod")] public CEnum<AICoverExposureMethod> ExposureMethod { get; set; }

		public AIBackgroundCombatStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

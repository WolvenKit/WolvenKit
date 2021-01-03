using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatStep : CVariable
	{
		[Ordinal(0)]  [RED("argument")] public gameEntityReference Argument { get; set; }
		[Ordinal(1)]  [RED("exposureMethod")] public CEnum<AICoverExposureMethod> ExposureMethod { get; set; }
		[Ordinal(2)]  [RED("timeMax")] public CFloat TimeMax { get; set; }
		[Ordinal(3)]  [RED("timeMin")] public CFloat TimeMin { get; set; }
		[Ordinal(4)]  [RED("type")] public CEnum<EAIBackgroundCombatStep> Type { get; set; }

		public AIBackgroundCombatStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		[Ordinal(0)]  [RED("bbNetwork")] public CHandle<gameIBlackboard> BbNetwork { get; set; }
		[Ordinal(1)]  [RED("isFirstAttempt")] public CBool IsFirstAttempt { get; set; }
		[Ordinal(2)]  [RED("isOfficerBreach")] public CBool IsOfficerBreach { get; set; }
		[Ordinal(3)]  [RED("isRemoteBreach")] public CBool IsRemoteBreach { get; set; }

		public MinigameGenerationRuleScalingPrograms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

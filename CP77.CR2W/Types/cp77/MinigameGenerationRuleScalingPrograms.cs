using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		[Ordinal(6)]  [RED("bbNetwork")] public CHandle<gameIBlackboard> BbNetwork { get; set; }
		[Ordinal(7)]  [RED("isOfficerBreach")] public CBool IsOfficerBreach { get; set; }
		[Ordinal(8)]  [RED("isRemoteBreach")] public CBool IsRemoteBreach { get; set; }
		[Ordinal(9)]  [RED("isFirstAttempt")] public CBool IsFirstAttempt { get; set; }

		public MinigameGenerationRuleScalingPrograms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

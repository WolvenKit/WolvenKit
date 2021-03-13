using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		[Ordinal(7)] [RED("bbNetwork")] public CHandle<gameIBlackboard> BbNetwork { get; set; }
		[Ordinal(8)] [RED("isOfficerBreach")] public CBool IsOfficerBreach { get; set; }
		[Ordinal(9)] [RED("isRemoteBreach")] public CBool IsRemoteBreach { get; set; }
		[Ordinal(10)] [RED("isFirstAttempt")] public CBool IsFirstAttempt { get; set; }

		public MinigameGenerationRuleScalingPrograms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

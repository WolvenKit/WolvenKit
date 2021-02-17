using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PaymentBalanced_ScriptConditionType : PaymentConditionTypeBase
	{
		[Ordinal(2)] [RED("questAssignment")] public TweakDBID QuestAssignment { get; set; }
		[Ordinal(3)] [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }

		public PaymentBalanced_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

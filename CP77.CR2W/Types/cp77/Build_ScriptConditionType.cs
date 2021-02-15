using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Build_ScriptConditionType : BluelineConditionTypeBase
	{
		[Ordinal(0)] [RED("questAssignment")] public TweakDBID QuestAssignment { get; set; }
		[Ordinal(1)] [RED("buildId")] public TweakDBID BuildId { get; set; }
		[Ordinal(2)] [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }
		[Ordinal(3)] [RED("comparisonType")] public CEnum<ECompareOp> ComparisonType { get; set; }

		public Build_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

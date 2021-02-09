using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SimpleCombatConditon : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("firstCoverEvaluationDone")] public CBool FirstCoverEvaluationDone { get; set; }
		[Ordinal(1)]  [RED("takeCoverAbility")] public CHandle<gamedataGameplayAbility_Record> TakeCoverAbility { get; set; }
		[Ordinal(2)]  [RED("quickhackAbility")] public CHandle<gamedataGameplayAbility_Record> QuickhackAbility { get; set; }

		public SimpleCombatConditon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

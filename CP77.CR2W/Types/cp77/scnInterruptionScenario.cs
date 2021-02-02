using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInterruptionScenario : CVariable
	{
		[Ordinal(0)]  [RED("interruptConditions")] public CArray<CHandle<scnIInterruptCondition>> InterruptConditions { get; set; }
		[Ordinal(1)]  [RED("returnConditions")] public CArray<CHandle<scnIReturnCondition>> ReturnConditions { get; set; }
		[Ordinal(2)]  [RED("postInterruptSignalFactCondition")] public CHandle<scnInterruptFactConditionType> PostInterruptSignalFactCondition { get; set; }
		[Ordinal(3)]  [RED("postReturnSignalFactCondition")] public CHandle<scnInterruptFactConditionType> PostReturnSignalFactCondition { get; set; }
		[Ordinal(4)]  [RED("postInterruptSignalTimeDelay")] public CFloat PostInterruptSignalTimeDelay { get; set; }
		[Ordinal(5)]  [RED("postReturnSignalTimeDelay")] public CFloat PostReturnSignalTimeDelay { get; set; }
		[Ordinal(6)]  [RED("playingLinesBehavior")] public CEnum<scnInterruptReturnLinesBehavior> PlayingLinesBehavior { get; set; }
		[Ordinal(7)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(8)]  [RED("talkOnReturn")] public CBool TalkOnReturn { get; set; }
		[Ordinal(9)]  [RED("playInterruptLine")] public CBool PlayInterruptLine { get; set; }
		[Ordinal(10)]  [RED("forcePlayReturnLine")] public CBool ForcePlayReturnLine { get; set; }
		[Ordinal(11)]  [RED("interruptionSpammingSafeguard")] public CBool InterruptionSpammingSafeguard { get; set; }
		[Ordinal(12)]  [RED("id")] public scnInterruptionScenarioId Id { get; set; }
		[Ordinal(13)]  [RED("name")] public CName Name { get; set; }

		public scnInterruptionScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

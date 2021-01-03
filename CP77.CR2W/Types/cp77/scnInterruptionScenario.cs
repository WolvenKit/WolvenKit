using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnInterruptionScenario : CVariable
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("forcePlayReturnLine")] public CBool ForcePlayReturnLine { get; set; }
		[Ordinal(2)]  [RED("id")] public scnInterruptionScenarioId Id { get; set; }
		[Ordinal(3)]  [RED("interruptConditions")] public CArray<CHandle<scnIInterruptCondition>> InterruptConditions { get; set; }
		[Ordinal(4)]  [RED("interruptionSpammingSafeguard")] public CBool InterruptionSpammingSafeguard { get; set; }
		[Ordinal(5)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(6)]  [RED("playInterruptLine")] public CBool PlayInterruptLine { get; set; }
		[Ordinal(7)]  [RED("playingLinesBehavior")] public CEnum<scnInterruptReturnLinesBehavior> PlayingLinesBehavior { get; set; }
		[Ordinal(8)]  [RED("postInterruptSignalFactCondition")] public CHandle<scnInterruptFactConditionType> PostInterruptSignalFactCondition { get; set; }
		[Ordinal(9)]  [RED("postInterruptSignalTimeDelay")] public CFloat PostInterruptSignalTimeDelay { get; set; }
		[Ordinal(10)]  [RED("postReturnSignalFactCondition")] public CHandle<scnInterruptFactConditionType> PostReturnSignalFactCondition { get; set; }
		[Ordinal(11)]  [RED("postReturnSignalTimeDelay")] public CFloat PostReturnSignalTimeDelay { get; set; }
		[Ordinal(12)]  [RED("returnConditions")] public CArray<CHandle<scnIReturnCondition>> ReturnConditions { get; set; }
		[Ordinal(13)]  [RED("talkOnReturn")] public CBool TalkOnReturn { get; set; }

		public scnInterruptionScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PassiveCoverSelectionConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)]  [RED("ability")] public wCHandle<gamedataGameplayAbility_Record> Ability { get; set; }
		[Ordinal(1)]  [RED("statListener")] public CHandle<AIStatListener> StatListener { get; set; }
		[Ordinal(2)]  [RED("statsChangedCbId")] public CUInt32 StatsChangedCbId { get; set; }

		public PassiveCoverSelectionConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

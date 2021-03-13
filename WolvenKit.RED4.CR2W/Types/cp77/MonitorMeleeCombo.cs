using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MonitorMeleeCombo : AIActionHelperTask
	{
		[Ordinal(5)] [RED("ExitComboBoolArgumentRef")] public CName ExitComboBoolArgumentRef { get; set; }
		[Ordinal(6)] [RED("PreviousReactionIntArgumentRef")] public CName PreviousReactionIntArgumentRef { get; set; }
		[Ordinal(7)] [RED("CurrentAttackIntArgumentRef")] public CName CurrentAttackIntArgumentRef { get; set; }
		[Ordinal(8)] [RED("ComboCountIntArgumentRef")] public CName ComboCountIntArgumentRef { get; set; }
		[Ordinal(9)] [RED("ComboToIdleBoolArgumentRef")] public CName ComboToIdleBoolArgumentRef { get; set; }

		public MonitorMeleeCombo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

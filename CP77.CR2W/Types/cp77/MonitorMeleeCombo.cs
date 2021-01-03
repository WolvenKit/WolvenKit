using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MonitorMeleeCombo : AIActionHelperTask
	{
		[Ordinal(0)]  [RED("ComboCountIntArgumentRef")] public CName ComboCountIntArgumentRef { get; set; }
		[Ordinal(1)]  [RED("ComboToIdleBoolArgumentRef")] public CName ComboToIdleBoolArgumentRef { get; set; }
		[Ordinal(2)]  [RED("CurrentAttackIntArgumentRef")] public CName CurrentAttackIntArgumentRef { get; set; }
		[Ordinal(3)]  [RED("ExitComboBoolArgumentRef")] public CName ExitComboBoolArgumentRef { get; set; }
		[Ordinal(4)]  [RED("PreviousReactionIntArgumentRef")] public CName PreviousReactionIntArgumentRef { get; set; }

		public MonitorMeleeCombo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetQuickThrowEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] [RED("grenadeThrown")] public CBool GrenadeThrown { get; set; }
		[Ordinal(1)] [RED("event")] public CBool Event { get; set; }

		public CombatGadgetQuickThrowEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

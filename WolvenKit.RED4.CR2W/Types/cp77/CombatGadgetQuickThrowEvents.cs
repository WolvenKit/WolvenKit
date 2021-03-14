using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetQuickThrowEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] [RED("grenadeThrown")] public CBool GrenadeThrown { get; set; }
		[Ordinal(1)] [RED("event")] public CBool Event { get; set; }

		public CombatGadgetQuickThrowEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

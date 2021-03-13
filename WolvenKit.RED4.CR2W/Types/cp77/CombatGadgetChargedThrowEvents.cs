using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargedThrowEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] [RED("grenadeThrown")] public CBool GrenadeThrown { get; set; }
		[Ordinal(1)] [RED("localAimForward")] public Vector4 LocalAimForward { get; set; }
		[Ordinal(2)] [RED("localAimPosition")] public Vector4 LocalAimPosition { get; set; }

		public CombatGadgetChargedThrowEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

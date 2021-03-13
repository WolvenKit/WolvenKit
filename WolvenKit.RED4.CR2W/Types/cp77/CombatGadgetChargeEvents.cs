using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargeEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] [RED("initiated")] public CBool Initiated { get; set; }
		[Ordinal(1)] [RED("itemSwitched")] public CBool ItemSwitched { get; set; }

		public CombatGadgetChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

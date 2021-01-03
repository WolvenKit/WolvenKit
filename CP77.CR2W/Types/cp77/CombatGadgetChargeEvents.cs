using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargeEvents : CombatGadgetTransitions
	{
		[Ordinal(0)]  [RED("initiated")] public CBool Initiated { get; set; }
		[Ordinal(1)]  [RED("itemSwitched")] public CBool ItemSwitched { get; set; }

		public CombatGadgetChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

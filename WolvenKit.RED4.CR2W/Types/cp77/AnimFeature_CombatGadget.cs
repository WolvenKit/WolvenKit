using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CombatGadget : animAnimFeature
	{
		[Ordinal(0)] [RED("isQuickthrow")] public CBool IsQuickthrow { get; set; }
		[Ordinal(1)] [RED("isDetonated")] public CBool IsDetonated { get; set; }

		public AnimFeature_CombatGadget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

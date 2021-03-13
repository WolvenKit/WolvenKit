using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckLastHitReaction : HitConditions
	{
		[Ordinal(0)] [RED("hitReactionToCheck")] public CEnum<animHitReactionType> HitReactionToCheck { get; set; }

		public CheckLastHitReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

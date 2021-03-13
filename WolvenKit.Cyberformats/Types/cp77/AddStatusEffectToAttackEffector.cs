using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddStatusEffectToAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] [RED("isRandom")] public CBool IsRandom { get; set; }
		[Ordinal(1)] [RED("applicationChance")] public CFloat ApplicationChance { get; set; }
		[Ordinal(2)] [RED("statusEffect")] public SHitStatusEffect StatusEffect { get; set; }
		[Ordinal(3)] [RED("stacks")] public CFloat Stacks { get; set; }

		public AddStatusEffectToAttackEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

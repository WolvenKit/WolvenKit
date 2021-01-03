using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AddStatusEffectToAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)]  [RED("applicationChance")] public CFloat ApplicationChance { get; set; }
		[Ordinal(1)]  [RED("isRandom")] public CBool IsRandom { get; set; }
		[Ordinal(2)]  [RED("stacks")] public CFloat Stacks { get; set; }
		[Ordinal(3)]  [RED("statusEffect")] public SHitStatusEffect StatusEffect { get; set; }

		public AddStatusEffectToAttackEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

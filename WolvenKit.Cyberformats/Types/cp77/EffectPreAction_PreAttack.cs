using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectPreAction_PreAttack : gameEffectPreAction_Scripted
	{
		[Ordinal(0)] [RED("withFriendlyFire")] public CBool WithFriendlyFire { get; set; }
		[Ordinal(1)] [RED("withSelfDamage")] public CBool WithSelfDamage { get; set; }

		public EffectPreAction_PreAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

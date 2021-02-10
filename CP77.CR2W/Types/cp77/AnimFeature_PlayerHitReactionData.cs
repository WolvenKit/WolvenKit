using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerHitReactionData : animAnimFeature
	{
		[Ordinal(0)]  [RED("hitDirection")] public CFloat HitDirection { get; set; }
		[Ordinal(1)]  [RED("hitStrength")] public CFloat HitStrength { get; set; }
		[Ordinal(2)]  [RED("isMeleeHit")] public CBool IsMeleeHit { get; set; }
		[Ordinal(3)]  [RED("isLightMeleeHit")] public CBool IsLightMeleeHit { get; set; }
		[Ordinal(4)]  [RED("isStrongMeleeHit")] public CBool IsStrongMeleeHit { get; set; }
		[Ordinal(5)]  [RED("isQuickMeleeHit")] public CBool IsQuickMeleeHit { get; set; }
		[Ordinal(6)]  [RED("isExplosion")] public CBool IsExplosion { get; set; }
		[Ordinal(7)]  [RED("isPressureWave")] public CBool IsPressureWave { get; set; }
		[Ordinal(8)]  [RED("meleeAttackDirection")] public CInt32 MeleeAttackDirection { get; set; }

		public AnimFeature_PlayerHitReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KnockdownEvents : StatusEffectEvents
	{
		[Ordinal(3)] [RED("cachedPlayerVelocity")] public Vector4 CachedPlayerVelocity { get; set; }
		[Ordinal(4)] [RED("secondaryKnockdownDir")] public Vector4 SecondaryKnockdownDir { get; set; }
		[Ordinal(5)] [RED("secondaryKnockdownTimer")] public CFloat SecondaryKnockdownTimer { get; set; }
		[Ordinal(6)] [RED("playedImpactAnim")] public CBool PlayedImpactAnim { get; set; }
		[Ordinal(7)] [RED("frictionForceApplied")] public CBool FrictionForceApplied { get; set; }

		public KnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

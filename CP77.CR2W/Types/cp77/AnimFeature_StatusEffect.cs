using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_StatusEffect : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("variation")] public CInt32 Variation { get; set; }
		[Ordinal(3)] [RED("direction")] public CInt32 Direction { get; set; }
		[Ordinal(4)] [RED("impactDirection")] public CInt32 ImpactDirection { get; set; }
		[Ordinal(5)] [RED("knockdown")] public CBool Knockdown { get; set; }
		[Ordinal(6)] [RED("stunned")] public CBool Stunned { get; set; }
		[Ordinal(7)] [RED("playImpact")] public CBool PlayImpact { get; set; }

		public AnimFeature_StatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

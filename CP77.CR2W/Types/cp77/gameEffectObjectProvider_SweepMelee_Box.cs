using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_SweepMelee_Box : gameEffectObjectProvider_SweepOverTime
	{
		[Ordinal(0)]  [RED("playerStaticDetectionConeDistance")] public CFloat PlayerStaticDetectionConeDistance { get; set; }
		[Ordinal(1)]  [RED("playerStaticDetectionConeStartAngle")] public CFloat PlayerStaticDetectionConeStartAngle { get; set; }
		[Ordinal(2)]  [RED("playerStaticDetectionConeEndAngle")] public CFloat PlayerStaticDetectionConeEndAngle { get; set; }
		[Ordinal(3)]  [RED("checkMeleeInvulnerability")] public CBool CheckMeleeInvulnerability { get; set; }

		public gameEffectObjectProvider_SweepMelee_Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

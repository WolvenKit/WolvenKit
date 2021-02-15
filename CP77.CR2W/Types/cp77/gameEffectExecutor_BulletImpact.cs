using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_BulletImpact : gameEffectExecutor
	{
		[Ordinal(1)] [RED("isBackfaceImpact")] public CBool IsBackfaceImpact { get; set; }
		[Ordinal(2)] [RED("noAudio")] public CBool NoAudio { get; set; }
		[Ordinal(3)] [RED("isMeleeAttack")] public CBool IsMeleeAttack { get; set; }

		public gameEffectExecutor_BulletImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

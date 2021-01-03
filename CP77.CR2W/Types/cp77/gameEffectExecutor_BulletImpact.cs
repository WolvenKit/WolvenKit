using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_BulletImpact : gameEffectExecutor
	{
		[Ordinal(0)]  [RED("isBackfaceImpact")] public CBool IsBackfaceImpact { get; set; }
		[Ordinal(1)]  [RED("isMeleeAttack")] public CBool IsMeleeAttack { get; set; }
		[Ordinal(2)]  [RED("noAudio")] public CBool NoAudio { get; set; }

		public gameEffectExecutor_BulletImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

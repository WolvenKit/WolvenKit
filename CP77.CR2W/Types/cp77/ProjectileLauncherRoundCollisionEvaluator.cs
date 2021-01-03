using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRoundCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)]  [RED("collisionAction")] public CEnum<gamedataProjectileOnCollisionAction> CollisionAction { get; set; }
		[Ordinal(1)]  [RED("maxBounceCount")] public CInt32 MaxBounceCount { get; set; }
		[Ordinal(2)]  [RED("projectileBounced")] public CBool ProjectileBounced { get; set; }
		[Ordinal(3)]  [RED("projectilePierced")] public CBool ProjectilePierced { get; set; }
		[Ordinal(4)]  [RED("projectileStopAndStick")] public CBool ProjectileStopAndStick { get; set; }
		[Ordinal(5)]  [RED("projectileStopped")] public CBool ProjectileStopped { get; set; }

		public ProjectileLauncherRoundCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

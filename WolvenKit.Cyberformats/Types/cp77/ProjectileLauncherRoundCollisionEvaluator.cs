using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRoundCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)] [RED("collisionAction")] public CEnum<gamedataProjectileOnCollisionAction> CollisionAction { get; set; }
		[Ordinal(1)] [RED("projectileStopped")] public CBool ProjectileStopped { get; set; }
		[Ordinal(2)] [RED("maxBounceCount")] public CInt32 MaxBounceCount { get; set; }
		[Ordinal(3)] [RED("projectileBounced")] public CBool ProjectileBounced { get; set; }
		[Ordinal(4)] [RED("projectileStopAndStick")] public CBool ProjectileStopAndStick { get; set; }
		[Ordinal(5)] [RED("projectilePierced")] public CBool ProjectilePierced { get; set; }

		public ProjectileLauncherRoundCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

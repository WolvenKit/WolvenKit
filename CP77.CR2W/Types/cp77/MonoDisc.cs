using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MonoDisc : BaseProjectile
	{
		[Ordinal(41)]  [RED("throwtype")] public CEnum<ThrowType> Throwtype { get; set; }
		[Ordinal(42)]  [RED("targetAcquired")] public CBool TargetAcquired { get; set; }
		[Ordinal(43)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(44)]  [RED("disc")] public wCHandle<gameObject> Disc { get; set; }
		[Ordinal(45)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(46)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(47)]  [RED("discSpawnPoint")] public Vector4 DiscSpawnPoint { get; set; }
		[Ordinal(48)]  [RED("discPosition")] public Vector4 DiscPosition { get; set; }
		[Ordinal(49)]  [RED("collisionCount")] public CInt32 CollisionCount { get; set; }
		[Ordinal(50)]  [RED("airTime")] public CFloat AirTime { get; set; }
		[Ordinal(51)]  [RED("destroyTimer")] public CFloat DestroyTimer { get; set; }
		[Ordinal(52)]  [RED("returningToPlayer")] public CBool ReturningToPlayer { get; set; }
		[Ordinal(53)]  [RED("catchingPlayer")] public CBool CatchingPlayer { get; set; }
		[Ordinal(54)]  [RED("discCaught")] public CBool DiscCaught { get; set; }
		[Ordinal(55)]  [RED("discLodgedToSurface")] public CBool DiscLodgedToSurface { get; set; }
		[Ordinal(56)]  [RED("wasNPCHit")] public CBool WasNPCHit { get; set; }
		[Ordinal(57)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }

		public MonoDisc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

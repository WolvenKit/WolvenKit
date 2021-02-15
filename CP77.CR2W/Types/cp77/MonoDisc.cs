using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MonoDisc : BaseProjectile
	{
		[Ordinal(51)] [RED("throwtype")] public CEnum<ThrowType> Throwtype { get; set; }
		[Ordinal(52)] [RED("targetAcquired")] public CBool TargetAcquired { get; set; }
		[Ordinal(53)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(54)] [RED("disc")] public wCHandle<gameObject> Disc { get; set; }
		[Ordinal(55)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(56)] [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(57)] [RED("discSpawnPoint")] public Vector4 DiscSpawnPoint { get; set; }
		[Ordinal(58)] [RED("discPosition")] public Vector4 DiscPosition { get; set; }
		[Ordinal(59)] [RED("collisionCount")] public CInt32 CollisionCount { get; set; }
		[Ordinal(60)] [RED("airTime")] public CFloat AirTime { get; set; }
		[Ordinal(61)] [RED("destroyTimer")] public CFloat DestroyTimer { get; set; }
		[Ordinal(62)] [RED("returningToPlayer")] public CBool ReturningToPlayer { get; set; }
		[Ordinal(63)] [RED("catchingPlayer")] public CBool CatchingPlayer { get; set; }
		[Ordinal(64)] [RED("discCaught")] public CBool DiscCaught { get; set; }
		[Ordinal(65)] [RED("discLodgedToSurface")] public CBool DiscLodgedToSurface { get; set; }
		[Ordinal(66)] [RED("wasNPCHit")] public CBool WasNPCHit { get; set; }
		[Ordinal(67)] [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }

		public MonoDisc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MonoDisc : BaseProjectile
	{
		[Ordinal(0)]  [RED("airTime")] public CFloat AirTime { get; set; }
		[Ordinal(1)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(2)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(3)]  [RED("catchingPlayer")] public CBool CatchingPlayer { get; set; }
		[Ordinal(4)]  [RED("collisionCount")] public CInt32 CollisionCount { get; set; }
		[Ordinal(5)]  [RED("destroyTimer")] public CFloat DestroyTimer { get; set; }
		[Ordinal(6)]  [RED("disc")] public wCHandle<gameObject> Disc { get; set; }
		[Ordinal(7)]  [RED("discCaught")] public CBool DiscCaught { get; set; }
		[Ordinal(8)]  [RED("discLodgedToSurface")] public CBool DiscLodgedToSurface { get; set; }
		[Ordinal(9)]  [RED("discPosition")] public Vector4 DiscPosition { get; set; }
		[Ordinal(10)]  [RED("discSpawnPoint")] public Vector4 DiscSpawnPoint { get; set; }
		[Ordinal(11)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(12)]  [RED("returningToPlayer")] public CBool ReturningToPlayer { get; set; }
		[Ordinal(13)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(14)]  [RED("targetAcquired")] public CBool TargetAcquired { get; set; }
		[Ordinal(15)]  [RED("throwtype")] public CEnum<ThrowType> Throwtype { get; set; }
		[Ordinal(16)]  [RED("wasNPCHit")] public CBool WasNPCHit { get; set; }

		public MonoDisc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

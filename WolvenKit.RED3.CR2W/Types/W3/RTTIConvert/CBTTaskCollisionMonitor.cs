using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCollisionMonitor : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(2)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(3)] [RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(4)] [RED("soundEventOnCollidedActor")] 		public CName SoundEventOnCollidedActor { get; set;}

		[Ordinal(5)] [RED("destroyObstacleOnCollision")] 		public CBool DestroyObstacleOnCollision { get; set;}

		[Ordinal(6)] [RED("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[Ordinal(7)] [RED("chargeType")] 		public CEnum<EChargeAttackType> ChargeType { get; set;}

		[Ordinal(8)] [RED("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[Ordinal(9)] [RED("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		[Ordinal(10)] [RED("completeOnCollisionWithObstacle")] 		public CBool CompleteOnCollisionWithObstacle { get; set;}

		[Ordinal(11)] [RED("unavailableForOneFrameOnInterval")] 		public CFloat UnavailableForOneFrameOnInterval { get; set;}

		[Ordinal(12)] [RED("bCollisionWithActor")] 		public CBool BCollisionWithActor { get; set;}

		[Ordinal(13)] [RED("bCollisionWithObstacle")] 		public CBool BCollisionWithObstacle { get; set;}

		[Ordinal(14)] [RED("bCollisionWithObstacleProbe")] 		public CBool BCollisionWithObstacleProbe { get; set;}

		[Ordinal(15)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(16)] [RED("xmlDamageName")] 		public CName XmlDamageName { get; set;}

		[Ordinal(17)] [RED("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		[Ordinal(18)] [RED("collidedEntity")] 		public CHandle<CGameplayEntity> CollidedEntity { get; set;}

		[Ordinal(19)] [RED("collidedProbedEntity")] 		public CHandle<CGameplayEntity> CollidedProbedEntity { get; set;}

		[Ordinal(20)] [RED("activationTimeStamp")] 		public CFloat ActivationTimeStamp { get; set;}

		[Ordinal(21)] [RED("actorCollisionTimeStamp")] 		public CFloat ActorCollisionTimeStamp { get; set;}

		[Ordinal(22)] [RED("objectCollisionTimeStamp")] 		public CFloat ObjectCollisionTimeStamp { get; set;}

		[Ordinal(23)] [RED("objectProbeCollisionTimeStamp")] 		public CFloat ObjectProbeCollisionTimeStamp { get; set;}

		[Ordinal(24)] [RED("intervalCheckTimeStamp")] 		public CFloat IntervalCheckTimeStamp { get; set;}

		[Ordinal(25)] [RED("hadForceCriticalStates")] 		public CBool HadForceCriticalStates { get; set;}

		public CBTTaskCollisionMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollisionMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
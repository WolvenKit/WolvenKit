using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCollisionMonitor : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(0)] [RED("("soundEventOnCollidedActor")] 		public CName SoundEventOnCollidedActor { get; set;}

		[Ordinal(0)] [RED("("destroyObstacleOnCollision")] 		public CBool DestroyObstacleOnCollision { get; set;}

		[Ordinal(0)] [RED("("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[Ordinal(0)] [RED("("chargeType")] 		public CEnum<EChargeAttackType> ChargeType { get; set;}

		[Ordinal(0)] [RED("("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[Ordinal(0)] [RED("("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		[Ordinal(0)] [RED("("completeOnCollisionWithObstacle")] 		public CBool CompleteOnCollisionWithObstacle { get; set;}

		[Ordinal(0)] [RED("("unavailableForOneFrameOnInterval")] 		public CFloat UnavailableForOneFrameOnInterval { get; set;}

		[Ordinal(0)] [RED("("bCollisionWithActor")] 		public CBool BCollisionWithActor { get; set;}

		[Ordinal(0)] [RED("("bCollisionWithObstacle")] 		public CBool BCollisionWithObstacle { get; set;}

		[Ordinal(0)] [RED("("bCollisionWithObstacleProbe")] 		public CBool BCollisionWithObstacleProbe { get; set;}

		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("xmlDamageName")] 		public CName XmlDamageName { get; set;}

		[Ordinal(0)] [RED("("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		[Ordinal(0)] [RED("("collidedEntity")] 		public CHandle<CGameplayEntity> CollidedEntity { get; set;}

		[Ordinal(0)] [RED("("collidedProbedEntity")] 		public CHandle<CGameplayEntity> CollidedProbedEntity { get; set;}

		[Ordinal(0)] [RED("("activationTimeStamp")] 		public CFloat ActivationTimeStamp { get; set;}

		[Ordinal(0)] [RED("("actorCollisionTimeStamp")] 		public CFloat ActorCollisionTimeStamp { get; set;}

		[Ordinal(0)] [RED("("objectCollisionTimeStamp")] 		public CFloat ObjectCollisionTimeStamp { get; set;}

		[Ordinal(0)] [RED("("objectProbeCollisionTimeStamp")] 		public CFloat ObjectProbeCollisionTimeStamp { get; set;}

		[Ordinal(0)] [RED("("intervalCheckTimeStamp")] 		public CFloat IntervalCheckTimeStamp { get; set;}

		[Ordinal(0)] [RED("("hadForceCriticalStates")] 		public CBool HadForceCriticalStates { get; set;}

		public CBTTaskCollisionMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollisionMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
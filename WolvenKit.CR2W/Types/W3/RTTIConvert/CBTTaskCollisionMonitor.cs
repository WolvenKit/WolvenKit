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
		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[RED("soundEventOnCollidedActor")] 		public CName SoundEventOnCollidedActor { get; set;}

		[RED("destroyObstacleOnCollision")] 		public CBool DestroyObstacleOnCollision { get; set;}

		[RED("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[RED("chargeType")] 		public CEnum<EChargeAttackType> ChargeType { get; set;}

		[RED("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[RED("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		[RED("completeOnCollisionWithObstacle")] 		public CBool CompleteOnCollisionWithObstacle { get; set;}

		[RED("unavailableForOneFrameOnInterval")] 		public CFloat UnavailableForOneFrameOnInterval { get; set;}

		[RED("bCollisionWithActor")] 		public CBool BCollisionWithActor { get; set;}

		[RED("bCollisionWithObstacle")] 		public CBool BCollisionWithObstacle { get; set;}

		[RED("bCollisionWithObstacleProbe")] 		public CBool BCollisionWithObstacleProbe { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("xmlDamageName")] 		public CName XmlDamageName { get; set;}

		[RED("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		[RED("collidedEntity")] 		public CHandle<CGameplayEntity> CollidedEntity { get; set;}

		[RED("collidedProbedEntity")] 		public CHandle<CGameplayEntity> CollidedProbedEntity { get; set;}

		[RED("activationTimeStamp")] 		public CFloat ActivationTimeStamp { get; set;}

		[RED("actorCollisionTimeStamp")] 		public CFloat ActorCollisionTimeStamp { get; set;}

		[RED("objectCollisionTimeStamp")] 		public CFloat ObjectCollisionTimeStamp { get; set;}

		[RED("objectProbeCollisionTimeStamp")] 		public CFloat ObjectProbeCollisionTimeStamp { get; set;}

		[RED("intervalCheckTimeStamp")] 		public CFloat IntervalCheckTimeStamp { get; set;}

		[RED("hadForceCriticalStates")] 		public CBool HadForceCriticalStates { get; set;}

		public CBTTaskCollisionMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollisionMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCollisionMonitorDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[RED("destroyObstacleOnCollision")] 		public CBool DestroyObstacleOnCollision { get; set;}

		[RED("chargeType")] 		public EChargeAttackType ChargeType { get; set;}

		[RED("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[RED("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		[RED("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[RED("soundEventOnCollidedActor")] 		public CName SoundEventOnCollidedActor { get; set;}

		[RED("completeOnCollisionWithObstacle")] 		public CBool CompleteOnCollisionWithObstacle { get; set;}

		[RED("unavailableForOneFrameOnInterval")] 		public CFloat UnavailableForOneFrameOnInterval { get; set;}

		public CBTTaskCollisionMonitorDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskCollisionMonitorDef(cr2w);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCollisionMonitorDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(2)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(3)] [RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(4)] [RED("destroyObstacleOnCollision")] 		public CBool DestroyObstacleOnCollision { get; set;}

		[Ordinal(5)] [RED("chargeType")] 		public CEnum<EChargeAttackType> ChargeType { get; set;}

		[Ordinal(6)] [RED("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[Ordinal(7)] [RED("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		[Ordinal(8)] [RED("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[Ordinal(9)] [RED("soundEventOnCollidedActor")] 		public CName SoundEventOnCollidedActor { get; set;}

		[Ordinal(10)] [RED("completeOnCollisionWithObstacle")] 		public CBool CompleteOnCollisionWithObstacle { get; set;}

		[Ordinal(11)] [RED("unavailableForOneFrameOnInterval")] 		public CFloat UnavailableForOneFrameOnInterval { get; set;}

		public CBTTaskCollisionMonitorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCollisionMonitorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
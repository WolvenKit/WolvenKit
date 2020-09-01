using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChargeDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("raiseEventOnActivation")] 		public CName RaiseEventOnActivation { get; set;}

		[Ordinal(2)] [RED("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[Ordinal(3)] [RED("handleCollisionWithObstacle")] 		public CBool HandleCollisionWithObstacle { get; set;}

		[Ordinal(4)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(5)] [RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(6)] [RED("endTaskWhenOwnerGoesPastTarget")] 		public CBool EndTaskWhenOwnerGoesPastTarget { get; set;}

		[Ordinal(7)] [RED("chargeType")] 		public CEnum<EChargeAttackType> ChargeType { get; set;}

		[Ordinal(8)] [RED("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[Ordinal(9)] [RED("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		public CBTTaskChargeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChargeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
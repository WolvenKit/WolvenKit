using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChargeDef : CBTTaskAttackDef
	{
		[RED("raiseEventOnActivation")] 		public CName RaiseEventOnActivation { get; set;}

		[RED("raiseEventOnObstacleCollision")] 		public CName RaiseEventOnObstacleCollision { get; set;}

		[RED("handleCollisionWithObstacle")] 		public CBool HandleCollisionWithObstacle { get; set;}

		[RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[RED("endTaskWhenOwnerGoesPastTarget")] 		public CBool EndTaskWhenOwnerGoesPastTarget { get; set;}

		[RED("chargeType")] 		public CEnum<EChargeAttackType> ChargeType { get; set;}

		[RED("forceCriticalEffect")] 		public CBool ForceCriticalEffect { get; set;}

		[RED("forceCriticalEffectNpcOnly")] 		public CBool ForceCriticalEffectNpcOnly { get; set;}

		public CBTTaskChargeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChargeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
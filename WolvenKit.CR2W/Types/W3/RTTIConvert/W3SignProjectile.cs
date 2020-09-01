using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SignProjectile : CProjectileTrajectory
	{
		[Ordinal(1)] [RED("("projData")] 		public SSignProjectile ProjData { get; set;}

		[Ordinal(2)] [RED("("owner")] 		public CHandle<W3SignOwner> Owner { get; set;}

		[Ordinal(3)] [RED("("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(4)] [RED("("signSkill")] 		public CEnum<ESkill> SignSkill { get; set;}

		[Ordinal(5)] [RED("("wantedTarget")] 		public CHandle<CGameplayEntity> WantedTarget { get; set;}

		[Ordinal(6)] [RED("("signEntity")] 		public CHandle<W3SignEntity> SignEntity { get; set;}

		[Ordinal(7)] [RED("("hitEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> HitEntities { get; set;}

		[Ordinal(8)] [RED("("attackRange")] 		public CHandle<CAIAttackRange> AttackRange { get; set;}

		[Ordinal(9)] [RED("("isReusable")] 		public CBool IsReusable { get; set;}

		public W3SignProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SignProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
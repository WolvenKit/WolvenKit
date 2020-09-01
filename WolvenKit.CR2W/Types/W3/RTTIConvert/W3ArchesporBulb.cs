using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ArchesporBulb : CNewNPC
	{
		[Ordinal(0)] [RED("("parentEntity")] 		public CHandle<CNewNPC> ParentEntity { get; set;}

		[Ordinal(0)] [RED("("entitiesInRange", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInRange { get; set;}

		[Ordinal(0)] [RED("("isDestroyed")] 		public CBool IsDestroyed { get; set;}

		[Ordinal(0)] [RED("("hitsTaken")] 		public CInt32 HitsTaken { get; set;}

		[Ordinal(0)] [RED("("lastHitTimestamp")] 		public CFloat LastHitTimestamp { get; set;}

		[Ordinal(0)] [RED("("hitCooldown")] 		public CFloat HitCooldown { get; set;}

		[Ordinal(0)] [RED("("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(0)] [RED("("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(0)] [RED("("hitsToDeath")] 		public CInt32 HitsToDeath { get; set;}

		public W3ArchesporBulb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ArchesporBulb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
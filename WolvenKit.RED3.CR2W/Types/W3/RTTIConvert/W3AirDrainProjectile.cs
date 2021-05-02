using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AirDrainProjectile : W3AdvancedProjectile
	{
		[Ordinal(1)] [RED("destructionEntity")] 		public CHandle<CEntityTemplate> DestructionEntity { get; set;}

		[Ordinal(2)] [RED("markerEntityTemplate")] 		public CHandle<CEntityTemplate> MarkerEntityTemplate { get; set;}

		[Ordinal(3)] [RED("AirToDrain")] 		public CFloat AirToDrain { get; set;}

		[Ordinal(4)] [RED("initFxName")] 		public CName InitFxName { get; set;}

		[Ordinal(5)] [RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[Ordinal(6)] [RED("onCollisionFxName2")] 		public CName OnCollisionFxName2 { get; set;}

		[Ordinal(7)] [RED("markerEntity")] 		public CHandle<CEntity> MarkerEntity { get; set;}

		[Ordinal(8)] [RED("projectileHitGround")] 		public CBool ProjectileHitGround { get; set;}

		public W3AirDrainProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AirDrainProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
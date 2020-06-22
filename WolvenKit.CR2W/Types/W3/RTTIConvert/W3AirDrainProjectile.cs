using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AirDrainProjectile : W3AdvancedProjectile
	{
		[RED("destructionEntity")] 		public CHandle<CEntityTemplate> DestructionEntity { get; set;}

		[RED("markerEntityTemplate")] 		public CHandle<CEntityTemplate> MarkerEntityTemplate { get; set;}

		[RED("AirToDrain")] 		public CFloat AirToDrain { get; set;}

		[RED("initFxName")] 		public CName InitFxName { get; set;}

		[RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[RED("onCollisionFxName2")] 		public CName OnCollisionFxName2 { get; set;}

		[RED("markerEntity")] 		public CHandle<CEntity> MarkerEntity { get; set;}

		[RED("projectileHitGround")] 		public CBool ProjectileHitGround { get; set;}

		public W3AirDrainProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AirDrainProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
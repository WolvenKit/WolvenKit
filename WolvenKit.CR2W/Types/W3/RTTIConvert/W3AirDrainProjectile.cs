using System.IO;using System.Runtime.Serialization;
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

		public W3AirDrainProjectile(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3AirDrainProjectile(cr2w);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskActivateRift : CBTTaskAttack
	{
		[RED("resourceNameRift")] 		public CName ResourceNameRift { get; set;}

		[RED("resourceNameGround")] 		public CName ResourceNameGround { get; set;}

		[RED("entityRiftTemplate")] 		public CHandle<CEntityTemplate> EntityRiftTemplate { get; set;}

		[RED("entityGroundTemplate")] 		public CHandle<CEntityTemplate> EntityGroundTemplate { get; set;}

		[RED("targetPos")] 		public Vector TargetPos { get; set;}

		[RED("targetRot")] 		public EulerAngles TargetRot { get; set;}

		[RED("heightOffset")] 		public CFloat HeightOffset { get; set;}

		[RED("entityRift")] 		public CHandle<CEntity> EntityRift { get; set;}

		[RED("entityGround")] 		public CHandle<CEntity> EntityGround { get; set;}

		[RED("casterPos")] 		public Vector CasterPos { get; set;}

		[RED("riftPos")] 		public Vector RiftPos { get; set;}

		[RED("rift")] 		public CHandle<CRiftEntity> Rift { get; set;}

		[RED("ground")] 		public CHandle<CRiftEntity> Ground { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public CBTTaskActivateRift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskActivateRift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
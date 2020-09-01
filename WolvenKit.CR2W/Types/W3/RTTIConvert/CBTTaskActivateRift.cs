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
		[Ordinal(1)] [RED("("resourceNameRift")] 		public CName ResourceNameRift { get; set;}

		[Ordinal(2)] [RED("("resourceNameGround")] 		public CName ResourceNameGround { get; set;}

		[Ordinal(3)] [RED("("entityRiftTemplate")] 		public CHandle<CEntityTemplate> EntityRiftTemplate { get; set;}

		[Ordinal(4)] [RED("("entityGroundTemplate")] 		public CHandle<CEntityTemplate> EntityGroundTemplate { get; set;}

		[Ordinal(5)] [RED("("targetPos")] 		public Vector TargetPos { get; set;}

		[Ordinal(6)] [RED("("targetRot")] 		public EulerAngles TargetRot { get; set;}

		[Ordinal(7)] [RED("("heightOffset")] 		public CFloat HeightOffset { get; set;}

		[Ordinal(8)] [RED("("entityRift")] 		public CHandle<CEntity> EntityRift { get; set;}

		[Ordinal(9)] [RED("("entityGround")] 		public CHandle<CEntity> EntityGround { get; set;}

		[Ordinal(10)] [RED("("casterPos")] 		public Vector CasterPos { get; set;}

		[Ordinal(11)] [RED("("riftPos")] 		public Vector RiftPos { get; set;}

		[Ordinal(12)] [RED("("rift")] 		public CHandle<CRiftEntity> Rift { get; set;}

		[Ordinal(13)] [RED("("ground")] 		public CHandle<CRiftEntity> Ground { get; set;}

		[Ordinal(14)] [RED("("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(15)] [RED("("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public CBTTaskActivateRift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskActivateRift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
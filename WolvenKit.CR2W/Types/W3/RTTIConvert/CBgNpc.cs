using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBgNpc : CEntity
	{
		[RED("displayName")] 		public LocalizedString DisplayName { get; set;}

		[RED("voiceset")] 		public CPtr<CVoicesetParam> Voiceset { get; set;}

		[RED("headBoneIndex")] 		public CInt32 HeadBoneIndex { get; set;}

		[RED("jobTree")] 		public CSoft<CJobTree> JobTree { get; set;}

		[RED("jobTrees", 2,0)] 		public CArray<SBgNpcJobTree> JobTrees { get; set;}

		[RED("category")] 		public CName Category { get; set;}

		[RED("collisionCapsule")] 		public CBool CollisionCapsule { get; set;}

		[RED("originalTemplete")] 		public CHandle<CEntityTemplate> OriginalTemplete { get; set;}

		public CBgNpc(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBgNpc(cr2w);

	}
}
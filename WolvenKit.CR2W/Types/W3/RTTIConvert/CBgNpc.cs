using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBgNpc : CEntity
	{
		[Ordinal(1)] [RED("displayName")] 		public LocalizedString DisplayName { get; set;}

		[Ordinal(2)] [RED("voiceset")] 		public CPtr<CVoicesetParam> Voiceset { get; set;}

		[Ordinal(3)] [RED("headBoneIndex")] 		public CInt32 HeadBoneIndex { get; set;}

		[Ordinal(4)] [RED("jobTree")] 		public CSoft<CJobTree> JobTree { get; set;}

		[Ordinal(5)] [RED("jobTrees", 2,0)] 		public CArray<SBgNpcJobTree> JobTrees { get; set;}

		[Ordinal(6)] [RED("category")] 		public CName Category { get; set;}

		[Ordinal(7)] [RED("collisionCapsule")] 		public CBool CollisionCapsule { get; set;}

		[Ordinal(8)] [RED("originalTemplete")] 		public CHandle<CEntityTemplate> OriginalTemplete { get; set;}

		public CBgNpc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBgNpc(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
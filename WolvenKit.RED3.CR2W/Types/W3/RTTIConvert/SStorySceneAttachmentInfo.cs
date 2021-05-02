using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneAttachmentInfo : CVariable
	{
		[Ordinal(1)] [RED("attachTo")] 		public CName AttachTo { get; set;}

		[Ordinal(2)] [RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[Ordinal(3)] [RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[Ordinal(4)] [RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[Ordinal(5)] [RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[Ordinal(6)] [RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		public SStorySceneAttachmentInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStorySceneAttachmentInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
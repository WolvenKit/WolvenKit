using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneAttachmentInfo : CVariable
	{
		[RED("attachTo")] 		public CName AttachTo { get; set;}

		[RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		public SStorySceneAttachmentInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SStorySceneAttachmentInfo(cr2w);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHardAttachment : IAttachment
	{
		[Ordinal(1)] [RED("relativeTransform")] 		public EngineTransform RelativeTransform { get; set;}

		[Ordinal(2)] [RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[Ordinal(3)] [RED("attachmentFlags")] 		public CEnum<EHardAttachmentFlags> AttachmentFlags { get; set;}

		[Ordinal(4)] [RED("parentSlot")] 		public CPtr<ISlot> ParentSlot { get; set;}

		public CHardAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHardAttachment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
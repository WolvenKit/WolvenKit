using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHardAttachment : IAttachment
	{
		[Ordinal(1)] [RED("relativeTransform")] 		public EngineTransform RelativeTransform { get; set;}

		[Ordinal(2)] [RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[Ordinal(3)] [RED("attachmentFlags")] 		public CEnum<EHardAttachmentFlags> AttachmentFlags { get; set;}

		[Ordinal(4)] [RED("parentSlot")] 		public CPtr<ISlot> ParentSlot { get; set;}

		public CHardAttachment(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHardAttachment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
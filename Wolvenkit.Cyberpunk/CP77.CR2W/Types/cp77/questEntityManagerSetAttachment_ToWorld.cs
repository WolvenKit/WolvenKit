using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_ToWorld : questIEntityManagerSetAttachment_NodeSubType
	{
		[Ordinal(0)]  [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
		[Ordinal(1)]  [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(2)]  [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }
		[Ordinal(3)]  [RED("offsetMode")] public CEnum<questAttachmentOffsetMode> OffsetMode { get; set; }

		public questEntityManagerSetAttachment_ToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

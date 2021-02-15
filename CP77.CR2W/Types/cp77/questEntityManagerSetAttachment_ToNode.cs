using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_ToNode : questIEntityManagerSetAttachment_NodeSubType
	{
		[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
		[Ordinal(1)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(2)] [RED("slot")] public CName Slot { get; set; }
		[Ordinal(3)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(4)] [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public questEntityManagerSetAttachment_ToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

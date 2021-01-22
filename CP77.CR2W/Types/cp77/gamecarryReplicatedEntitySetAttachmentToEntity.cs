using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamecarryReplicatedEntitySetAttachmentToEntity : netEntityAttachmentInterface
	{
		[Ordinal(0)]  [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(1)]  [RED("localTransform")] public Transform LocalTransform { get; set; }
		[Ordinal(2)]  [RED("slot")] public CName Slot { get; set; }

		public gamecarryReplicatedEntitySetAttachmentToEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

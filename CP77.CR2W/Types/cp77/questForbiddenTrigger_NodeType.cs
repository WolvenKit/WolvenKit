using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questForbiddenTrigger_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("activate")] public CBool Activate { get; set; }
		[Ordinal(1)]  [RED("dismount")] public CBool Dismount { get; set; }
		[Ordinal(2)]  [RED("triggerNodeRef")] public NodeRef TriggerNodeRef { get; set; }

		public questForbiddenTrigger_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForbiddenTrigger_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("triggerNodeRef")] public NodeRef TriggerNodeRef { get; set; }
		[Ordinal(1)] [RED("activate")] public CBool Activate { get; set; }
		[Ordinal(2)] [RED("dismount")] public CBool Dismount { get; set; }

		public questForbiddenTrigger_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

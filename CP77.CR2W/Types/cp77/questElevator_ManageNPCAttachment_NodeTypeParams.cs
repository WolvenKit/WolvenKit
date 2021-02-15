using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questElevator_ManageNPCAttachment_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("elevatorRef")] public NodeRef ElevatorRef { get; set; }
		[Ordinal(1)] [RED("npcRef")] public gameEntityReference NpcRef { get; set; }
		[Ordinal(2)] [RED("action")] public CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> Action { get; set; }

		public questElevator_ManageNPCAttachment_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

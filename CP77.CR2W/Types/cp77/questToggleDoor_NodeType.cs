using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questToggleDoor_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(1)]  [RED("doorAction")] public CEnum<vehicleEQuestVehicleDoorState> DoorAction { get; set; }
		[Ordinal(2)]  [RED("doorID")] public CName DoorID { get; set; }
		[Ordinal(3)]  [RED("toOpen")] public CBool ToOpen { get; set; }
		[Ordinal(4)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }

		public questToggleDoor_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

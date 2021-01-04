using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleToggleDoorWrapperEvent : redEvent
	{
		[Ordinal(0)]  [RED("action")] public CEnum<vehicleEQuestVehicleDoorState> Action { get; set; }
		[Ordinal(1)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }

		public vehicleToggleDoorWrapperEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleDoor_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)] [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(2)] [RED("state")] public CEnum<vehicleVehicleDoorState> State { get; set; }

		public questVehicleDoor_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

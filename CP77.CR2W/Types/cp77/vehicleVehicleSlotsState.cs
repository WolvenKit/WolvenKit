using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleSlotsState : ISerializable
	{
		[Ordinal(0)] [RED("vehicleDoorState")] public CEnum<vehicleVehicleDoorState> VehicleDoorState { get; set; }
		[Ordinal(1)] [RED("vehicleWindowState")] public CEnum<vehicleEVehicleWindowState> VehicleWindowState { get; set; }
		[Ordinal(2)] [RED("vehicleInteractionState")] public CEnum<vehicleVehicleDoorInteractionState> VehicleInteractionState { get; set; }

		public vehicleVehicleSlotsState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

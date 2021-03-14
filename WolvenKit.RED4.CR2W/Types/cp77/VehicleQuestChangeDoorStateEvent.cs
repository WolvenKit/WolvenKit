using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestChangeDoorStateEvent : redEvent
	{
		[Ordinal(0)] [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(1)] [RED("newState")] public CEnum<vehicleEQuestVehicleDoorState> NewState { get; set; }

		public VehicleQuestChangeDoorStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteractionStateChange : ActionBool
	{
		[Ordinal(0)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(1)]  [RED("newState")] public CEnum<vehicleVehicleDoorInteractionState> NewState { get; set; }
		[Ordinal(2)]  [RED("source")] public CString Source { get; set; }

		public VehicleDoorInteractionStateChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

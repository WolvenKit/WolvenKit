using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TemporaryDoorState : CVariable
	{
		[Ordinal(0)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(1)]  [RED("interactionState")] public CEnum<vehicleVehicleDoorInteractionState> InteractionState { get; set; }

		public TemporaryDoorState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporaryDoorState : CVariable
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorInteractionState> _interactionState;

		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(1)] 
		[RED("interactionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> InteractionState
		{
			get => GetProperty(ref _interactionState);
			set => SetProperty(ref _interactionState, value);
		}

		public TemporaryDoorState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

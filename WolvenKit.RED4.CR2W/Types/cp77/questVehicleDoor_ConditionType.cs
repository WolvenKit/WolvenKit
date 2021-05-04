using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleDoor_ConditionType : questIVehicleConditionType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorState> _state;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<vehicleVehicleDoorState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public questVehicleDoor_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

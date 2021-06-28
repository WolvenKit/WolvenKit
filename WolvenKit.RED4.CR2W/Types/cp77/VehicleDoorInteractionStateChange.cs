using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteractionStateChange : ActionBool
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorInteractionState> _newState;
		private CString _source;

		[Ordinal(25)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(26)] 
		[RED("newState")] 
		public CEnum<vehicleVehicleDoorInteractionState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		[Ordinal(27)] 
		[RED("source")] 
		public CString Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public VehicleDoorInteractionStateChange(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleDoor_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEQuestVehicleDoorState> _doorAction;
		private CEnum<vehicleEVehicleDoor> _door;
		private CBool _toOpen;
		private CName _doorID;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("doorAction")] 
		public CEnum<vehicleEQuestVehicleDoorState> DoorAction
		{
			get => GetProperty(ref _doorAction);
			set => SetProperty(ref _doorAction, value);
		}

		[Ordinal(2)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(3)] 
		[RED("toOpen")] 
		public CBool ToOpen
		{
			get => GetProperty(ref _toOpen);
			set => SetProperty(ref _toOpen, value);
		}

		[Ordinal(4)] 
		[RED("doorID")] 
		public CName DoorID
		{
			get => GetProperty(ref _doorID);
			set => SetProperty(ref _doorID, value);
		}

		public questToggleDoor_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

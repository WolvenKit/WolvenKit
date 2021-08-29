using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questToggleDoor_NodeType : questIVehicleManagerNodeType
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
	}
}

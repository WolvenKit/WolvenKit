using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleWindow_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEQuestVehicleWindowState> _windowState;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("windowState")] 
		public CEnum<vehicleEQuestVehicleWindowState> WindowState
		{
			get => GetProperty(ref _windowState);
			set => SetProperty(ref _windowState, value);
		}

		[Ordinal(2)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		public questToggleWindow_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

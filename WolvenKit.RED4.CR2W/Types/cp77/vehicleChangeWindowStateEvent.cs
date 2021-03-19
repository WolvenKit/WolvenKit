using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChangeWindowStateEvent : redEvent
	{
		private CEnum<vehicleEQuestVehicleWindowState> _state;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleEQuestVehicleWindowState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		public vehicleChangeWindowStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

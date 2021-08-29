using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElevatorTerminalLogicController : DeviceWidgetControllerBase
	{
		private inkFlexWidgetReference _elevatorUpArrowsWidget;
		private inkFlexWidgetReference _elevatorDownArrowsWidget;
		private CEnum<EForcedElevatorArrowsState> _forcedElevatorArrowsState;

		[Ordinal(10)] 
		[RED("elevatorUpArrowsWidget")] 
		public inkFlexWidgetReference ElevatorUpArrowsWidget
		{
			get => GetProperty(ref _elevatorUpArrowsWidget);
			set => SetProperty(ref _elevatorUpArrowsWidget, value);
		}

		[Ordinal(11)] 
		[RED("elevatorDownArrowsWidget")] 
		public inkFlexWidgetReference ElevatorDownArrowsWidget
		{
			get => GetProperty(ref _elevatorDownArrowsWidget);
			set => SetProperty(ref _elevatorDownArrowsWidget, value);
		}

		[Ordinal(12)] 
		[RED("forcedElevatorArrowsState")] 
		public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState
		{
			get => GetProperty(ref _forcedElevatorArrowsState);
			set => SetProperty(ref _forcedElevatorArrowsState, value);
		}
	}
}

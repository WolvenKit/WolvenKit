using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorTerminalLogicController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] 
		[RED("elevatorUpArrowsWidget")] 
		public inkFlexWidgetReference ElevatorUpArrowsWidget
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("elevatorDownArrowsWidget")] 
		public inkFlexWidgetReference ElevatorDownArrowsWidget
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("forcedElevatorArrowsState")] 
		public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState
		{
			get => GetPropertyValue<CEnum<EForcedElevatorArrowsState>>();
			set => SetPropertyValue<CEnum<EForcedElevatorArrowsState>>(value);
		}

		public ElevatorTerminalLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

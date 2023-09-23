using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorTerminalFakeGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("elevatorTerminalWidget")] 
		public inkCanvasWidgetReference ElevatorTerminalWidget
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		public ElevatorTerminalFakeGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

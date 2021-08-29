using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElevatorTerminalFakeGameController : DeviceInkGameControllerBase
	{
		private inkCanvasWidgetReference _elevatorTerminalWidget;

		[Ordinal(16)] 
		[RED("elevatorTerminalWidget")] 
		public inkCanvasWidgetReference ElevatorTerminalWidget
		{
			get => GetProperty(ref _elevatorTerminalWidget);
			set => SetProperty(ref _elevatorTerminalWidget, value);
		}
	}
}

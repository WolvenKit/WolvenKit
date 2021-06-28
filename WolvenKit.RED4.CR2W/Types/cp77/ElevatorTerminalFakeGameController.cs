using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalFakeGameController : DeviceInkGameControllerBase
	{
		private inkCanvasWidgetReference _elevatorTerminalWidget;

		[Ordinal(16)] 
		[RED("elevatorTerminalWidget")] 
		public inkCanvasWidgetReference ElevatorTerminalWidget
		{
			get => GetProperty(ref _elevatorTerminalWidget);
			set => SetProperty(ref _elevatorTerminalWidget, value);
		}

		public ElevatorTerminalFakeGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalFakeGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("elevatorTerminalWidget")] public inkCanvasWidgetReference ElevatorTerminalWidget { get; set; }

		public ElevatorTerminalFakeGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

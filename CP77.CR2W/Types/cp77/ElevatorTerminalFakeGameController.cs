using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalFakeGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("elevatorTerminalWidget")] public inkCanvasWidgetReference ElevatorTerminalWidget { get; set; }

		public ElevatorTerminalFakeGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

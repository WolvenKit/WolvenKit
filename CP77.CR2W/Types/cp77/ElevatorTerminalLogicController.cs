using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalLogicController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("elevatorDownArrowsWidget")] public inkFlexWidgetReference ElevatorDownArrowsWidget { get; set; }
		[Ordinal(1)]  [RED("elevatorUpArrowsWidget")] public inkFlexWidgetReference ElevatorUpArrowsWidget { get; set; }
		[Ordinal(2)]  [RED("forcedElevatorArrowsState")] public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState { get; set; }

		public ElevatorTerminalLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

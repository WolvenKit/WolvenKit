using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
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

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalLogicController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] [RED("elevatorUpArrowsWidget")] public inkFlexWidgetReference ElevatorUpArrowsWidget { get; set; }
		[Ordinal(11)] [RED("elevatorDownArrowsWidget")] public inkFlexWidgetReference ElevatorDownArrowsWidget { get; set; }
		[Ordinal(12)] [RED("forcedElevatorArrowsState")] public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState { get; set; }

		public ElevatorTerminalLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

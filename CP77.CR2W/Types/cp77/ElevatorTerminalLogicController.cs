using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElevatorTerminalLogicController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("targetWidgetRef")] public inkWidgetReference TargetWidgetRef { get; set; }
		[Ordinal(1)]  [RED("displayNameWidget")] public inkTextWidgetReference DisplayNameWidget { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("targetWidget")] public wCHandle<inkWidget> TargetWidget { get; set; }
		[Ordinal(4)]  [RED("backgroundTextureRef")] public inkImageWidgetReference BackgroundTextureRef { get; set; }
		[Ordinal(5)]  [RED("statusNameWidget")] public inkTextWidgetReference StatusNameWidget { get; set; }
		[Ordinal(6)]  [RED("actionsListWidget")] public inkWidgetReference ActionsListWidget { get; set; }
		[Ordinal(7)]  [RED("actionWidgetsData")] public CArray<SActionWidgetPackage> ActionWidgetsData { get; set; }
		[Ordinal(8)]  [RED("actionData")] public CHandle<ResolveActionData> ActionData { get; set; }
		[Ordinal(9)]  [RED("elevatorUpArrowsWidget")] public inkFlexWidgetReference ElevatorUpArrowsWidget { get; set; }
		[Ordinal(10)]  [RED("elevatorDownArrowsWidget")] public inkFlexWidgetReference ElevatorDownArrowsWidget { get; set; }
		[Ordinal(11)]  [RED("forcedElevatorArrowsState")] public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState { get; set; }

		public ElevatorTerminalLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceActionWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(26)] [RED("actions")] public CArray<wCHandle<gamedeviceAction>> Actions { get; set; }
		[Ordinal(27)] [RED("actionData")] public CHandle<ResolveActionData> ActionData { get; set; }

		public DeviceActionWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

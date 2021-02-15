using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceWidgetControllerBase : DeviceInkLogicControllerBase
	{
		[Ordinal(5)] [RED("backgroundTextureRef")] public inkImageWidgetReference BackgroundTextureRef { get; set; }
		[Ordinal(6)] [RED("statusNameWidget")] public inkTextWidgetReference StatusNameWidget { get; set; }
		[Ordinal(7)] [RED("actionsListWidget")] public inkWidgetReference ActionsListWidget { get; set; }
		[Ordinal(8)] [RED("actionWidgetsData")] public CArray<SActionWidgetPackage> ActionWidgetsData { get; set; }
		[Ordinal(9)] [RED("actionData")] public CHandle<ResolveActionData> ActionData { get; set; }

		public DeviceWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

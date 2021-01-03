using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceActionWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(0)]  [RED("actionData")] public CHandle<ResolveActionData> ActionData { get; set; }
		[Ordinal(1)]  [RED("actions")] public CArray<wCHandle<gamedeviceAction>> Actions { get; set; }

		public DeviceActionWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

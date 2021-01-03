using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceInkLogicControllerBase : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("displayNameWidget")] public inkTextWidgetReference DisplayNameWidget { get; set; }
		[Ordinal(1)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(2)]  [RED("targetWidget")] public wCHandle<inkWidget> TargetWidget { get; set; }
		[Ordinal(3)]  [RED("targetWidgetRef")] public inkWidgetReference TargetWidgetRef { get; set; }

		public DeviceInkLogicControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

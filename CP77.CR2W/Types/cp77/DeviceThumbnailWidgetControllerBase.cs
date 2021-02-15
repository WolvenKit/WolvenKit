using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceThumbnailWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(26)] [RED("deviceIconRef")] public inkImageWidgetReference DeviceIconRef { get; set; }
		[Ordinal(27)] [RED("statusNameWidget")] public inkTextWidgetReference StatusNameWidget { get; set; }
		[Ordinal(28)] [RED("thumbnailAction")] public wCHandle<ThumbnailUI> ThumbnailAction { get; set; }

		public DeviceThumbnailWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

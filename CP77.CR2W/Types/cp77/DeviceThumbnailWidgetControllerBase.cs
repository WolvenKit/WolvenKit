using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceThumbnailWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(0)]  [RED("deviceIconRef")] public inkImageWidgetReference DeviceIconRef { get; set; }
		[Ordinal(1)]  [RED("statusNameWidget")] public inkTextWidgetReference StatusNameWidget { get; set; }
		[Ordinal(2)]  [RED("thumbnailAction")] public wCHandle<ThumbnailUI> ThumbnailAction { get; set; }

		public DeviceThumbnailWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

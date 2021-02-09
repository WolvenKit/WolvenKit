using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotification : GenericNotificationController
	{
		[Ordinal(9)]  [RED("animation")] public CHandle<inkanimProxy> Animation { get; set; }
		[Ordinal(10)]  [RED("zone_data")] public CHandle<ZoneAlertNotificationViewData> Zone_data { get; set; }
		[Ordinal(11)]  [RED("ZoneLabelText")] public inkTextWidgetReference ZoneLabelText { get; set; }

		public ZoneAlertNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

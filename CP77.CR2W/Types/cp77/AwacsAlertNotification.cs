using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AwacsAlertNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("ZoneLabelText")] public inkTextWidgetReference ZoneLabelText { get; set; }
		[Ordinal(1)]  [RED("animation")] public CHandle<inkanimProxy> Animation { get; set; }
		[Ordinal(2)]  [RED("zone_data")] public CHandle<VehicleAlertNotificationViewData> Zone_data { get; set; }

		public AwacsAlertNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleAlertNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("ZoneLabelText")] public inkTextWidgetReference ZoneLabelText { get; set; }
		[Ordinal(1)]  [RED("animation")] public CHandle<inkanimProxy> Animation { get; set; }
		[Ordinal(2)]  [RED("zone_data")] public CHandle<VehicleAlertNotificationViewData> Zone_data { get; set; }

		public VehicleAlertNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OpenWorldMapNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] [RED("eventDispatcher")] public wCHandle<worlduiIWidgetGameController> EventDispatcher { get; set; }

		public OpenWorldMapNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

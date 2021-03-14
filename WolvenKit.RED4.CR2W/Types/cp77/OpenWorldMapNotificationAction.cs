using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenWorldMapNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] [RED("eventDispatcher")] public wCHandle<worlduiIWidgetGameController> EventDispatcher { get; set; }

		public OpenWorldMapNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

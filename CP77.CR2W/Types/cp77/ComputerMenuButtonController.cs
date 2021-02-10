using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuButtonController : DeviceButtonLogicControllerBase
	{
		[Ordinal(16)]  [RED("counterWidget")] public inkTextWidgetReference CounterWidget { get; set; }
		[Ordinal(17)]  [RED("notificationidget")] public inkWidgetReference Notificationidget { get; set; }
		[Ordinal(18)]  [RED("menuID")] public CString MenuID { get; set; }

		public ComputerMenuButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

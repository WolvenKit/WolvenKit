using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuButtonController : DeviceButtonLogicControllerBase
	{
		[Ordinal(0)]  [RED("counterWidget")] public inkTextWidgetReference CounterWidget { get; set; }
		[Ordinal(1)]  [RED("menuID")] public CString MenuID { get; set; }
		[Ordinal(2)]  [RED("notificationidget")] public inkWidgetReference Notificationidget { get; set; }

		public ComputerMenuButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

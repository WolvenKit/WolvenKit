using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuButtonController : DeviceButtonLogicControllerBase
	{
		[Ordinal(26)] [RED("counterWidget")] public inkTextWidgetReference CounterWidget { get; set; }
		[Ordinal(27)] [RED("notificationidget")] public inkWidgetReference Notificationidget { get; set; }
		[Ordinal(28)] [RED("menuID")] public CString MenuID { get; set; }

		public ComputerMenuButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

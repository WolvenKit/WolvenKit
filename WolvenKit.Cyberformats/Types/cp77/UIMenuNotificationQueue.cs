using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIMenuNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }

		public UIMenuNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

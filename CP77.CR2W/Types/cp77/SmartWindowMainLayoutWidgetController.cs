using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
	{
		[Ordinal(34)]  [RED("menuMailsSlot")] public inkWidgetReference MenuMailsSlot { get; set; }
		[Ordinal(35)]  [RED("menuFilesSlot")] public inkWidgetReference MenuFilesSlot { get; set; }
		[Ordinal(36)]  [RED("menuNewsFeedSlot")] public inkWidgetReference MenuNewsFeedSlot { get; set; }
		[Ordinal(37)]  [RED("menuDevicesSlot")] public inkWidgetReference MenuDevicesSlot { get; set; }

		public SmartWindowMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

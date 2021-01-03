using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
	{
		[Ordinal(0)]  [RED("menuDevicesSlot")] public inkWidgetReference MenuDevicesSlot { get; set; }
		[Ordinal(1)]  [RED("menuFilesSlot")] public inkWidgetReference MenuFilesSlot { get; set; }
		[Ordinal(2)]  [RED("menuMailsSlot")] public inkWidgetReference MenuMailsSlot { get; set; }
		[Ordinal(3)]  [RED("menuNewsFeedSlot")] public inkWidgetReference MenuNewsFeedSlot { get; set; }

		public SmartWindowMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

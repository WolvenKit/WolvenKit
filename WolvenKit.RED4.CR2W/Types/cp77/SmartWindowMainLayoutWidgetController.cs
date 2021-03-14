using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
	{
		[Ordinal(35)] [RED("menuMailsSlot")] public inkWidgetReference MenuMailsSlot { get; set; }
		[Ordinal(36)] [RED("menuFilesSlot")] public inkWidgetReference MenuFilesSlot { get; set; }
		[Ordinal(37)] [RED("menuNewsFeedSlot")] public inkWidgetReference MenuNewsFeedSlot { get; set; }
		[Ordinal(38)] [RED("menuDevicesSlot")] public inkWidgetReference MenuDevicesSlot { get; set; }

		public SmartWindowMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

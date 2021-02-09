using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("msgCount")] public inkTextWidgetReference MsgCount { get; set; }
		[Ordinal(2)]  [RED("msgIndicator")] public inkWidgetReference MsgIndicator { get; set; }
		[Ordinal(3)]  [RED("questFlag")] public inkWidgetReference QuestFlag { get; set; }
		[Ordinal(4)]  [RED("regFlag")] public inkWidgetReference RegFlag { get; set; }
		[Ordinal(5)]  [RED("animProxyQuest")] public CHandle<inkanimProxy> AnimProxyQuest { get; set; }
		[Ordinal(6)]  [RED("animProxySelection")] public CHandle<inkanimProxy> AnimProxySelection { get; set; }
		[Ordinal(7)]  [RED("contactData")] public CHandle<ContactData> ContactData { get; set; }

		public PhoneContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

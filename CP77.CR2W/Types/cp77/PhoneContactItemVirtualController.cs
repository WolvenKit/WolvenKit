using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(16)] [RED("msgCount")] public inkTextWidgetReference MsgCount { get; set; }
		[Ordinal(17)] [RED("msgIndicator")] public inkWidgetReference MsgIndicator { get; set; }
		[Ordinal(18)] [RED("questFlag")] public inkWidgetReference QuestFlag { get; set; }
		[Ordinal(19)] [RED("regFlag")] public inkWidgetReference RegFlag { get; set; }
		[Ordinal(20)] [RED("animProxyQuest")] public CHandle<inkanimProxy> AnimProxyQuest { get; set; }
		[Ordinal(21)] [RED("animProxySelection")] public CHandle<inkanimProxy> AnimProxySelection { get; set; }
		[Ordinal(22)] [RED("contactData")] public CHandle<ContactData> ContactData { get; set; }

		public PhoneContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

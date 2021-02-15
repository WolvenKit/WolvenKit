using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(16)] [RED("msgPreview")] public inkTextWidgetReference MsgPreview { get; set; }
		[Ordinal(17)] [RED("msgCounter")] public inkTextWidgetReference MsgCounter { get; set; }
		[Ordinal(18)] [RED("msgIndicator")] public inkWidgetReference MsgIndicator { get; set; }
		[Ordinal(19)] [RED("replyAlertIcon")] public inkWidgetReference ReplyAlertIcon { get; set; }
		[Ordinal(20)] [RED("collapseIcon")] public inkWidgetReference CollapseIcon { get; set; }
		[Ordinal(21)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(22)] [RED("contactData")] public CHandle<ContactData> ContactData { get; set; }
		[Ordinal(23)] [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(24)] [RED("type")] public CEnum<MessengerContactType> Type { get; set; }
		[Ordinal(25)] [RED("activeItemSync")] public wCHandle<MessengerContactSyncData> ActiveItemSync { get; set; }
		[Ordinal(26)] [RED("isContactActive")] public CBool IsContactActive { get; set; }
		[Ordinal(27)] [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(28)] [RED("isItemToggled")] public CBool IsItemToggled { get; set; }

		public MessengerContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

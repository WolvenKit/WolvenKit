using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("msgPreview")] public inkTextWidgetReference MsgPreview { get; set; }
		[Ordinal(2)]  [RED("msgCounter")] public inkTextWidgetReference MsgCounter { get; set; }
		[Ordinal(3)]  [RED("msgIndicator")] public inkWidgetReference MsgIndicator { get; set; }
		[Ordinal(4)]  [RED("replyAlertIcon")] public inkWidgetReference ReplyAlertIcon { get; set; }
		[Ordinal(5)]  [RED("collapseIcon")] public inkWidgetReference CollapseIcon { get; set; }
		[Ordinal(6)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(7)]  [RED("contactData")] public CHandle<ContactData> ContactData { get; set; }
		[Ordinal(8)]  [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(9)]  [RED("type")] public CEnum<MessengerContactType> Type { get; set; }
		[Ordinal(10)]  [RED("activeItemSync")] public wCHandle<MessengerContactSyncData> ActiveItemSync { get; set; }
		[Ordinal(11)]  [RED("isContactActive")] public CBool IsContactActive { get; set; }
		[Ordinal(12)]  [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(13)]  [RED("isItemToggled")] public CBool IsItemToggled { get; set; }

		public MessengerContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

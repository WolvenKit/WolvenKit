using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessengerContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("activeItemSync")] public wCHandle<MessengerContactSyncData> ActiveItemSync { get; set; }
		[Ordinal(1)]  [RED("collapseIcon")] public inkWidgetReference CollapseIcon { get; set; }
		[Ordinal(2)]  [RED("contactData")] public CHandle<ContactData> ContactData { get; set; }
		[Ordinal(3)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(4)]  [RED("isContactActive")] public CBool IsContactActive { get; set; }
		[Ordinal(5)]  [RED("isItemHovered")] public CBool IsItemHovered { get; set; }
		[Ordinal(6)]  [RED("isItemToggled")] public CBool IsItemToggled { get; set; }
		[Ordinal(7)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(8)]  [RED("msgCounter")] public inkTextWidgetReference MsgCounter { get; set; }
		[Ordinal(9)]  [RED("msgIndicator")] public inkWidgetReference MsgIndicator { get; set; }
		[Ordinal(10)]  [RED("msgPreview")] public inkTextWidgetReference MsgPreview { get; set; }
		[Ordinal(11)]  [RED("nestedListData")] public CHandle<VirutalNestedListData> NestedListData { get; set; }
		[Ordinal(12)]  [RED("replyAlertIcon")] public inkWidgetReference ReplyAlertIcon { get; set; }
		[Ordinal(13)]  [RED("type")] public CEnum<MessengerContactType> Type { get; set; }

		public MessengerContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

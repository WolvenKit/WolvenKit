using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("activeEntry")] public wCHandle<gameJournalEntry> ActiveEntry { get; set; }
		[Ordinal(1)]  [RED("attachment")] public wCHandle<gameJournalEntry> Attachment { get; set; }
		[Ordinal(2)]  [RED("attachmentHash")] public CUInt32 AttachmentHash { get; set; }
		[Ordinal(3)]  [RED("avatarImage")] public inkImageWidgetReference AvatarImage { get; set; }
		[Ordinal(4)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(5)]  [RED("blackboardDef")] public CHandle<UI_ComDeviceDef> BlackboardDef { get; set; }
		[Ordinal(6)]  [RED("contactEntry")] public wCHandle<gameJournalContact> ContactEntry { get; set; }
		[Ordinal(7)]  [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(8)]  [RED("data")] public CHandle<JournalNotificationData> Data { get; set; }
		[Ordinal(9)]  [RED("dialogViewController")] public wCHandle<MessengerDialogViewController> DialogViewController { get; set; }
		[Ordinal(10)]  [RED("entry")] public wCHandle<gameJournalPhoneMessage> Entry { get; set; }
		[Ordinal(11)]  [RED("hintClose")] public inkWidgetReference HintClose { get; set; }
		[Ordinal(12)]  [RED("hintMessenger")] public inkWidgetReference HintMessenger { get; set; }
		[Ordinal(13)]  [RED("hintReply")] public inkWidgetReference HintReply { get; set; }
		[Ordinal(14)]  [RED("hintTrack")] public inkWidgetReference HintTrack { get; set; }
		[Ordinal(15)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(16)]  [RED("menuBackgrouns")] public inkWidgetReference MenuBackgrouns { get; set; }
		[Ordinal(17)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(18)]  [RED("proxy")] public CHandle<inkanimProxy> Proxy { get; set; }
		[Ordinal(19)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(20)]  [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }

		public PhoneMessagePopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("titleRef")] public inkTextWidgetReference TitleRef { get; set; }
		[Ordinal(1)]  [RED("textRef")] public inkTextWidgetReference TextRef { get; set; }
		[Ordinal(2)]  [RED("actionLabelRef")] public inkTextWidgetReference ActionLabelRef { get; set; }
		[Ordinal(3)]  [RED("actionRef")] public inkWidgetReference ActionRef { get; set; }
		[Ordinal(4)]  [RED("blockAction")] public CBool BlockAction { get; set; }
		[Ordinal(5)]  [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(6)]  [RED("data")] public CHandle<gameuiGenericNotificationViewData> Data { get; set; }
		[Ordinal(7)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(8)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(9)]  [RED("messageText")] public inkTextWidgetReference MessageText { get; set; }
		[Ordinal(10)]  [RED("avatar")] public inkImageWidgetReference Avatar { get; set; }
		[Ordinal(11)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(12)]  [RED("mappinIcon")] public inkImageWidgetReference MappinIcon { get; set; }
		[Ordinal(13)]  [RED("envelopIcon")] public inkWidgetReference EnvelopIcon { get; set; }
		[Ordinal(14)]  [RED("interactionsBlackboard")] public CHandle<gameIBlackboard> InteractionsBlackboard { get; set; }
		[Ordinal(15)]  [RED("bbListenerId")] public CUInt32 BbListenerId { get; set; }
		[Ordinal(16)]  [RED("messageData")] public CHandle<gameuiPhoneMessageNotificationViewData> MessageData { get; set; }
		[Ordinal(17)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(18)]  [RED("textSizeLimit")] public CInt32 TextSizeLimit { get; set; }
		[Ordinal(19)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(20)]  [RED("mappinSystem")] public wCHandle<gamemappinsMappinSystem> MappinSystem { get; set; }

		public MessengerNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("avatar")] public inkImageWidgetReference Avatar { get; set; }
		[Ordinal(2)]  [RED("bbListenerId")] public CUInt32 BbListenerId { get; set; }
		[Ordinal(3)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(4)]  [RED("envelopIcon")] public inkWidgetReference EnvelopIcon { get; set; }
		[Ordinal(5)]  [RED("interactionsBlackboard")] public CHandle<gameIBlackboard> InteractionsBlackboard { get; set; }
		[Ordinal(6)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(7)]  [RED("mappinIcon")] public inkImageWidgetReference MappinIcon { get; set; }
		[Ordinal(8)]  [RED("mappinSystem")] public wCHandle<gamemappinsMappinSystem> MappinSystem { get; set; }
		[Ordinal(9)]  [RED("messageData")] public CHandle<gameuiPhoneMessageNotificationViewData> MessageData { get; set; }
		[Ordinal(10)]  [RED("messageText")] public inkTextWidgetReference MessageText { get; set; }
		[Ordinal(11)]  [RED("textSizeLimit")] public CInt32 TextSizeLimit { get; set; }

		public MessengerNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

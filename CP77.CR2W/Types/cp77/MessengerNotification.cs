using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerNotification : GenericNotificationController
	{
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

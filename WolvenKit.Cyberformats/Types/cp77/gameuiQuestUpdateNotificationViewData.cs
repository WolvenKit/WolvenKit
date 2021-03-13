using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("questEntryId")] public CString QuestEntryId { get; set; }
		[Ordinal(6)] [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(7)] [RED("animation")] public CName Animation { get; set; }
		[Ordinal(8)] [RED("SMSText")] public CString SMSText { get; set; }
		[Ordinal(9)] [RED("dontRemoveOnRequest")] public CBool DontRemoveOnRequest { get; set; }
		[Ordinal(10)] [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(11)] [RED("rewardSC")] public CInt32 RewardSC { get; set; }
		[Ordinal(12)] [RED("rewardXP")] public CInt32 RewardXP { get; set; }
		[Ordinal(13)] [RED("priority")] public CEnum<EGenericNotificationPriority> Priority { get; set; }

		public gameuiQuestUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

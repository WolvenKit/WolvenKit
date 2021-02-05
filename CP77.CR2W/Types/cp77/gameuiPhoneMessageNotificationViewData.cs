using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneMessageNotificationViewData : gameuiQuestUpdateNotificationViewData
	{
		[Ordinal(0)]  [RED("action")] public CHandle<GenericNotificationBaseAction> Action { get; set; }
		[Ordinal(1)]  [RED("dontRemoveOnRequest")] public CBool DontRemoveOnRequest { get; set; }
		[Ordinal(2)]  [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(3)]  [RED("rewardSC")] public CInt32 RewardSC { get; set; }
		[Ordinal(4)]  [RED("rewardXP")] public CInt32 RewardXP { get; set; }
		[Ordinal(5)]  [RED("priority")] public CEnum<EGenericNotificationPriority> Priority { get; set; }
		[Ordinal(6)]  [RED("threadHash")] public CInt32 ThreadHash { get; set; }
		[Ordinal(7)]  [RED("contactHash")] public CInt32 ContactHash { get; set; }

		public gameuiPhoneMessageNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

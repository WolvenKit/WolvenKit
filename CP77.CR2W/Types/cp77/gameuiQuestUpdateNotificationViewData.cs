using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("SMSText")] public CString SMSText { get; set; }
		[Ordinal(1)]  [RED("animation")] public CName Animation { get; set; }
		[Ordinal(2)]  [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(3)]  [RED("dontRemoveOnRequest")] public CBool DontRemoveOnRequest { get; set; }
		[Ordinal(4)]  [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(5)]  [RED("priority")] public CEnum<EGenericNotificationPriority> Priority { get; set; }
		[Ordinal(6)]  [RED("questEntryId")] public CString QuestEntryId { get; set; }
		[Ordinal(7)]  [RED("rewardSC")] public CInt32 RewardSC { get; set; }
		[Ordinal(8)]  [RED("rewardXP")] public CInt32 RewardXP { get; set; }

		public gameuiQuestUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

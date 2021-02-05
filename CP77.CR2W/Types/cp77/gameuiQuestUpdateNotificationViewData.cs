using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("questEntryId")] public CString QuestEntryId { get; set; }
		[Ordinal(1)]  [RED("canBeMerged")] public CBool CanBeMerged { get; set; }
		[Ordinal(2)]  [RED("animation")] public CName Animation { get; set; }
		[Ordinal(3)]  [RED("SMSText")] public CString SMSText { get; set; }

		public gameuiQuestUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

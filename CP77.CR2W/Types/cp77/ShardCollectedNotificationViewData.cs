using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(1)]  [RED("entry")] public CHandle<gameJournalOnscreen> Entry { get; set; }
		[Ordinal(2)]  [RED("isCrypted")] public CBool IsCrypted { get; set; }
		[Ordinal(3)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(4)]  [RED("shardTitle")] public CString ShardTitle { get; set; }

		public ShardCollectedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

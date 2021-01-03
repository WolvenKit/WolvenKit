using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("entry")] public CHandle<gameJournalOnscreen> Entry { get; set; }
		[Ordinal(1)]  [RED("isCrypted")] public CBool IsCrypted { get; set; }
		[Ordinal(2)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(3)]  [RED("shardTitle")] public CString ShardTitle { get; set; }

		public ShardCollectedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NotifyShardRead : redEvent
	{
		[Ordinal(0)] [RED("entry")] public CHandle<gameJournalOnscreen> Entry { get; set; }
		[Ordinal(1)] [RED("title")] public CString Title { get; set; }
		[Ordinal(2)] [RED("text")] public CString Text { get; set; }
		[Ordinal(3)] [RED("isCrypted")] public CBool IsCrypted { get; set; }
		[Ordinal(4)] [RED("itemID")] public gameItemID ItemID { get; set; }

		public NotifyShardRead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

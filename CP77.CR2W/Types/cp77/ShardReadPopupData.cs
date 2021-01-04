using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardReadPopupData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("isCrypted")] public CBool IsCrypted { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)]  [RED("text")] public CString Text { get; set; }
		[Ordinal(3)]  [RED("title")] public CString Title { get; set; }

		public ShardReadPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

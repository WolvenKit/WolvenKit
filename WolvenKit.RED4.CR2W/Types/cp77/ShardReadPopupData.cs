using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardReadPopupData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("title")] public CString Title { get; set; }
		[Ordinal(7)] [RED("text")] public CString Text { get; set; }
		[Ordinal(8)] [RED("isCrypted")] public CBool IsCrypted { get; set; }
		[Ordinal(9)] [RED("itemID")] public gameItemID ItemID { get; set; }

		public ShardReadPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

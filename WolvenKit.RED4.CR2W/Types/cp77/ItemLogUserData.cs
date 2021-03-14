using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLogUserData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(7)] [RED("itemLogQueueEmpty")] public CBool ItemLogQueueEmpty { get; set; }

		public ItemLogUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

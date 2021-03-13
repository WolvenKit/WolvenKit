using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiItemAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(6)] [RED("animation")] public CName Animation { get; set; }
		[Ordinal(7)] [RED("itemRarity")] public CName ItemRarity { get; set; }

		public gameuiItemAddedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

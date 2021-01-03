using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupCloseData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("confirm")] public CBool Confirm { get; set; }
		[Ordinal(1)]  [RED("items")] public CArray<wCHandle<gameItemData>> Items { get; set; }
		[Ordinal(2)]  [RED("limitedItems")] public CArray<CHandle<VendorJunkSellItem>> LimitedItems { get; set; }

		public VendorSellJunkPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

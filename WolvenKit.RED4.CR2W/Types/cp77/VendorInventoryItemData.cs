using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorInventoryItemData : WrappedInventoryItemData
	{
		[Ordinal(5)] [RED("IsVendorItem")] public CBool IsVendorItem { get; set; }
		[Ordinal(6)] [RED("IsEnoughMoney")] public CBool IsEnoughMoney { get; set; }
		[Ordinal(7)] [RED("IsBuybackStack")] public CBool IsBuybackStack { get; set; }

		public VendorInventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

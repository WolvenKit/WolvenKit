using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorShoppingCartItem : CVariable
	{
		[Ordinal(0)]  [RED("itemData")] public wCHandle<gameItemData> ItemData { get; set; }
		[Ordinal(1)]  [RED("amount")] public CInt32 Amount { get; set; }

		public VendorShoppingCartItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

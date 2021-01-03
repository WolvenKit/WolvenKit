using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendorShoppingCartItem : CVariable
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("itemData")] public wCHandle<gameItemData> ItemData { get; set; }

		public VendorShoppingCartItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

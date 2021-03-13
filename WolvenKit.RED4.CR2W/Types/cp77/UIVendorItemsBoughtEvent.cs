using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIVendorItemsBoughtEvent : redEvent
	{
		[Ordinal(0)] [RED("itemsID")] public CArray<gameItemID> ItemsID { get; set; }
		[Ordinal(1)] [RED("quantity")] public CArray<CInt32> Quantity { get; set; }

		public UIVendorItemsBoughtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

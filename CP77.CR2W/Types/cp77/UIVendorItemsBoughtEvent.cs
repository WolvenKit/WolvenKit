using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UIVendorItemsBoughtEvent : redEvent
	{
		[Ordinal(0)]  [RED("itemsID")] public CArray<gameItemID> ItemsID { get; set; }
		[Ordinal(1)]  [RED("quantity")] public CArray<CInt32> Quantity { get; set; }

		public UIVendorItemsBoughtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

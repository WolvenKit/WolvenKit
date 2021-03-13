using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("data")] public CHandle<VendorInventoryItemData> Data { get; set; }

		public VendorItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

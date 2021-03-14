using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VirtualShopkeeper : gameObject
	{
		[Ordinal(40)] [RED("vendorID")] public CString VendorID { get; set; }

		public DEBUG_VirtualShopkeeper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

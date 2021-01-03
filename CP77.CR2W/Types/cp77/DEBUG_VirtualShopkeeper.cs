using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VirtualShopkeeper : gameObject
	{
		[Ordinal(0)]  [RED("vendorID")] public CString VendorID { get; set; }

		public DEBUG_VirtualShopkeeper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

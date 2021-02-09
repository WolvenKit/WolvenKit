using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VirtualShopkeeper : gameObject
	{
		[Ordinal(31)]  [RED("vendorID")] public CString VendorID { get; set; }

		public DEBUG_VirtualShopkeeper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

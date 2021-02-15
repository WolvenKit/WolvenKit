using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorUserData : IScriptable
	{
		[Ordinal(0)] [RED("vendorData")] public CHandle<questVendorPanelData> VendorData { get; set; }
		[Ordinal(1)] [RED("menu")] public CString Menu { get; set; }

		public VendorUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

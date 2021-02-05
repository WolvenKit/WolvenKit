using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVendorData : CVariable
	{
		[Ordinal(0)]  [RED("vendorId")] public CString VendorId { get; set; }
		[Ordinal(1)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)]  [RED("isActive")] public CBool IsActive { get; set; }

		public gameVendorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

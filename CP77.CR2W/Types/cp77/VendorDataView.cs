using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorDataView : BackpackDataView
	{
		[Ordinal(4)] [RED("isVendorGrid")] public CBool IsVendorGrid { get; set; }
		[Ordinal(5)] [RED("openTime")] public GameTime OpenTime { get; set; }

		public VendorDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

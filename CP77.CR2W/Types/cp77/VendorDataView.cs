using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendorDataView : BackpackDataView
	{
		[Ordinal(0)]  [RED("isVendorGrid")] public CBool IsVendorGrid { get; set; }
		[Ordinal(1)]  [RED("openTime")] public GameTime OpenTime { get; set; }

		public VendorDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

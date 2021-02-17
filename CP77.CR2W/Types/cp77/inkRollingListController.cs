using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkRollingListController : inkListController
	{
		[Ordinal(6)] [RED("itemsToDisplay")] public CInt32 ItemsToDisplay { get; set; }
		[Ordinal(7)] [RED("convexity")] public CFloat Convexity { get; set; }
		[Ordinal(8)] [RED("verticalCompression")] public CFloat VerticalCompression { get; set; }
		[Ordinal(9)] [RED("scrollTime")] public CFloat ScrollTime { get; set; }

		public inkRollingListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkRollingListController : inkListController
	{
		[Ordinal(0)]  [RED("convexity")] public CFloat Convexity { get; set; }
		[Ordinal(1)]  [RED("itemsToDisplay")] public CInt32 ItemsToDisplay { get; set; }
		[Ordinal(2)]  [RED("scrollTime")] public CFloat ScrollTime { get; set; }
		[Ordinal(3)]  [RED("verticalCompression")] public CFloat VerticalCompression { get; set; }

		public inkRollingListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

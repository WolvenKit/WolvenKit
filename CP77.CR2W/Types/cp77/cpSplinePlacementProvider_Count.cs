using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpSplinePlacementProvider_Count : cpSplinePlacementProvider_Distance
	{
		[Ordinal(1)] [RED("count")] public CUInt32 Count { get; set; }

		public cpSplinePlacementProvider_Count(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpSplinePlacementProvider_Distance : cpSplinePlacementProvider
	{
		[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }

		public cpSplinePlacementProvider_Distance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

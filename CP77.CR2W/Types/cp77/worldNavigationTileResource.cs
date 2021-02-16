using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileResource : resStreamedResource
	{
		[Ordinal(1)] [RED("localBoundingBox")] public Box LocalBoundingBox { get; set; }
		[Ordinal(2)] [RED("tilesData")] public CArray<worldNavigationTileData> TilesData { get; set; }

		public worldNavigationTileResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSectorCacheArtifact : CResource
	{
		[Ordinal(1)] [RED("sectorBounds")] public Box SectorBounds { get; set; }
		[Ordinal(2)] [RED("sectorGeometries")] public CArray<physicsGeometryKey> SectorGeometries { get; set; }

		public physicsSectorCacheArtifact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CTerrainSetup : CResource
	{
		[Ordinal(1)] [RED("tiling")] public CArray<CFloat> Tiling { get; set; }
		[Ordinal(2)] [RED("physicalMaterial")] public CArray<CName> PhysicalMaterial { get; set; }

		public CTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

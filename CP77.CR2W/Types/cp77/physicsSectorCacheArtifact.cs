using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsSectorCacheArtifact : CResource
	{
		[Ordinal(0)]  [RED("sectorBounds")] public Box SectorBounds { get; set; }
		[Ordinal(1)]  [RED("sectorGeometries")] public CArray<physicsGeometryKey> SectorGeometries { get; set; }

		public physicsSectorCacheArtifact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

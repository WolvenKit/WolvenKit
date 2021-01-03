using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryCache : CResource
	{
		[Ordinal(0)]  [RED("alwaysLoadedSector")] public physicsSectorEntry AlwaysLoadedSector { get; set; }
		[Ordinal(1)]  [RED("alwaysLoadedSectorDDB")] public serializationDeferredDataBuffer AlwaysLoadedSectorDDB { get; set; }
		[Ordinal(2)]  [RED("bufferTableSectors")] public CArray<serializationDeferredDataBuffer> BufferTableSectors { get; set; }
		[Ordinal(3)]  [RED("sectorCacheEntries")] public CArray<physicsSectorCacheEntry> SectorCacheEntries { get; set; }
		[Ordinal(4)]  [RED("sectorEntries")] public CArray<physicsSectorEntry> SectorEntries { get; set; }
		[Ordinal(5)]  [RED("sectorGeometries")] public CArray<physicsGeometryKey> SectorGeometries { get; set; }

		public physicsGeometryCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

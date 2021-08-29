using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsGeometryCache : CResource
	{
		private CArray<SerializationDeferredDataBuffer> _bufferTableSectors;
		private CArray<physicsSectorEntry> _sectorEntries;
		private CArray<physicsGeometryKey> _sectorGeometries;
		private CArray<physicsSectorCacheEntry> _sectorCacheEntries;
		private physicsSectorEntry _alwaysLoadedSector;
		private SerializationDeferredDataBuffer _alwaysLoadedSectorDDB;

		[Ordinal(1)] 
		[RED("bufferTableSectors")] 
		public CArray<SerializationDeferredDataBuffer> BufferTableSectors
		{
			get => GetProperty(ref _bufferTableSectors);
			set => SetProperty(ref _bufferTableSectors, value);
		}

		[Ordinal(2)] 
		[RED("sectorEntries")] 
		public CArray<physicsSectorEntry> SectorEntries
		{
			get => GetProperty(ref _sectorEntries);
			set => SetProperty(ref _sectorEntries, value);
		}

		[Ordinal(3)] 
		[RED("sectorGeometries")] 
		public CArray<physicsGeometryKey> SectorGeometries
		{
			get => GetProperty(ref _sectorGeometries);
			set => SetProperty(ref _sectorGeometries, value);
		}

		[Ordinal(4)] 
		[RED("sectorCacheEntries")] 
		public CArray<physicsSectorCacheEntry> SectorCacheEntries
		{
			get => GetProperty(ref _sectorCacheEntries);
			set => SetProperty(ref _sectorCacheEntries, value);
		}

		[Ordinal(5)] 
		[RED("alwaysLoadedSector")] 
		public physicsSectorEntry AlwaysLoadedSector
		{
			get => GetProperty(ref _alwaysLoadedSector);
			set => SetProperty(ref _alwaysLoadedSector, value);
		}

		[Ordinal(6)] 
		[RED("alwaysLoadedSectorDDB")] 
		public SerializationDeferredDataBuffer AlwaysLoadedSectorDDB
		{
			get => GetProperty(ref _alwaysLoadedSectorDDB);
			set => SetProperty(ref _alwaysLoadedSectorDDB, value);
		}
	}
}

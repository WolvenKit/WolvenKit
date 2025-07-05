using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsGeometryCache : CResource
	{
		[Ordinal(1)] 
		[RED("bufferTableSectors")] 
		public CArray<SerializationDeferredDataBuffer> BufferTableSectors
		{
			get => GetPropertyValue<CArray<SerializationDeferredDataBuffer>>();
			set => SetPropertyValue<CArray<SerializationDeferredDataBuffer>>(value);
		}

		[Ordinal(2)] 
		[RED("sectorEntries")] 
		public CArray<physicsSectorEntry> SectorEntries
		{
			get => GetPropertyValue<CArray<physicsSectorEntry>>();
			set => SetPropertyValue<CArray<physicsSectorEntry>>(value);
		}

		[Ordinal(3)] 
		[RED("sectorGeometries")] 
		public CArray<physicsGeometryKey> SectorGeometries
		{
			get => GetPropertyValue<CArray<physicsGeometryKey>>();
			set => SetPropertyValue<CArray<physicsGeometryKey>>(value);
		}

		[Ordinal(4)] 
		[RED("sectorCacheEntries")] 
		public CArray<physicsSectorCacheEntry> SectorCacheEntries
		{
			get => GetPropertyValue<CArray<physicsSectorCacheEntry>>();
			set => SetPropertyValue<CArray<physicsSectorCacheEntry>>(value);
		}

		[Ordinal(5)] 
		[RED("alwaysLoadedSector")] 
		public physicsSectorEntry AlwaysLoadedSector
		{
			get => GetPropertyValue<physicsSectorEntry>();
			set => SetPropertyValue<physicsSectorEntry>(value);
		}

		[Ordinal(6)] 
		[RED("alwaysLoadedSectorDDB")] 
		public SerializationDeferredDataBuffer AlwaysLoadedSectorDDB
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		public physicsGeometryCache()
		{
			BufferTableSectors = new();
			SectorEntries = new();
			SectorGeometries = new();
			SectorCacheEntries = new();
			AlwaysLoadedSector = new physicsSectorEntry { SectorBounds = new Box { Min = new Vector4(), Max = new Vector4() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

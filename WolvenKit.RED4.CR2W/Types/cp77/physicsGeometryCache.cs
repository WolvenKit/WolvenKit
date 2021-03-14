using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryCache : CResource
	{
		private CArray<serializationDeferredDataBuffer> _bufferTableSectors;
		private CArray<physicsSectorEntry> _sectorEntries;
		private CArray<physicsGeometryKey> _sectorGeometries;
		private CArray<physicsSectorCacheEntry> _sectorCacheEntries;
		private physicsSectorEntry _alwaysLoadedSector;
		private serializationDeferredDataBuffer _alwaysLoadedSectorDDB;

		[Ordinal(1)] 
		[RED("bufferTableSectors")] 
		public CArray<serializationDeferredDataBuffer> BufferTableSectors
		{
			get
			{
				if (_bufferTableSectors == null)
				{
					_bufferTableSectors = (CArray<serializationDeferredDataBuffer>) CR2WTypeManager.Create("array:serializationDeferredDataBuffer", "bufferTableSectors", cr2w, this);
				}
				return _bufferTableSectors;
			}
			set
			{
				if (_bufferTableSectors == value)
				{
					return;
				}
				_bufferTableSectors = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sectorEntries")] 
		public CArray<physicsSectorEntry> SectorEntries
		{
			get
			{
				if (_sectorEntries == null)
				{
					_sectorEntries = (CArray<physicsSectorEntry>) CR2WTypeManager.Create("array:physicsSectorEntry", "sectorEntries", cr2w, this);
				}
				return _sectorEntries;
			}
			set
			{
				if (_sectorEntries == value)
				{
					return;
				}
				_sectorEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sectorGeometries")] 
		public CArray<physicsGeometryKey> SectorGeometries
		{
			get
			{
				if (_sectorGeometries == null)
				{
					_sectorGeometries = (CArray<physicsGeometryKey>) CR2WTypeManager.Create("array:physicsGeometryKey", "sectorGeometries", cr2w, this);
				}
				return _sectorGeometries;
			}
			set
			{
				if (_sectorGeometries == value)
				{
					return;
				}
				_sectorGeometries = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sectorCacheEntries")] 
		public CArray<physicsSectorCacheEntry> SectorCacheEntries
		{
			get
			{
				if (_sectorCacheEntries == null)
				{
					_sectorCacheEntries = (CArray<physicsSectorCacheEntry>) CR2WTypeManager.Create("array:physicsSectorCacheEntry", "sectorCacheEntries", cr2w, this);
				}
				return _sectorCacheEntries;
			}
			set
			{
				if (_sectorCacheEntries == value)
				{
					return;
				}
				_sectorCacheEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("alwaysLoadedSector")] 
		public physicsSectorEntry AlwaysLoadedSector
		{
			get
			{
				if (_alwaysLoadedSector == null)
				{
					_alwaysLoadedSector = (physicsSectorEntry) CR2WTypeManager.Create("physicsSectorEntry", "alwaysLoadedSector", cr2w, this);
				}
				return _alwaysLoadedSector;
			}
			set
			{
				if (_alwaysLoadedSector == value)
				{
					return;
				}
				_alwaysLoadedSector = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("alwaysLoadedSectorDDB")] 
		public serializationDeferredDataBuffer AlwaysLoadedSectorDDB
		{
			get
			{
				if (_alwaysLoadedSectorDDB == null)
				{
					_alwaysLoadedSectorDDB = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "alwaysLoadedSectorDDB", cr2w, this);
				}
				return _alwaysLoadedSectorDDB;
			}
			set
			{
				if (_alwaysLoadedSectorDDB == value)
				{
					return;
				}
				_alwaysLoadedSectorDDB = value;
				PropertySet(this);
			}
		}

		public physicsGeometryCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

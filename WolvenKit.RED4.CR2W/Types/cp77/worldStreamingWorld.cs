using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingWorld : CResource
	{
		private CUInt32 _version;
		private CArray<worldStreamingSectorDescriptor> _exteriorSectors;
		private CArray<worldStreamingSectorDescriptor> _interiorSectors;
		private CArray<worldStreamingSectorDescriptor> _questSectors;
		private CArray<worldStreamingSectorDescriptor> _alwaysLoadedSectors;
		private rRef<worldEnvironmentDefinition> _environmentDefinition;
		private Box _worldBoundingBox;
		private rRef<CResource> _persistentStateData;
		private rRef<CResource> _deviceResource;
		private rRef<CResource> _deviceInitResource;
		private rRef<CResource> _mappinResource;
		private rRef<CResource> _poiMappinResource;
		private rRef<CResource> _areaResource;
		private rRef<CResource> _lootResource;
		private rRef<CResource> _locationResource;
		private raRef<CResource> _locomotionPathResource;
		private raRef<worldAutoFoliageMapping> _autoFoliageMapping;
		private raRef<CResource> _trafficPersistentResource;
		private raRef<CResource> _trafficLaneConnectivityResource;
		private raRef<CResource> _trafficLanePolygonsResource;
		private raRef<CResource> _trafficLaneSpotsResource;
		private raRef<CResource> _trafficSpatialRepresentationResource;
		private raRef<CResource> _trafficCollisionResource;
		private raRef<CResource> _trafficNullAreaCollisionResource;
		private raRef<CResource> _smartObjectCompiledRootResource;
		private rRef<CResource> _geometryCacheResource;
		private CBool _wasBuiltForSceneRecording;
		private raRef<worldStreamingQueryDataResource> _streamingQueryDataResource;

		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exteriorSectors")] 
		public CArray<worldStreamingSectorDescriptor> ExteriorSectors
		{
			get
			{
				if (_exteriorSectors == null)
				{
					_exteriorSectors = (CArray<worldStreamingSectorDescriptor>) CR2WTypeManager.Create("array:worldStreamingSectorDescriptor", "exteriorSectors", cr2w, this);
				}
				return _exteriorSectors;
			}
			set
			{
				if (_exteriorSectors == value)
				{
					return;
				}
				_exteriorSectors = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("interiorSectors")] 
		public CArray<worldStreamingSectorDescriptor> InteriorSectors
		{
			get
			{
				if (_interiorSectors == null)
				{
					_interiorSectors = (CArray<worldStreamingSectorDescriptor>) CR2WTypeManager.Create("array:worldStreamingSectorDescriptor", "interiorSectors", cr2w, this);
				}
				return _interiorSectors;
			}
			set
			{
				if (_interiorSectors == value)
				{
					return;
				}
				_interiorSectors = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("questSectors")] 
		public CArray<worldStreamingSectorDescriptor> QuestSectors
		{
			get
			{
				if (_questSectors == null)
				{
					_questSectors = (CArray<worldStreamingSectorDescriptor>) CR2WTypeManager.Create("array:worldStreamingSectorDescriptor", "questSectors", cr2w, this);
				}
				return _questSectors;
			}
			set
			{
				if (_questSectors == value)
				{
					return;
				}
				_questSectors = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("alwaysLoadedSectors")] 
		public CArray<worldStreamingSectorDescriptor> AlwaysLoadedSectors
		{
			get
			{
				if (_alwaysLoadedSectors == null)
				{
					_alwaysLoadedSectors = (CArray<worldStreamingSectorDescriptor>) CR2WTypeManager.Create("array:worldStreamingSectorDescriptor", "alwaysLoadedSectors", cr2w, this);
				}
				return _alwaysLoadedSectors;
			}
			set
			{
				if (_alwaysLoadedSectors == value)
				{
					return;
				}
				_alwaysLoadedSectors = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("environmentDefinition")] 
		public rRef<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get
			{
				if (_environmentDefinition == null)
				{
					_environmentDefinition = (rRef<worldEnvironmentDefinition>) CR2WTypeManager.Create("rRef:worldEnvironmentDefinition", "environmentDefinition", cr2w, this);
				}
				return _environmentDefinition;
			}
			set
			{
				if (_environmentDefinition == value)
				{
					return;
				}
				_environmentDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("worldBoundingBox")] 
		public Box WorldBoundingBox
		{
			get
			{
				if (_worldBoundingBox == null)
				{
					_worldBoundingBox = (Box) CR2WTypeManager.Create("Box", "worldBoundingBox", cr2w, this);
				}
				return _worldBoundingBox;
			}
			set
			{
				if (_worldBoundingBox == value)
				{
					return;
				}
				_worldBoundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("persistentStateData")] 
		public rRef<CResource> PersistentStateData
		{
			get
			{
				if (_persistentStateData == null)
				{
					_persistentStateData = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "persistentStateData", cr2w, this);
				}
				return _persistentStateData;
			}
			set
			{
				if (_persistentStateData == value)
				{
					return;
				}
				_persistentStateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("deviceResource")] 
		public rRef<CResource> DeviceResource
		{
			get
			{
				if (_deviceResource == null)
				{
					_deviceResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "deviceResource", cr2w, this);
				}
				return _deviceResource;
			}
			set
			{
				if (_deviceResource == value)
				{
					return;
				}
				_deviceResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("deviceInitResource")] 
		public rRef<CResource> DeviceInitResource
		{
			get
			{
				if (_deviceInitResource == null)
				{
					_deviceInitResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "deviceInitResource", cr2w, this);
				}
				return _deviceInitResource;
			}
			set
			{
				if (_deviceInitResource == value)
				{
					return;
				}
				_deviceInitResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("mappinResource")] 
		public rRef<CResource> MappinResource
		{
			get
			{
				if (_mappinResource == null)
				{
					_mappinResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "mappinResource", cr2w, this);
				}
				return _mappinResource;
			}
			set
			{
				if (_mappinResource == value)
				{
					return;
				}
				_mappinResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("poiMappinResource")] 
		public rRef<CResource> PoiMappinResource
		{
			get
			{
				if (_poiMappinResource == null)
				{
					_poiMappinResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "poiMappinResource", cr2w, this);
				}
				return _poiMappinResource;
			}
			set
			{
				if (_poiMappinResource == value)
				{
					return;
				}
				_poiMappinResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("areaResource")] 
		public rRef<CResource> AreaResource
		{
			get
			{
				if (_areaResource == null)
				{
					_areaResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "areaResource", cr2w, this);
				}
				return _areaResource;
			}
			set
			{
				if (_areaResource == value)
				{
					return;
				}
				_areaResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lootResource")] 
		public rRef<CResource> LootResource
		{
			get
			{
				if (_lootResource == null)
				{
					_lootResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "lootResource", cr2w, this);
				}
				return _lootResource;
			}
			set
			{
				if (_lootResource == value)
				{
					return;
				}
				_lootResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("locationResource")] 
		public rRef<CResource> LocationResource
		{
			get
			{
				if (_locationResource == null)
				{
					_locationResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "locationResource", cr2w, this);
				}
				return _locationResource;
			}
			set
			{
				if (_locationResource == value)
				{
					return;
				}
				_locationResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("locomotionPathResource")] 
		public raRef<CResource> LocomotionPathResource
		{
			get
			{
				if (_locomotionPathResource == null)
				{
					_locomotionPathResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "locomotionPathResource", cr2w, this);
				}
				return _locomotionPathResource;
			}
			set
			{
				if (_locomotionPathResource == value)
				{
					return;
				}
				_locomotionPathResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("autoFoliageMapping")] 
		public raRef<worldAutoFoliageMapping> AutoFoliageMapping
		{
			get
			{
				if (_autoFoliageMapping == null)
				{
					_autoFoliageMapping = (raRef<worldAutoFoliageMapping>) CR2WTypeManager.Create("raRef:worldAutoFoliageMapping", "autoFoliageMapping", cr2w, this);
				}
				return _autoFoliageMapping;
			}
			set
			{
				if (_autoFoliageMapping == value)
				{
					return;
				}
				_autoFoliageMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("trafficPersistentResource")] 
		public raRef<CResource> TrafficPersistentResource
		{
			get
			{
				if (_trafficPersistentResource == null)
				{
					_trafficPersistentResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficPersistentResource", cr2w, this);
				}
				return _trafficPersistentResource;
			}
			set
			{
				if (_trafficPersistentResource == value)
				{
					return;
				}
				_trafficPersistentResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("trafficLaneConnectivityResource")] 
		public raRef<CResource> TrafficLaneConnectivityResource
		{
			get
			{
				if (_trafficLaneConnectivityResource == null)
				{
					_trafficLaneConnectivityResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficLaneConnectivityResource", cr2w, this);
				}
				return _trafficLaneConnectivityResource;
			}
			set
			{
				if (_trafficLaneConnectivityResource == value)
				{
					return;
				}
				_trafficLaneConnectivityResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("trafficLanePolygonsResource")] 
		public raRef<CResource> TrafficLanePolygonsResource
		{
			get
			{
				if (_trafficLanePolygonsResource == null)
				{
					_trafficLanePolygonsResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficLanePolygonsResource", cr2w, this);
				}
				return _trafficLanePolygonsResource;
			}
			set
			{
				if (_trafficLanePolygonsResource == value)
				{
					return;
				}
				_trafficLanePolygonsResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("trafficLaneSpotsResource")] 
		public raRef<CResource> TrafficLaneSpotsResource
		{
			get
			{
				if (_trafficLaneSpotsResource == null)
				{
					_trafficLaneSpotsResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficLaneSpotsResource", cr2w, this);
				}
				return _trafficLaneSpotsResource;
			}
			set
			{
				if (_trafficLaneSpotsResource == value)
				{
					return;
				}
				_trafficLaneSpotsResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("trafficSpatialRepresentationResource")] 
		public raRef<CResource> TrafficSpatialRepresentationResource
		{
			get
			{
				if (_trafficSpatialRepresentationResource == null)
				{
					_trafficSpatialRepresentationResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficSpatialRepresentationResource", cr2w, this);
				}
				return _trafficSpatialRepresentationResource;
			}
			set
			{
				if (_trafficSpatialRepresentationResource == value)
				{
					return;
				}
				_trafficSpatialRepresentationResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("trafficCollisionResource")] 
		public raRef<CResource> TrafficCollisionResource
		{
			get
			{
				if (_trafficCollisionResource == null)
				{
					_trafficCollisionResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficCollisionResource", cr2w, this);
				}
				return _trafficCollisionResource;
			}
			set
			{
				if (_trafficCollisionResource == value)
				{
					return;
				}
				_trafficCollisionResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("trafficNullAreaCollisionResource")] 
		public raRef<CResource> TrafficNullAreaCollisionResource
		{
			get
			{
				if (_trafficNullAreaCollisionResource == null)
				{
					_trafficNullAreaCollisionResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "trafficNullAreaCollisionResource", cr2w, this);
				}
				return _trafficNullAreaCollisionResource;
			}
			set
			{
				if (_trafficNullAreaCollisionResource == value)
				{
					return;
				}
				_trafficNullAreaCollisionResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("smartObjectCompiledRootResource")] 
		public raRef<CResource> SmartObjectCompiledRootResource
		{
			get
			{
				if (_smartObjectCompiledRootResource == null)
				{
					_smartObjectCompiledRootResource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "smartObjectCompiledRootResource", cr2w, this);
				}
				return _smartObjectCompiledRootResource;
			}
			set
			{
				if (_smartObjectCompiledRootResource == value)
				{
					return;
				}
				_smartObjectCompiledRootResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("geometryCacheResource")] 
		public rRef<CResource> GeometryCacheResource
		{
			get
			{
				if (_geometryCacheResource == null)
				{
					_geometryCacheResource = (rRef<CResource>) CR2WTypeManager.Create("rRef:CResource", "geometryCacheResource", cr2w, this);
				}
				return _geometryCacheResource;
			}
			set
			{
				if (_geometryCacheResource == value)
				{
					return;
				}
				_geometryCacheResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("wasBuiltForSceneRecording")] 
		public CBool WasBuiltForSceneRecording
		{
			get
			{
				if (_wasBuiltForSceneRecording == null)
				{
					_wasBuiltForSceneRecording = (CBool) CR2WTypeManager.Create("Bool", "wasBuiltForSceneRecording", cr2w, this);
				}
				return _wasBuiltForSceneRecording;
			}
			set
			{
				if (_wasBuiltForSceneRecording == value)
				{
					return;
				}
				_wasBuiltForSceneRecording = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("streamingQueryDataResource")] 
		public raRef<worldStreamingQueryDataResource> StreamingQueryDataResource
		{
			get
			{
				if (_streamingQueryDataResource == null)
				{
					_streamingQueryDataResource = (raRef<worldStreamingQueryDataResource>) CR2WTypeManager.Create("raRef:worldStreamingQueryDataResource", "streamingQueryDataResource", cr2w, this);
				}
				return _streamingQueryDataResource;
			}
			set
			{
				if (_streamingQueryDataResource == value)
				{
					return;
				}
				_streamingQueryDataResource = value;
				PropertySet(this);
			}
		}

		public worldStreamingWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

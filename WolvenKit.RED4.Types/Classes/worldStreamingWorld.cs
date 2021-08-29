using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStreamingWorld : CResource
	{
		private CUInt32 _version;
		private CArray<worldStreamingSectorDescriptor> _exteriorSectors;
		private CArray<worldStreamingSectorDescriptor> _interiorSectors;
		private CArray<worldStreamingSectorDescriptor> _questSectors;
		private CArray<worldStreamingSectorDescriptor> _alwaysLoadedSectors;
		private CArray<worldStreamingSectorDescriptor> _navigationSectors;
		private CResourceReference<worldEnvironmentDefinition> _environmentDefinition;
		private Box _worldBoundingBox;
		private CResourceReference<CResource> _persistentStateData;
		private CResourceReference<CResource> _deviceResource;
		private CResourceReference<CResource> _deviceInitResource;
		private CResourceReference<CResource> _mappinResource;
		private CResourceReference<CResource> _poiMappinResource;
		private CResourceReference<CResource> _areaResource;
		private CResourceReference<CResource> _lootResource;
		private CResourceReference<CResource> _locationResource;
		private CResourceAsyncReference<CResource> _locomotionPathResource;
		private CResourceAsyncReference<worldAutoFoliageMapping> _autoFoliageMapping;
		private CResourceAsyncReference<CResource> _trafficPersistentResource;
		private CResourceAsyncReference<CResource> _trafficLaneConnectivityResource;
		private CResourceAsyncReference<CResource> _trafficLanePolygonsResource;
		private CResourceAsyncReference<CResource> _trafficLaneSpotsResource;
		private CResourceAsyncReference<CResource> _trafficSpatialRepresentationResource;
		private CResourceAsyncReference<CResource> _trafficCollisionResource;
		private CResourceAsyncReference<CResource> _trafficNullAreaCollisionResource;
		private CResourceAsyncReference<CResource> _smartObjectCompiledRootResource;
		private CResourceReference<CResource> _geometryCacheResource;
		private CBool _wasBuiltForSceneRecording;
		private CResourceAsyncReference<worldStreamingQueryDataResource> _streamingQueryDataResource;

		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(2)] 
		[RED("exteriorSectors")] 
		public CArray<worldStreamingSectorDescriptor> ExteriorSectors
		{
			get => GetProperty(ref _exteriorSectors);
			set => SetProperty(ref _exteriorSectors, value);
		}

		[Ordinal(3)] 
		[RED("interiorSectors")] 
		public CArray<worldStreamingSectorDescriptor> InteriorSectors
		{
			get => GetProperty(ref _interiorSectors);
			set => SetProperty(ref _interiorSectors, value);
		}

		[Ordinal(4)] 
		[RED("questSectors")] 
		public CArray<worldStreamingSectorDescriptor> QuestSectors
		{
			get => GetProperty(ref _questSectors);
			set => SetProperty(ref _questSectors, value);
		}

		[Ordinal(5)] 
		[RED("alwaysLoadedSectors")] 
		public CArray<worldStreamingSectorDescriptor> AlwaysLoadedSectors
		{
			get => GetProperty(ref _alwaysLoadedSectors);
			set => SetProperty(ref _alwaysLoadedSectors, value);
		}

		[Ordinal(6)] 
		[RED("navigationSectors")] 
		public CArray<worldStreamingSectorDescriptor> NavigationSectors
		{
			get => GetProperty(ref _navigationSectors);
			set => SetProperty(ref _navigationSectors, value);
		}

		[Ordinal(7)] 
		[RED("environmentDefinition")] 
		public CResourceReference<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get => GetProperty(ref _environmentDefinition);
			set => SetProperty(ref _environmentDefinition, value);
		}

		[Ordinal(8)] 
		[RED("worldBoundingBox")] 
		public Box WorldBoundingBox
		{
			get => GetProperty(ref _worldBoundingBox);
			set => SetProperty(ref _worldBoundingBox, value);
		}

		[Ordinal(9)] 
		[RED("persistentStateData")] 
		public CResourceReference<CResource> PersistentStateData
		{
			get => GetProperty(ref _persistentStateData);
			set => SetProperty(ref _persistentStateData, value);
		}

		[Ordinal(10)] 
		[RED("deviceResource")] 
		public CResourceReference<CResource> DeviceResource
		{
			get => GetProperty(ref _deviceResource);
			set => SetProperty(ref _deviceResource, value);
		}

		[Ordinal(11)] 
		[RED("deviceInitResource")] 
		public CResourceReference<CResource> DeviceInitResource
		{
			get => GetProperty(ref _deviceInitResource);
			set => SetProperty(ref _deviceInitResource, value);
		}

		[Ordinal(12)] 
		[RED("mappinResource")] 
		public CResourceReference<CResource> MappinResource
		{
			get => GetProperty(ref _mappinResource);
			set => SetProperty(ref _mappinResource, value);
		}

		[Ordinal(13)] 
		[RED("poiMappinResource")] 
		public CResourceReference<CResource> PoiMappinResource
		{
			get => GetProperty(ref _poiMappinResource);
			set => SetProperty(ref _poiMappinResource, value);
		}

		[Ordinal(14)] 
		[RED("areaResource")] 
		public CResourceReference<CResource> AreaResource
		{
			get => GetProperty(ref _areaResource);
			set => SetProperty(ref _areaResource, value);
		}

		[Ordinal(15)] 
		[RED("lootResource")] 
		public CResourceReference<CResource> LootResource
		{
			get => GetProperty(ref _lootResource);
			set => SetProperty(ref _lootResource, value);
		}

		[Ordinal(16)] 
		[RED("locationResource")] 
		public CResourceReference<CResource> LocationResource
		{
			get => GetProperty(ref _locationResource);
			set => SetProperty(ref _locationResource, value);
		}

		[Ordinal(17)] 
		[RED("locomotionPathResource")] 
		public CResourceAsyncReference<CResource> LocomotionPathResource
		{
			get => GetProperty(ref _locomotionPathResource);
			set => SetProperty(ref _locomotionPathResource, value);
		}

		[Ordinal(18)] 
		[RED("autoFoliageMapping")] 
		public CResourceAsyncReference<worldAutoFoliageMapping> AutoFoliageMapping
		{
			get => GetProperty(ref _autoFoliageMapping);
			set => SetProperty(ref _autoFoliageMapping, value);
		}

		[Ordinal(19)] 
		[RED("trafficPersistentResource")] 
		public CResourceAsyncReference<CResource> TrafficPersistentResource
		{
			get => GetProperty(ref _trafficPersistentResource);
			set => SetProperty(ref _trafficPersistentResource, value);
		}

		[Ordinal(20)] 
		[RED("trafficLaneConnectivityResource")] 
		public CResourceAsyncReference<CResource> TrafficLaneConnectivityResource
		{
			get => GetProperty(ref _trafficLaneConnectivityResource);
			set => SetProperty(ref _trafficLaneConnectivityResource, value);
		}

		[Ordinal(21)] 
		[RED("trafficLanePolygonsResource")] 
		public CResourceAsyncReference<CResource> TrafficLanePolygonsResource
		{
			get => GetProperty(ref _trafficLanePolygonsResource);
			set => SetProperty(ref _trafficLanePolygonsResource, value);
		}

		[Ordinal(22)] 
		[RED("trafficLaneSpotsResource")] 
		public CResourceAsyncReference<CResource> TrafficLaneSpotsResource
		{
			get => GetProperty(ref _trafficLaneSpotsResource);
			set => SetProperty(ref _trafficLaneSpotsResource, value);
		}

		[Ordinal(23)] 
		[RED("trafficSpatialRepresentationResource")] 
		public CResourceAsyncReference<CResource> TrafficSpatialRepresentationResource
		{
			get => GetProperty(ref _trafficSpatialRepresentationResource);
			set => SetProperty(ref _trafficSpatialRepresentationResource, value);
		}

		[Ordinal(24)] 
		[RED("trafficCollisionResource")] 
		public CResourceAsyncReference<CResource> TrafficCollisionResource
		{
			get => GetProperty(ref _trafficCollisionResource);
			set => SetProperty(ref _trafficCollisionResource, value);
		}

		[Ordinal(25)] 
		[RED("trafficNullAreaCollisionResource")] 
		public CResourceAsyncReference<CResource> TrafficNullAreaCollisionResource
		{
			get => GetProperty(ref _trafficNullAreaCollisionResource);
			set => SetProperty(ref _trafficNullAreaCollisionResource, value);
		}

		[Ordinal(26)] 
		[RED("smartObjectCompiledRootResource")] 
		public CResourceAsyncReference<CResource> SmartObjectCompiledRootResource
		{
			get => GetProperty(ref _smartObjectCompiledRootResource);
			set => SetProperty(ref _smartObjectCompiledRootResource, value);
		}

		[Ordinal(27)] 
		[RED("geometryCacheResource")] 
		public CResourceReference<CResource> GeometryCacheResource
		{
			get => GetProperty(ref _geometryCacheResource);
			set => SetProperty(ref _geometryCacheResource, value);
		}

		[Ordinal(28)] 
		[RED("wasBuiltForSceneRecording")] 
		public CBool WasBuiltForSceneRecording
		{
			get => GetProperty(ref _wasBuiltForSceneRecording);
			set => SetProperty(ref _wasBuiltForSceneRecording, value);
		}

		[Ordinal(29)] 
		[RED("streamingQueryDataResource")] 
		public CResourceAsyncReference<worldStreamingQueryDataResource> StreamingQueryDataResource
		{
			get => GetProperty(ref _streamingQueryDataResource);
			set => SetProperty(ref _streamingQueryDataResource, value);
		}
	}
}

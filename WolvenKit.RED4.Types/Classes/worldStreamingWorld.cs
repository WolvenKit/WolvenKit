using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStreamingWorld : CResource
	{
		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("exteriorSectors")] 
		public CArray<worldStreamingSectorDescriptor> ExteriorSectors
		{
			get => GetPropertyValue<CArray<worldStreamingSectorDescriptor>>();
			set => SetPropertyValue<CArray<worldStreamingSectorDescriptor>>(value);
		}

		[Ordinal(3)] 
		[RED("interiorSectors")] 
		public CArray<worldStreamingSectorDescriptor> InteriorSectors
		{
			get => GetPropertyValue<CArray<worldStreamingSectorDescriptor>>();
			set => SetPropertyValue<CArray<worldStreamingSectorDescriptor>>(value);
		}

		[Ordinal(4)] 
		[RED("questSectors")] 
		public CArray<worldStreamingSectorDescriptor> QuestSectors
		{
			get => GetPropertyValue<CArray<worldStreamingSectorDescriptor>>();
			set => SetPropertyValue<CArray<worldStreamingSectorDescriptor>>(value);
		}

		[Ordinal(5)] 
		[RED("alwaysLoadedSectors")] 
		public CArray<worldStreamingSectorDescriptor> AlwaysLoadedSectors
		{
			get => GetPropertyValue<CArray<worldStreamingSectorDescriptor>>();
			set => SetPropertyValue<CArray<worldStreamingSectorDescriptor>>(value);
		}

		[Ordinal(6)] 
		[RED("navigationSectors")] 
		public CArray<worldStreamingSectorDescriptor> NavigationSectors
		{
			get => GetPropertyValue<CArray<worldStreamingSectorDescriptor>>();
			set => SetPropertyValue<CArray<worldStreamingSectorDescriptor>>(value);
		}

		[Ordinal(7)] 
		[RED("environmentDefinition")] 
		public CResourceReference<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentDefinition>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentDefinition>>(value);
		}

		[Ordinal(8)] 
		[RED("worldBoundingBox")] 
		public Box WorldBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(9)] 
		[RED("persistentStateData")] 
		public CResourceReference<CResource> PersistentStateData
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(10)] 
		[RED("deviceResource")] 
		public CResourceReference<CResource> DeviceResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(11)] 
		[RED("deviceInitResource")] 
		public CResourceReference<CResource> DeviceInitResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(12)] 
		[RED("mappinResource")] 
		public CResourceReference<CResource> MappinResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(13)] 
		[RED("poiMappinResource")] 
		public CResourceReference<CResource> PoiMappinResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(14)] 
		[RED("areaResource")] 
		public CResourceReference<CResource> AreaResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(15)] 
		[RED("lootResource")] 
		public CResourceReference<CResource> LootResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(16)] 
		[RED("locationResource")] 
		public CResourceReference<CResource> LocationResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(17)] 
		[RED("locomotionPathResource")] 
		public CResourceAsyncReference<CResource> LocomotionPathResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(18)] 
		[RED("autoFoliageMapping")] 
		public CResourceAsyncReference<worldAutoFoliageMapping> AutoFoliageMapping
		{
			get => GetPropertyValue<CResourceAsyncReference<worldAutoFoliageMapping>>();
			set => SetPropertyValue<CResourceAsyncReference<worldAutoFoliageMapping>>(value);
		}

		[Ordinal(19)] 
		[RED("trafficPersistentResource")] 
		public CResourceAsyncReference<CResource> TrafficPersistentResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(20)] 
		[RED("trafficLaneConnectivityResource")] 
		public CResourceAsyncReference<CResource> TrafficLaneConnectivityResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(21)] 
		[RED("trafficLanePolygonsResource")] 
		public CResourceAsyncReference<CResource> TrafficLanePolygonsResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(22)] 
		[RED("trafficLaneSpotsResource")] 
		public CResourceAsyncReference<CResource> TrafficLaneSpotsResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(23)] 
		[RED("trafficSpatialRepresentationResource")] 
		public CResourceAsyncReference<CResource> TrafficSpatialRepresentationResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(24)] 
		[RED("trafficCollisionResource")] 
		public CResourceAsyncReference<CResource> TrafficCollisionResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(25)] 
		[RED("trafficNullAreaCollisionResource")] 
		public CResourceAsyncReference<CResource> TrafficNullAreaCollisionResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(26)] 
		[RED("smartObjectCompiledRootResource")] 
		public CResourceAsyncReference<CResource> SmartObjectCompiledRootResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(27)] 
		[RED("geometryCacheResource")] 
		public CResourceReference<CResource> GeometryCacheResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(28)] 
		[RED("wasBuiltForSceneRecording")] 
		public CBool WasBuiltForSceneRecording
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("streamingQueryDataResource")] 
		public CResourceAsyncReference<worldStreamingQueryDataResource> StreamingQueryDataResource
		{
			get => GetPropertyValue<CResourceAsyncReference<worldStreamingQueryDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<worldStreamingQueryDataResource>>(value);
		}

		public worldStreamingWorld()
		{
			ExteriorSectors = new();
			InteriorSectors = new();
			QuestSectors = new();
			AlwaysLoadedSectors = new();
			NavigationSectors = new();
			WorldBoundingBox = new() { Min = new(), Max = new() };
		}
	}
}

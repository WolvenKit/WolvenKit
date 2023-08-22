using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("blockRefs")] 
		public CArray<CResourceReference<worldStreamingBlock>> BlockRefs
		{
			get => GetPropertyValue<CArray<CResourceReference<worldStreamingBlock>>>();
			set => SetPropertyValue<CArray<CResourceReference<worldStreamingBlock>>>(value);
		}

		[Ordinal(3)] 
		[RED("environmentDefinition")] 
		public CResourceReference<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentDefinition>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("worldBoundingBox")] 
		public Box WorldBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(5)] 
		[RED("persistentStateData")] 
		public CResourceReference<CResource> PersistentStateData
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(6)] 
		[RED("deviceResource")] 
		public CResourceReference<CResource> DeviceResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(7)] 
		[RED("deviceInitResource")] 
		public CResourceReference<CResource> DeviceInitResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(8)] 
		[RED("mappinResource")] 
		public CResourceReference<CResource> MappinResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(9)] 
		[RED("poiMappinResource")] 
		public CResourceReference<CResource> PoiMappinResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(10)] 
		[RED("areaResource")] 
		public CResourceReference<CResource> AreaResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(11)] 
		[RED("lootResource")] 
		public CResourceReference<CResource> LootResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(12)] 
		[RED("locationResource")] 
		public CResourceReference<CResource> LocationResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(13)] 
		[RED("locomotionPathResource")] 
		public CResourceAsyncReference<CResource> LocomotionPathResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(14)] 
		[RED("autoFoliageMapping")] 
		public CResourceAsyncReference<worldAutoFoliageMapping> AutoFoliageMapping
		{
			get => GetPropertyValue<CResourceAsyncReference<worldAutoFoliageMapping>>();
			set => SetPropertyValue<CResourceAsyncReference<worldAutoFoliageMapping>>(value);
		}

		[Ordinal(15)] 
		[RED("trafficPersistentResource")] 
		public CResourceAsyncReference<CResource> TrafficPersistentResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(16)] 
		[RED("trafficLaneConnectivityResource")] 
		public CResourceAsyncReference<CResource> TrafficLaneConnectivityResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(17)] 
		[RED("trafficLanePolygonsResource")] 
		public CResourceAsyncReference<CResource> TrafficLanePolygonsResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(18)] 
		[RED("trafficLaneSpotsResource")] 
		public CResourceAsyncReference<CResource> TrafficLaneSpotsResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(19)] 
		[RED("trafficSpatialRepresentationResource")] 
		public CResourceAsyncReference<CResource> TrafficSpatialRepresentationResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(20)] 
		[RED("trafficCollisionResource")] 
		public CResourceAsyncReference<CResource> TrafficCollisionResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(21)] 
		[RED("trafficNullAreaCollisionResource")] 
		public CResourceAsyncReference<CResource> TrafficNullAreaCollisionResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(22)] 
		[RED("smartObjectCompiledRootResource")] 
		public CResourceAsyncReference<CResource> SmartObjectCompiledRootResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(23)] 
		[RED("geometryCacheResource")] 
		public CResourceReference<CResource> GeometryCacheResource
		{
			get => GetPropertyValue<CResourceReference<CResource>>();
			set => SetPropertyValue<CResourceReference<CResource>>(value);
		}

		[Ordinal(24)] 
		[RED("wasBuiltForSceneRecording")] 
		public CBool WasBuiltForSceneRecording
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("streamingQueryDataResource")] 
		public CResourceAsyncReference<worldStreamingQueryDataResource> StreamingQueryDataResource
		{
			get => GetPropertyValue<CResourceAsyncReference<worldStreamingQueryDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<worldStreamingQueryDataResource>>(value);
		}

		public worldStreamingWorld()
		{
			BlockRefs = new();
			WorldBoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

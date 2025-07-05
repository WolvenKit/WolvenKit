using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLanePersistent : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("outLanes")] 
		public CArray<worldTrafficConnectivityOutLane> OutLanes
		{
			get => GetPropertyValue<CArray<worldTrafficConnectivityOutLane>>();
			set => SetPropertyValue<CArray<worldTrafficConnectivityOutLane>>(value);
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get => GetPropertyValue<CArray<worldTrafficConnectivityInLane>>();
			set => SetPropertyValue<CArray<worldTrafficConnectivityInLane>>(value);
		}

		[Ordinal(2)] 
		[RED("outline")] 
		public CArray<Vector3> Outline
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(3)] 
		[RED("accumulatedLengths")] 
		public CArray<CFloat> AccumulatedLengths
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("crowdCreationInfo")] 
		public worldTrafficLaneCrowdCreationInfo CrowdCreationInfo
		{
			get => GetPropertyValue<worldTrafficLaneCrowdCreationInfo>();
			set => SetPropertyValue<worldTrafficLaneCrowdCreationInfo>(value);
		}

		[Ordinal(5)] 
		[RED("maxSpeed")] 
		public CUInt8 MaxSpeed
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("area")] 
		public CFloat Area
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("flags")] 
		public CUInt16 Flags
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(11)] 
		[RED("subGraphId")] 
		public CUInt16 SubGraphId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(12)] 
		[RED("playerGPSInfo")] 
		public worldTrafficLanePlayerGPSInfo PlayerGPSInfo
		{
			get => GetPropertyValue<worldTrafficLanePlayerGPSInfo>();
			set => SetPropertyValue<worldTrafficLanePlayerGPSInfo>(value);
		}

		[Ordinal(13)] 
		[RED("neighborGroupIndex")] 
		public CUInt16 NeighborGroupIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(14)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(15)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(16)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(17)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("roadMaterials")] 
		public CArray<worldRoadMaterialInfo> RoadMaterials
		{
			get => GetPropertyValue<CArray<worldRoadMaterialInfo>>();
			set => SetPropertyValue<CArray<worldRoadMaterialInfo>>(value);
		}

		[Ordinal(19)] 
		[RED("polygon")] 
		public CArray<Vector2> Polygon
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		public worldTrafficLanePersistent()
		{
			OutLanes = new();
			InLanes = new();
			Outline = new();
			AccumulatedLengths = new();
			CrowdCreationInfo = new worldTrafficLaneCrowdCreationInfo { ConnectedFragments = new() };
			DeadEndStart = float.PositiveInfinity;
			SubGraphId = ushort.MaxValue;
			PlayerGPSInfo = new worldTrafficLanePlayerGPSInfo { SubGraphId = ushort.MaxValue, StronglyConnectedComponentId = ushort.MaxValue };
			NeighborGroupIndex = ushort.MaxValue;
			RoadMaterials = new();
			Polygon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

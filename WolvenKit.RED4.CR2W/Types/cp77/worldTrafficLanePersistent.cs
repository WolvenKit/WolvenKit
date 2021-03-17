using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePersistent : CVariable
	{
		private CArray<worldTrafficConnectivityOutLane> _outLanes;
		private CArray<worldTrafficConnectivityInLane> _inLanes;
		private CArray<Vector3> _outline;
		private CArray<CFloat> _accumulatedLengths;
		private worldTrafficLaneCrowdCreationInfo _crowdCreationInfo;
		private CUInt8 _maxSpeed;
		private CFloat _deadEndStart;
		private CFloat _length;
		private CFloat _width;
		private CFloat _area;
		private CUInt16 _flags;
		private CUInt16 _subGraphId;
		private worldTrafficLanePlayerGPSInfo _playerGPSInfo;
		private CUInt16 _neighborGroupIndex;
		private CUInt64 _nodeRefHash;
		private CUInt16 _laneNumber;
		private CUInt16 _seqNumber;
		private CBool _isReversed;
		private CArray<worldRoadMaterialInfo> _roadMaterials;
		private CArray<Vector2> _polygon;

		[Ordinal(0)] 
		[RED("outLanes")] 
		public CArray<worldTrafficConnectivityOutLane> OutLanes
		{
			get => GetProperty(ref _outLanes);
			set => SetProperty(ref _outLanes, value);
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get => GetProperty(ref _inLanes);
			set => SetProperty(ref _inLanes, value);
		}

		[Ordinal(2)] 
		[RED("outline")] 
		public CArray<Vector3> Outline
		{
			get => GetProperty(ref _outline);
			set => SetProperty(ref _outline, value);
		}

		[Ordinal(3)] 
		[RED("accumulatedLengths")] 
		public CArray<CFloat> AccumulatedLengths
		{
			get => GetProperty(ref _accumulatedLengths);
			set => SetProperty(ref _accumulatedLengths, value);
		}

		[Ordinal(4)] 
		[RED("crowdCreationInfo")] 
		public worldTrafficLaneCrowdCreationInfo CrowdCreationInfo
		{
			get => GetProperty(ref _crowdCreationInfo);
			set => SetProperty(ref _crowdCreationInfo, value);
		}

		[Ordinal(5)] 
		[RED("maxSpeed")] 
		public CUInt8 MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(6)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get => GetProperty(ref _deadEndStart);
			set => SetProperty(ref _deadEndStart, value);
		}

		[Ordinal(7)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		[Ordinal(8)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(9)] 
		[RED("area")] 
		public CFloat Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(10)] 
		[RED("flags")] 
		public CUInt16 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(11)] 
		[RED("subGraphId")] 
		public CUInt16 SubGraphId
		{
			get => GetProperty(ref _subGraphId);
			set => SetProperty(ref _subGraphId, value);
		}

		[Ordinal(12)] 
		[RED("playerGPSInfo")] 
		public worldTrafficLanePlayerGPSInfo PlayerGPSInfo
		{
			get => GetProperty(ref _playerGPSInfo);
			set => SetProperty(ref _playerGPSInfo, value);
		}

		[Ordinal(13)] 
		[RED("neighborGroupIndex")] 
		public CUInt16 NeighborGroupIndex
		{
			get => GetProperty(ref _neighborGroupIndex);
			set => SetProperty(ref _neighborGroupIndex, value);
		}

		[Ordinal(14)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get => GetProperty(ref _nodeRefHash);
			set => SetProperty(ref _nodeRefHash, value);
		}

		[Ordinal(15)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get => GetProperty(ref _laneNumber);
			set => SetProperty(ref _laneNumber, value);
		}

		[Ordinal(16)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get => GetProperty(ref _seqNumber);
			set => SetProperty(ref _seqNumber, value);
		}

		[Ordinal(17)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetProperty(ref _isReversed);
			set => SetProperty(ref _isReversed, value);
		}

		[Ordinal(18)] 
		[RED("roadMaterials")] 
		public CArray<worldRoadMaterialInfo> RoadMaterials
		{
			get => GetProperty(ref _roadMaterials);
			set => SetProperty(ref _roadMaterials, value);
		}

		[Ordinal(19)] 
		[RED("polygon")] 
		public CArray<Vector2> Polygon
		{
			get => GetProperty(ref _polygon);
			set => SetProperty(ref _polygon, value);
		}

		public worldTrafficLanePersistent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

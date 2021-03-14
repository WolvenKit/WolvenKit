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
			get
			{
				if (_outLanes == null)
				{
					_outLanes = (CArray<worldTrafficConnectivityOutLane>) CR2WTypeManager.Create("array:worldTrafficConnectivityOutLane", "outLanes", cr2w, this);
				}
				return _outLanes;
			}
			set
			{
				if (_outLanes == value)
				{
					return;
				}
				_outLanes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get
			{
				if (_inLanes == null)
				{
					_inLanes = (CArray<worldTrafficConnectivityInLane>) CR2WTypeManager.Create("array:worldTrafficConnectivityInLane", "inLanes", cr2w, this);
				}
				return _inLanes;
			}
			set
			{
				if (_inLanes == value)
				{
					return;
				}
				_inLanes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outline")] 
		public CArray<Vector3> Outline
		{
			get
			{
				if (_outline == null)
				{
					_outline = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "outline", cr2w, this);
				}
				return _outline;
			}
			set
			{
				if (_outline == value)
				{
					return;
				}
				_outline = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("accumulatedLengths")] 
		public CArray<CFloat> AccumulatedLengths
		{
			get
			{
				if (_accumulatedLengths == null)
				{
					_accumulatedLengths = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "accumulatedLengths", cr2w, this);
				}
				return _accumulatedLengths;
			}
			set
			{
				if (_accumulatedLengths == value)
				{
					return;
				}
				_accumulatedLengths = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("crowdCreationInfo")] 
		public worldTrafficLaneCrowdCreationInfo CrowdCreationInfo
		{
			get
			{
				if (_crowdCreationInfo == null)
				{
					_crowdCreationInfo = (worldTrafficLaneCrowdCreationInfo) CR2WTypeManager.Create("worldTrafficLaneCrowdCreationInfo", "crowdCreationInfo", cr2w, this);
				}
				return _crowdCreationInfo;
			}
			set
			{
				if (_crowdCreationInfo == value)
				{
					return;
				}
				_crowdCreationInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxSpeed")] 
		public CUInt8 MaxSpeed
		{
			get
			{
				if (_maxSpeed == null)
				{
					_maxSpeed = (CUInt8) CR2WTypeManager.Create("Uint8", "maxSpeed", cr2w, this);
				}
				return _maxSpeed;
			}
			set
			{
				if (_maxSpeed == value)
				{
					return;
				}
				_maxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get
			{
				if (_deadEndStart == null)
				{
					_deadEndStart = (CFloat) CR2WTypeManager.Create("Float", "deadEndStart", cr2w, this);
				}
				return _deadEndStart;
			}
			set
			{
				if (_deadEndStart == value)
				{
					return;
				}
				_deadEndStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("length")] 
		public CFloat Length
		{
			get
			{
				if (_length == null)
				{
					_length = (CFloat) CR2WTypeManager.Create("Float", "length", cr2w, this);
				}
				return _length;
			}
			set
			{
				if (_length == value)
				{
					return;
				}
				_length = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("area")] 
		public CFloat Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CFloat) CR2WTypeManager.Create("Float", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("flags")] 
		public CUInt16 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt16) CR2WTypeManager.Create("Uint16", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("subGraphId")] 
		public CUInt16 SubGraphId
		{
			get
			{
				if (_subGraphId == null)
				{
					_subGraphId = (CUInt16) CR2WTypeManager.Create("Uint16", "subGraphId", cr2w, this);
				}
				return _subGraphId;
			}
			set
			{
				if (_subGraphId == value)
				{
					return;
				}
				_subGraphId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerGPSInfo")] 
		public worldTrafficLanePlayerGPSInfo PlayerGPSInfo
		{
			get
			{
				if (_playerGPSInfo == null)
				{
					_playerGPSInfo = (worldTrafficLanePlayerGPSInfo) CR2WTypeManager.Create("worldTrafficLanePlayerGPSInfo", "playerGPSInfo", cr2w, this);
				}
				return _playerGPSInfo;
			}
			set
			{
				if (_playerGPSInfo == value)
				{
					return;
				}
				_playerGPSInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("neighborGroupIndex")] 
		public CUInt16 NeighborGroupIndex
		{
			get
			{
				if (_neighborGroupIndex == null)
				{
					_neighborGroupIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "neighborGroupIndex", cr2w, this);
				}
				return _neighborGroupIndex;
			}
			set
			{
				if (_neighborGroupIndex == value)
				{
					return;
				}
				_neighborGroupIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get
			{
				if (_nodeRefHash == null)
				{
					_nodeRefHash = (CUInt64) CR2WTypeManager.Create("Uint64", "nodeRefHash", cr2w, this);
				}
				return _nodeRefHash;
			}
			set
			{
				if (_nodeRefHash == value)
				{
					return;
				}
				_nodeRefHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get
			{
				if (_laneNumber == null)
				{
					_laneNumber = (CUInt16) CR2WTypeManager.Create("Uint16", "laneNumber", cr2w, this);
				}
				return _laneNumber;
			}
			set
			{
				if (_laneNumber == value)
				{
					return;
				}
				_laneNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get
			{
				if (_seqNumber == null)
				{
					_seqNumber = (CUInt16) CR2WTypeManager.Create("Uint16", "seqNumber", cr2w, this);
				}
				return _seqNumber;
			}
			set
			{
				if (_seqNumber == value)
				{
					return;
				}
				_seqNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get
			{
				if (_isReversed == null)
				{
					_isReversed = (CBool) CR2WTypeManager.Create("Bool", "isReversed", cr2w, this);
				}
				return _isReversed;
			}
			set
			{
				if (_isReversed == value)
				{
					return;
				}
				_isReversed = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("roadMaterials")] 
		public CArray<worldRoadMaterialInfo> RoadMaterials
		{
			get
			{
				if (_roadMaterials == null)
				{
					_roadMaterials = (CArray<worldRoadMaterialInfo>) CR2WTypeManager.Create("array:worldRoadMaterialInfo", "roadMaterials", cr2w, this);
				}
				return _roadMaterials;
			}
			set
			{
				if (_roadMaterials == value)
				{
					return;
				}
				_roadMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("polygon")] 
		public CArray<Vector2> Polygon
		{
			get
			{
				if (_polygon == null)
				{
					_polygon = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "polygon", cr2w, this);
				}
				return _polygon;
			}
			set
			{
				if (_polygon == value)
				{
					return;
				}
				_polygon = value;
				PropertySet(this);
			}
		}

		public worldTrafficLanePersistent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

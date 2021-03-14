using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingQueryRoadData : CVariable
	{
		private Transform _transform;
		private CHandle<Spline> _splineData;
		private worldGlobalNodeID _roadGlobalNodeId;
		private CFloat _totalRoadWidth;
		private CUInt16 _connectedRoadsStartIndex;
		private CUInt16 _connectedRoadsCount;

		[Ordinal(0)] 
		[RED("transform")] 
		public Transform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (Transform) CR2WTypeManager.Create("Transform", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("splineData")] 
		public CHandle<Spline> SplineData
		{
			get
			{
				if (_splineData == null)
				{
					_splineData = (CHandle<Spline>) CR2WTypeManager.Create("handle:Spline", "splineData", cr2w, this);
				}
				return _splineData;
			}
			set
			{
				if (_splineData == value)
				{
					return;
				}
				_splineData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("roadGlobalNodeId")] 
		public worldGlobalNodeID RoadGlobalNodeId
		{
			get
			{
				if (_roadGlobalNodeId == null)
				{
					_roadGlobalNodeId = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "roadGlobalNodeId", cr2w, this);
				}
				return _roadGlobalNodeId;
			}
			set
			{
				if (_roadGlobalNodeId == value)
				{
					return;
				}
				_roadGlobalNodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("totalRoadWidth")] 
		public CFloat TotalRoadWidth
		{
			get
			{
				if (_totalRoadWidth == null)
				{
					_totalRoadWidth = (CFloat) CR2WTypeManager.Create("Float", "totalRoadWidth", cr2w, this);
				}
				return _totalRoadWidth;
			}
			set
			{
				if (_totalRoadWidth == value)
				{
					return;
				}
				_totalRoadWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("connectedRoadsStartIndex")] 
		public CUInt16 ConnectedRoadsStartIndex
		{
			get
			{
				if (_connectedRoadsStartIndex == null)
				{
					_connectedRoadsStartIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "connectedRoadsStartIndex", cr2w, this);
				}
				return _connectedRoadsStartIndex;
			}
			set
			{
				if (_connectedRoadsStartIndex == value)
				{
					return;
				}
				_connectedRoadsStartIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("connectedRoadsCount")] 
		public CUInt16 ConnectedRoadsCount
		{
			get
			{
				if (_connectedRoadsCount == null)
				{
					_connectedRoadsCount = (CUInt16) CR2WTypeManager.Create("Uint16", "connectedRoadsCount", cr2w, this);
				}
				return _connectedRoadsCount;
			}
			set
			{
				if (_connectedRoadsCount == value)
				{
					return;
				}
				_connectedRoadsCount = value;
				PropertySet(this);
			}
		}

		public worldStreamingQueryRoadData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

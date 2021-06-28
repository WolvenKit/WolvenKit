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
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(1)] 
		[RED("splineData")] 
		public CHandle<Spline> SplineData
		{
			get => GetProperty(ref _splineData);
			set => SetProperty(ref _splineData, value);
		}

		[Ordinal(2)] 
		[RED("roadGlobalNodeId")] 
		public worldGlobalNodeID RoadGlobalNodeId
		{
			get => GetProperty(ref _roadGlobalNodeId);
			set => SetProperty(ref _roadGlobalNodeId, value);
		}

		[Ordinal(3)] 
		[RED("totalRoadWidth")] 
		public CFloat TotalRoadWidth
		{
			get => GetProperty(ref _totalRoadWidth);
			set => SetProperty(ref _totalRoadWidth, value);
		}

		[Ordinal(4)] 
		[RED("connectedRoadsStartIndex")] 
		public CUInt16 ConnectedRoadsStartIndex
		{
			get => GetProperty(ref _connectedRoadsStartIndex);
			set => SetProperty(ref _connectedRoadsStartIndex, value);
		}

		[Ordinal(5)] 
		[RED("connectedRoadsCount")] 
		public CUInt16 ConnectedRoadsCount
		{
			get => GetProperty(ref _connectedRoadsCount);
			set => SetProperty(ref _connectedRoadsCount, value);
		}

		public worldStreamingQueryRoadData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

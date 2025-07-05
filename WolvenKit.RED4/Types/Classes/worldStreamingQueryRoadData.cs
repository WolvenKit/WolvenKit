using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingQueryRoadData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(1)] 
		[RED("splineData")] 
		public CHandle<Spline> SplineData
		{
			get => GetPropertyValue<CHandle<Spline>>();
			set => SetPropertyValue<CHandle<Spline>>(value);
		}

		[Ordinal(2)] 
		[RED("roadGlobalNodeId")] 
		public worldGlobalNodeID RoadGlobalNodeId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(3)] 
		[RED("totalRoadWidth")] 
		public CFloat TotalRoadWidth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("connectedRoadsStartIndex")] 
		public CUInt16 ConnectedRoadsStartIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(5)] 
		[RED("connectedRoadsCount")] 
		public CUInt16 ConnectedRoadsCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public worldStreamingQueryRoadData()
		{
			Transform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			RoadGlobalNodeId = new worldGlobalNodeID();
			ConnectedRoadsStartIndex = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

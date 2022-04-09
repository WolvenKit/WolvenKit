using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMoveOnSplineAndKeepDistance_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("keepDistanceFromRef")] 
		public gameEntityReference KeepDistanceFromRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("reduceSpeedOnTurns")] 
		public CBool ReduceSpeedOnTurns
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMoveOnSplineAndKeepDistance_NodeType()
		{
			VehicleRef = new() { Names = new() };
			KeepDistanceFromRef = new() { Names = new() };
			ReduceSpeedOnTurns = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

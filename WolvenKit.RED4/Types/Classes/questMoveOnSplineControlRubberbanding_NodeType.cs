using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMoveOnSplineControlRubberbanding_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("keepDistanceFromRef")] 
		public gameEntityReference KeepDistanceFromRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("reduceSpeedOnTurns")] 
		public CBool ReduceSpeedOnTurns
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMoveOnSplineControlRubberbanding_NodeType()
		{
			VehicleRef = new gameEntityReference { Names = new() };
			KeepDistanceFromRef = new gameEntityReference { Names = new() };
			ReduceSpeedOnTurns = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

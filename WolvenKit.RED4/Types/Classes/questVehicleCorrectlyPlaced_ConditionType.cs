using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleCorrectlyPlaced_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("checkIsUpsideDown")] 
		public CBool CheckIsUpsideDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("checkIsOnTheSide")] 
		public CBool CheckIsOnTheSide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("checkAreAllWheelsOnGround")] 
		public CBool CheckAreAllWheelsOnGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questVehicleCorrectlyPlaced_ConditionType()
		{
			VehicleRef = new gameEntityReference { Names = new() };
			CheckIsUpsideDown = true;
			CheckIsOnTheSide = true;
			CheckAreAllWheelsOnGround = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questvehicleFollowParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] 
		[RED("targetEntRef")] 
		public gameEntityReference TargetEntRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(4)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questvehicleFollowParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;
			TargetEntRef = new gameEntityReference { Names = new() };
			DistanceMin = 1.000000F;
			DistanceMax = 5.000000F;
			UseTraffic = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questvehicleToNodeParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] 
		[RED("stopAtEnd")] 
		public CBool StopAtEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get => GetPropertyValue<CHandle<vehiclePortalsList>>();
			set => SetPropertyValue<CHandle<vehiclePortalsList>>(value);
		}

		[Ordinal(10)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("ignoreNoAIDrivingLanes")] 
		public CBool IgnoreNoAIDrivingLanes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questvehicleToNodeParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;
			StopAtEnd = true;
			UseTraffic = true;
			ForceGreenLights = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

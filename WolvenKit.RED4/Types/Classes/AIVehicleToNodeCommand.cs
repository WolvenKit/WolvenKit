using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIVehicleToNodeCommand : AIVehicleCommand
	{
		[Ordinal(6)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get => GetPropertyValue<CHandle<vehiclePortalsList>>();
			set => SetPropertyValue<CHandle<vehiclePortalsList>>(value);
		}

		[Ordinal(14)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIVehicleToNodeCommand()
		{
			StopAtPathEnd = true;
			SecureTimeOut = 2.000000F;
			UseTraffic = true;
			ForceGreenLights = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

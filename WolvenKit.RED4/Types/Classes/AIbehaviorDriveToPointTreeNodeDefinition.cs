using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDriveToPointTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("useTraffic")] 
		public CHandle<AIArgumentMapping> UseTraffic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("speedInTraffic")] 
		public CHandle<AIArgumentMapping> SpeedInTraffic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("forceGreenLights")] 
		public CHandle<AIArgumentMapping> ForceGreenLights
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("portals")] 
		public CHandle<AIArgumentMapping> Portals
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("trafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorDriveToPointTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

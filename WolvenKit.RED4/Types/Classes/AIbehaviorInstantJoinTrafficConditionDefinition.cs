using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorInstantJoinTrafficConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("closestPointOnPath")] 
		public CHandle<AIArgumentMapping> ClosestPointOnPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("pathDirection")] 
		public CHandle<AIArgumentMapping> PathDirection
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("runOnTraffic")] 
		public CHandle<AIArgumentMapping> RunOnTraffic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorInstantJoinTrafficConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorGetPatrolPointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("inPatrolDistance")] 
		public CHandle<AIArgumentMapping> InPatrolDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("inLastKnownPosition")] 
		public CHandle<AIArgumentMapping> InLastKnownPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outFollowTrailPoint")] 
		public CHandle<AIArgumentMapping> OutFollowTrailPoint
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorGetPatrolPointTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

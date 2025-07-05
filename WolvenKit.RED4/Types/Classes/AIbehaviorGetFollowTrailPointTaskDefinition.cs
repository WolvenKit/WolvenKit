using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorGetFollowTrailPointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("inTrailDelay")] 
		public CHandle<AIArgumentMapping> InTrailDelay
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outFollowTrailPoint")] 
		public CHandle<AIArgumentMapping> OutFollowTrailPoint
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorGetFollowTrailPointTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

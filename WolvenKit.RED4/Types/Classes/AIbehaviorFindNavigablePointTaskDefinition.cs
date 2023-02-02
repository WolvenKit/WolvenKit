using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFindNavigablePointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outAdjustedDestination")] 
		public CHandle<AIArgumentMapping> OutAdjustedDestination
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outWasAdjusted")] 
		public CHandle<AIArgumentMapping> OutWasAdjusted
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorFindNavigablePointTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

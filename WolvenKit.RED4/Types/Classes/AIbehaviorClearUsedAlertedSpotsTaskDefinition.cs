using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorClearUsedAlertedSpotsTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("usedTokens")] 
		public CHandle<AIArgumentMapping> UsedTokens
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorClearUsedAlertedSpotsTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

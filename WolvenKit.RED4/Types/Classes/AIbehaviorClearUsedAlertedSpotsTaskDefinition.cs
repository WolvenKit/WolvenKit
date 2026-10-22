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
			UsedTokens = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

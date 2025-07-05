using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_FloatEvaluator_Blackboard : gameIEffectParameter_FloatEvaluator
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		public gameEffectParameter_FloatEvaluator_Blackboard()
		{
			BlackboardProperty = new gameBlackboardPropertyBindingDefinition { SerializableID = new gameBlackboardSerializableID(), PropertyPath = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

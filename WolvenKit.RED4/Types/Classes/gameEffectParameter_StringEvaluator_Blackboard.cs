using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_StringEvaluator_Blackboard : gameIEffectParameter_StringEvaluator
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		public gameEffectParameter_StringEvaluator_Blackboard()
		{
			BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

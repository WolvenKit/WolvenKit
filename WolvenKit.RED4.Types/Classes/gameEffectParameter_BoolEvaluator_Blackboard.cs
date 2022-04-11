using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectParameter_BoolEvaluator_Blackboard : gameIEffectParameter_BoolEvaluator
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		public gameEffectParameter_BoolEvaluator_Blackboard()
		{
			BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };
		}
	}
}

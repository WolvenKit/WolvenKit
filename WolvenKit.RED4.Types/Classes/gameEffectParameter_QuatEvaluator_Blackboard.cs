using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectParameter_QuatEvaluator_Blackboard : gameIEffectParameter_QuatEvaluator
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		public gameEffectParameter_QuatEvaluator_Blackboard()
		{
			BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };
		}
	}
}

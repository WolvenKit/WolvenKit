using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_QuatEvaluator_ValueOrBlackboard : gameIEffectParameter_QuatEvaluator
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public Quaternion Value
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public gameEffectParameter_QuatEvaluator_ValueOrBlackboard()
		{
			BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };
			Value = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

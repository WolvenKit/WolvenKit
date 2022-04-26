using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_VectorEvaluator_ValueOrBlackboard : gameIEffectParameter_VectorEvaluator
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
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameEffectParameter_VectorEvaluator_ValueOrBlackboard()
		{
			BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };
			Value = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

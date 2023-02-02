using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectOutputParameter_Float : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		public gameEffectOutputParameter_Float()
		{
			BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

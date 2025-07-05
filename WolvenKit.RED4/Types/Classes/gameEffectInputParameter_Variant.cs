using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectInputParameter_Variant : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		public gameEffectInputParameter_Variant()
		{
			BlackboardProperty = new gameBlackboardPropertyBindingDefinition { SerializableID = new gameBlackboardSerializableID(), PropertyPath = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

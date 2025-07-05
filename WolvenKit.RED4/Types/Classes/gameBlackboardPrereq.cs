using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBlackboardPrereq : gameIComparisonPrereq
	{
		[Ordinal(1)] 
		[RED("blackboardValue")] 
		public gameBlackboardPropertyBindingDefinition BlackboardValue
		{
			get => GetPropertyValue<gameBlackboardPropertyBindingDefinition>();
			set => SetPropertyValue<gameBlackboardPropertyBindingDefinition>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public gameBlackboardPrereq()
		{
			BlackboardValue = new gameBlackboardPropertyBindingDefinition { SerializableID = new gameBlackboardSerializableID(), PropertyPath = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

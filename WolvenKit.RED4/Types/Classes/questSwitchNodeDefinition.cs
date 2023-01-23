using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSwitchNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("behaviour")] 
		public CEnum<questESwitchBehaviourType> Behaviour
		{
			get => GetPropertyValue<CEnum<questESwitchBehaviourType>>();
			set => SetPropertyValue<CEnum<questESwitchBehaviourType>>(value);
		}

		[Ordinal(3)] 
		[RED("conditions")] 
		public CArray<questConditionItem> Conditions
		{
			get => GetPropertyValue<CArray<questConditionItem>>();
			set => SetPropertyValue<CArray<questConditionItem>>(value);
		}

		public questSwitchNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

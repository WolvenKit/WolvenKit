using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSlotOccupiedConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("slot")] 
		public CHandle<AIArgumentMapping> Slot
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorSlotOccupiedConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

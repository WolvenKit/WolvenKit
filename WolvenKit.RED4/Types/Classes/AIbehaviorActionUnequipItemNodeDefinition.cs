using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionUnequipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		[Ordinal(1)] 
		[RED("slotId")] 
		public CHandle<AIArgumentMapping> SlotId
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionUnequipItemNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

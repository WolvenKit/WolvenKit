using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorExtractVehicleSlotWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorExtractVehicleSlotWorkspotTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

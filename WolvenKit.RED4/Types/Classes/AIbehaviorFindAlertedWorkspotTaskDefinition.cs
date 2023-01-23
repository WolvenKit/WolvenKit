using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFindAlertedWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("usedTokens")] 
		public CHandle<AIArgumentMapping> UsedTokens
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("spots")] 
		public CHandle<AIArgumentMapping> Spots
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CHandle<AIArgumentMapping> Radius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorFindAlertedWorkspotTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorGetSearchPointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("inPlayerPositionDelay")] 
		public CHandle<AIArgumentMapping> InPlayerPositionDelay
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("inSearchPositionMaxRadius")] 
		public CHandle<AIArgumentMapping> InSearchPositionMaxRadius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("inNearestNavmeshPolyExtent")] 
		public CHandle<AIArgumentMapping> InNearestNavmeshPolyExtent
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("inPavementsOnly")] 
		public CHandle<AIArgumentMapping> InPavementsOnly
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("inLastKnownPosition")] 
		public CHandle<AIArgumentMapping> InLastKnownPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("outSearchPosition")] 
		public CHandle<AIArgumentMapping> OutSearchPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorGetSearchPointTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

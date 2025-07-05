using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorTryGetChasePointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("inPlayerPositionDelay")] 
		public CHandle<AIArgumentMapping> InPlayerPositionDelay
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("inPlayerPositionMaxDistance")] 
		public CHandle<AIArgumentMapping> InPlayerPositionMaxDistance
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
		[RED("outChasePosition")] 
		public CHandle<AIArgumentMapping> OutChasePosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorTryGetChasePointTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

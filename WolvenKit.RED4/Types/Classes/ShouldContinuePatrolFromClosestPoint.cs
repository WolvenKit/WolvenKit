using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShouldContinuePatrolFromClosestPoint : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("patrolContinuationPolicy")] 
		public CHandle<AIArgumentMapping> PatrolContinuationPolicy
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public ShouldContinuePatrolFromClosestPoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

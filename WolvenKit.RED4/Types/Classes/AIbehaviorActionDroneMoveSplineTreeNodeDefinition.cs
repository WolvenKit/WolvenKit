using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionDroneMoveSplineTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionDroneMoveSplineTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

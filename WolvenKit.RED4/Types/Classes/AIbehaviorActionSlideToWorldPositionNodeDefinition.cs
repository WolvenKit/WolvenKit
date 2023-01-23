using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionSlideToWorldPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		[Ordinal(4)] 
		[RED("worldPosition")] 
		public CHandle<AIArgumentMapping> WorldPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("useMovePlanner")] 
		public CBool UseMovePlanner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorActionSlideToWorldPositionNodeDefinition()
		{
			UseMovePlanner = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

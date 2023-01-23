using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorEdgeConditionDefinition : AIbehaviorUnaryConditionDefinition
	{
		[Ordinal(2)] 
		[RED("risingEdgeAction")] 
		public CEnum<AIbehaviorEdgeConditionAction> RisingEdgeAction
		{
			get => GetPropertyValue<CEnum<AIbehaviorEdgeConditionAction>>();
			set => SetPropertyValue<CEnum<AIbehaviorEdgeConditionAction>>(value);
		}

		[Ordinal(3)] 
		[RED("fallingEdgeAction")] 
		public CEnum<AIbehaviorEdgeConditionAction> FallingEdgeAction
		{
			get => GetPropertyValue<CEnum<AIbehaviorEdgeConditionAction>>();
			set => SetPropertyValue<CEnum<AIbehaviorEdgeConditionAction>>(value);
		}

		[Ordinal(4)] 
		[RED("initialValue")] 
		public CBool InitialValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorEdgeConditionDefinition()
		{
			RisingEdgeAction = Enums.AIbehaviorEdgeConditionAction.TurnOn;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

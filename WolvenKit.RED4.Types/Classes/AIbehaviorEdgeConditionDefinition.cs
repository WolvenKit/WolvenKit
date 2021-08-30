using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorEdgeConditionDefinition : AIbehaviorUnaryConditionDefinition
	{
		private CEnum<AIbehaviorEdgeConditionAction> _risingEdgeAction;
		private CEnum<AIbehaviorEdgeConditionAction> _fallingEdgeAction;
		private CBool _initialValue;

		[Ordinal(2)] 
		[RED("risingEdgeAction")] 
		public CEnum<AIbehaviorEdgeConditionAction> RisingEdgeAction
		{
			get => GetProperty(ref _risingEdgeAction);
			set => SetProperty(ref _risingEdgeAction, value);
		}

		[Ordinal(3)] 
		[RED("fallingEdgeAction")] 
		public CEnum<AIbehaviorEdgeConditionAction> FallingEdgeAction
		{
			get => GetProperty(ref _fallingEdgeAction);
			set => SetProperty(ref _fallingEdgeAction, value);
		}

		[Ordinal(4)] 
		[RED("initialValue")] 
		public CBool InitialValue
		{
			get => GetProperty(ref _initialValue);
			set => SetProperty(ref _initialValue, value);
		}

		public AIbehaviorEdgeConditionDefinition()
		{
			_risingEdgeAction = new() { Value = Enums.AIbehaviorEdgeConditionAction.TurnOn };
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEdgeConditionDefinition : AIbehaviorUnaryConditionDefinition
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

		public AIbehaviorEdgeConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

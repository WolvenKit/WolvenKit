using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFSMTransitionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		private CUInt16 _inState;
		private CUInt16 _outState;
		private CInt32 _evaluationOrder;
		private CArray<CHandle<AIbehaviorInstantConditionDefinition>> _instantConditions;
		private CArray<CHandle<AIbehaviorMonitorConditionDefinition>> _monitorConditions;
		private CArray<CHandle<AIbehaviorEventConditionDefinition>> _eventConditions;
		private CArray<CHandle<AIbehaviorExpressionSocket>> _passiveConditions;

		[Ordinal(0)] 
		[RED("inState")] 
		public CUInt16 InState
		{
			get => GetProperty(ref _inState);
			set => SetProperty(ref _inState, value);
		}

		[Ordinal(1)] 
		[RED("outState")] 
		public CUInt16 OutState
		{
			get => GetProperty(ref _outState);
			set => SetProperty(ref _outState, value);
		}

		[Ordinal(2)] 
		[RED("evaluationOrder")] 
		public CInt32 EvaluationOrder
		{
			get => GetProperty(ref _evaluationOrder);
			set => SetProperty(ref _evaluationOrder, value);
		}

		[Ordinal(3)] 
		[RED("instantConditions")] 
		public CArray<CHandle<AIbehaviorInstantConditionDefinition>> InstantConditions
		{
			get => GetProperty(ref _instantConditions);
			set => SetProperty(ref _instantConditions, value);
		}

		[Ordinal(4)] 
		[RED("monitorConditions")] 
		public CArray<CHandle<AIbehaviorMonitorConditionDefinition>> MonitorConditions
		{
			get => GetProperty(ref _monitorConditions);
			set => SetProperty(ref _monitorConditions, value);
		}

		[Ordinal(5)] 
		[RED("eventConditions")] 
		public CArray<CHandle<AIbehaviorEventConditionDefinition>> EventConditions
		{
			get => GetProperty(ref _eventConditions);
			set => SetProperty(ref _eventConditions, value);
		}

		[Ordinal(6)] 
		[RED("passiveConditions")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> PassiveConditions
		{
			get => GetProperty(ref _passiveConditions);
			set => SetProperty(ref _passiveConditions, value);
		}

		public AIbehaviorFSMTransitionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

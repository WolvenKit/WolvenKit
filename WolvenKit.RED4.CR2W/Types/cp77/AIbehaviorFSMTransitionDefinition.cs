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
			get
			{
				if (_inState == null)
				{
					_inState = (CUInt16) CR2WTypeManager.Create("Uint16", "inState", cr2w, this);
				}
				return _inState;
			}
			set
			{
				if (_inState == value)
				{
					return;
				}
				_inState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outState")] 
		public CUInt16 OutState
		{
			get
			{
				if (_outState == null)
				{
					_outState = (CUInt16) CR2WTypeManager.Create("Uint16", "outState", cr2w, this);
				}
				return _outState;
			}
			set
			{
				if (_outState == value)
				{
					return;
				}
				_outState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("evaluationOrder")] 
		public CInt32 EvaluationOrder
		{
			get
			{
				if (_evaluationOrder == null)
				{
					_evaluationOrder = (CInt32) CR2WTypeManager.Create("Int32", "evaluationOrder", cr2w, this);
				}
				return _evaluationOrder;
			}
			set
			{
				if (_evaluationOrder == value)
				{
					return;
				}
				_evaluationOrder = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("instantConditions")] 
		public CArray<CHandle<AIbehaviorInstantConditionDefinition>> InstantConditions
		{
			get
			{
				if (_instantConditions == null)
				{
					_instantConditions = (CArray<CHandle<AIbehaviorInstantConditionDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorInstantConditionDefinition", "instantConditions", cr2w, this);
				}
				return _instantConditions;
			}
			set
			{
				if (_instantConditions == value)
				{
					return;
				}
				_instantConditions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("monitorConditions")] 
		public CArray<CHandle<AIbehaviorMonitorConditionDefinition>> MonitorConditions
		{
			get
			{
				if (_monitorConditions == null)
				{
					_monitorConditions = (CArray<CHandle<AIbehaviorMonitorConditionDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorMonitorConditionDefinition", "monitorConditions", cr2w, this);
				}
				return _monitorConditions;
			}
			set
			{
				if (_monitorConditions == value)
				{
					return;
				}
				_monitorConditions = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("eventConditions")] 
		public CArray<CHandle<AIbehaviorEventConditionDefinition>> EventConditions
		{
			get
			{
				if (_eventConditions == null)
				{
					_eventConditions = (CArray<CHandle<AIbehaviorEventConditionDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorEventConditionDefinition", "eventConditions", cr2w, this);
				}
				return _eventConditions;
			}
			set
			{
				if (_eventConditions == value)
				{
					return;
				}
				_eventConditions = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("passiveConditions")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> PassiveConditions
		{
			get
			{
				if (_passiveConditions == null)
				{
					_passiveConditions = (CArray<CHandle<AIbehaviorExpressionSocket>>) CR2WTypeManager.Create("array:handle:AIbehaviorExpressionSocket", "passiveConditions", cr2w, this);
				}
				return _passiveConditions;
			}
			set
			{
				if (_passiveConditions == value)
				{
					return;
				}
				_passiveConditions = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFSMTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

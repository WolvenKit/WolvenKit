using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StateMachine_ : animAnimNode_Base
	{
		private CArray<CHandle<animAnimNode_State>> _states;
		private CHandle<animAnimNode_StateFrozen> _frozenState;
		private CArray<CHandle<animAnimStateTransitionDescription>> _transitions;
		private CArray<CHandle<animAnimStateMachineConditionalEntry>> _conditionalEntries;
		private CArray<CHandle<animAnimStateTransitionDescription>> _globalTransitions;
		private CHandle<animIAnimStateTransitionInterpolator> _anyStateInterpolator;
		private CUInt32 _defaultStateIndex;
		private CBool _notifyOnEnterState;

		[Ordinal(11)] 
		[RED("states")] 
		public CArray<CHandle<animAnimNode_State>> States
		{
			get
			{
				if (_states == null)
				{
					_states = (CArray<CHandle<animAnimNode_State>>) CR2WTypeManager.Create("array:handle:animAnimNode_State", "states", cr2w, this);
				}
				return _states;
			}
			set
			{
				if (_states == value)
				{
					return;
				}
				_states = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("frozenState")] 
		public CHandle<animAnimNode_StateFrozen> FrozenState
		{
			get
			{
				if (_frozenState == null)
				{
					_frozenState = (CHandle<animAnimNode_StateFrozen>) CR2WTypeManager.Create("handle:animAnimNode_StateFrozen", "frozenState", cr2w, this);
				}
				return _frozenState;
			}
			set
			{
				if (_frozenState == value)
				{
					return;
				}
				_frozenState = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("transitions")] 
		public CArray<CHandle<animAnimStateTransitionDescription>> Transitions
		{
			get
			{
				if (_transitions == null)
				{
					_transitions = (CArray<CHandle<animAnimStateTransitionDescription>>) CR2WTypeManager.Create("array:handle:animAnimStateTransitionDescription", "transitions", cr2w, this);
				}
				return _transitions;
			}
			set
			{
				if (_transitions == value)
				{
					return;
				}
				_transitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("conditionalEntries")] 
		public CArray<CHandle<animAnimStateMachineConditionalEntry>> ConditionalEntries
		{
			get
			{
				if (_conditionalEntries == null)
				{
					_conditionalEntries = (CArray<CHandle<animAnimStateMachineConditionalEntry>>) CR2WTypeManager.Create("array:handle:animAnimStateMachineConditionalEntry", "conditionalEntries", cr2w, this);
				}
				return _conditionalEntries;
			}
			set
			{
				if (_conditionalEntries == value)
				{
					return;
				}
				_conditionalEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("globalTransitions")] 
		public CArray<CHandle<animAnimStateTransitionDescription>> GlobalTransitions
		{
			get
			{
				if (_globalTransitions == null)
				{
					_globalTransitions = (CArray<CHandle<animAnimStateTransitionDescription>>) CR2WTypeManager.Create("array:handle:animAnimStateTransitionDescription", "globalTransitions", cr2w, this);
				}
				return _globalTransitions;
			}
			set
			{
				if (_globalTransitions == value)
				{
					return;
				}
				_globalTransitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("anyStateInterpolator")] 
		public CHandle<animIAnimStateTransitionInterpolator> AnyStateInterpolator
		{
			get
			{
				if (_anyStateInterpolator == null)
				{
					_anyStateInterpolator = (CHandle<animIAnimStateTransitionInterpolator>) CR2WTypeManager.Create("handle:animIAnimStateTransitionInterpolator", "anyStateInterpolator", cr2w, this);
				}
				return _anyStateInterpolator;
			}
			set
			{
				if (_anyStateInterpolator == value)
				{
					return;
				}
				_anyStateInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("defaultStateIndex")] 
		public CUInt32 DefaultStateIndex
		{
			get
			{
				if (_defaultStateIndex == null)
				{
					_defaultStateIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "defaultStateIndex", cr2w, this);
				}
				return _defaultStateIndex;
			}
			set
			{
				if (_defaultStateIndex == value)
				{
					return;
				}
				_defaultStateIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("notifyOnEnterState")] 
		public CBool NotifyOnEnterState
		{
			get
			{
				if (_notifyOnEnterState == null)
				{
					_notifyOnEnterState = (CBool) CR2WTypeManager.Create("Bool", "notifyOnEnterState", cr2w, this);
				}
				return _notifyOnEnterState;
			}
			set
			{
				if (_notifyOnEnterState == value)
				{
					return;
				}
				_notifyOnEnterState = value;
				PropertySet(this);
			}
		}

		public animAnimNode_StateMachine_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

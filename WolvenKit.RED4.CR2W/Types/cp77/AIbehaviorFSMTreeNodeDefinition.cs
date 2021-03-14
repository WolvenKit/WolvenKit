using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFSMTreeNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		private CArray<CHandle<AIbehaviorFSMStateDefinition>> _states;
		private CArray<CHandle<AIbehaviorFSMTransitionDefinition>> _transitions;
		private CHandle<AIbehaviorFSMStateDefinition> _initialState;

		[Ordinal(0)] 
		[RED("states")] 
		public CArray<CHandle<AIbehaviorFSMStateDefinition>> States
		{
			get
			{
				if (_states == null)
				{
					_states = (CArray<CHandle<AIbehaviorFSMStateDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorFSMStateDefinition", "states", cr2w, this);
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

		[Ordinal(1)] 
		[RED("transitions")] 
		public CArray<CHandle<AIbehaviorFSMTransitionDefinition>> Transitions
		{
			get
			{
				if (_transitions == null)
				{
					_transitions = (CArray<CHandle<AIbehaviorFSMTransitionDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorFSMTransitionDefinition", "transitions", cr2w, this);
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

		[Ordinal(2)] 
		[RED("initialState")] 
		public CHandle<AIbehaviorFSMStateDefinition> InitialState
		{
			get
			{
				if (_initialState == null)
				{
					_initialState = (CHandle<AIbehaviorFSMStateDefinition>) CR2WTypeManager.Create("handle:AIbehaviorFSMStateDefinition", "initialState", cr2w, this);
				}
				return _initialState;
			}
			set
			{
				if (_initialState == value)
				{
					return;
				}
				_initialState = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFSMTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

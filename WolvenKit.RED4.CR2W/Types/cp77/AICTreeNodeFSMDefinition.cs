using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeFSMDefinition : AICTreeNodeCompositeDefinition
	{
		private CUInt16 _defaultState;
		private CArray<AIFSMTransitionDefinition> _transitions;
		private CArray<AIFSMEventTransitionsListDefinition> _onEventTransitions;
		private CArray<AIFSMStateDefinition> _states;
		private AISharedVarTableDefinition _sharedVars;

		[Ordinal(0)] 
		[RED("defaultState")] 
		public CUInt16 DefaultState
		{
			get
			{
				if (_defaultState == null)
				{
					_defaultState = (CUInt16) CR2WTypeManager.Create("Uint16", "defaultState", cr2w, this);
				}
				return _defaultState;
			}
			set
			{
				if (_defaultState == value)
				{
					return;
				}
				_defaultState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public CArray<AIFSMTransitionDefinition> Transitions
		{
			get
			{
				if (_transitions == null)
				{
					_transitions = (CArray<AIFSMTransitionDefinition>) CR2WTypeManager.Create("array:AIFSMTransitionDefinition", "transitions", cr2w, this);
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
		[RED("onEventTransitions")] 
		public CArray<AIFSMEventTransitionsListDefinition> OnEventTransitions
		{
			get
			{
				if (_onEventTransitions == null)
				{
					_onEventTransitions = (CArray<AIFSMEventTransitionsListDefinition>) CR2WTypeManager.Create("array:AIFSMEventTransitionsListDefinition", "onEventTransitions", cr2w, this);
				}
				return _onEventTransitions;
			}
			set
			{
				if (_onEventTransitions == value)
				{
					return;
				}
				_onEventTransitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("states")] 
		public CArray<AIFSMStateDefinition> States
		{
			get
			{
				if (_states == null)
				{
					_states = (CArray<AIFSMStateDefinition>) CR2WTypeManager.Create("array:AIFSMStateDefinition", "states", cr2w, this);
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

		[Ordinal(4)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get
			{
				if (_sharedVars == null)
				{
					_sharedVars = (AISharedVarTableDefinition) CR2WTypeManager.Create("AISharedVarTableDefinition", "sharedVars", cr2w, this);
				}
				return _sharedVars;
			}
			set
			{
				if (_sharedVars == value)
				{
					return;
				}
				_sharedVars = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeFSMDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineComponentReplicatedState : netIComponentState
	{
		private gamestateMachineStateContext _stateContext;
		private CHandle<gamestateMachineparameterTypeLadderDescription> _enterLadderParameter;
		private CBool _exitLadderParameter;

		[Ordinal(2)] 
		[RED("stateContext")] 
		public gamestateMachineStateContext StateContext
		{
			get
			{
				if (_stateContext == null)
				{
					_stateContext = (gamestateMachineStateContext) CR2WTypeManager.Create("gamestateMachineStateContext", "stateContext", cr2w, this);
				}
				return _stateContext;
			}
			set
			{
				if (_stateContext == value)
				{
					return;
				}
				_stateContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enterLadderParameter")] 
		public CHandle<gamestateMachineparameterTypeLadderDescription> EnterLadderParameter
		{
			get
			{
				if (_enterLadderParameter == null)
				{
					_enterLadderParameter = (CHandle<gamestateMachineparameterTypeLadderDescription>) CR2WTypeManager.Create("handle:gamestateMachineparameterTypeLadderDescription", "enterLadderParameter", cr2w, this);
				}
				return _enterLadderParameter;
			}
			set
			{
				if (_enterLadderParameter == value)
				{
					return;
				}
				_enterLadderParameter = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exitLadderParameter")] 
		public CBool ExitLadderParameter
		{
			get
			{
				if (_exitLadderParameter == null)
				{
					_exitLadderParameter = (CBool) CR2WTypeManager.Create("Bool", "exitLadderParameter", cr2w, this);
				}
				return _exitLadderParameter;
			}
			set
			{
				if (_exitLadderParameter == value)
				{
					return;
				}
				_exitLadderParameter = value;
				PropertySet(this);
			}
		}

		public gamestateMachineComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

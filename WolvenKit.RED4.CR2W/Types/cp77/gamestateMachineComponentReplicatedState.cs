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
			get => GetProperty(ref _stateContext);
			set => SetProperty(ref _stateContext, value);
		}

		[Ordinal(3)] 
		[RED("enterLadderParameter")] 
		public CHandle<gamestateMachineparameterTypeLadderDescription> EnterLadderParameter
		{
			get => GetProperty(ref _enterLadderParameter);
			set => SetProperty(ref _enterLadderParameter, value);
		}

		[Ordinal(4)] 
		[RED("exitLadderParameter")] 
		public CBool ExitLadderParameter
		{
			get => GetProperty(ref _exitLadderParameter);
			set => SetProperty(ref _exitLadderParameter, value);
		}

		public gamestateMachineComponentReplicatedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

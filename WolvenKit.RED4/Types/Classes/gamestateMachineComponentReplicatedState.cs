using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("stateContext")] 
		public gamestateMachineStateContext StateContext
		{
			get => GetPropertyValue<gamestateMachineStateContext>();
			set => SetPropertyValue<gamestateMachineStateContext>(value);
		}

		[Ordinal(3)] 
		[RED("enterLadderParameter")] 
		public CHandle<gamestateMachineparameterTypeLadderDescription> EnterLadderParameter
		{
			get => GetPropertyValue<CHandle<gamestateMachineparameterTypeLadderDescription>>();
			set => SetPropertyValue<CHandle<gamestateMachineparameterTypeLadderDescription>>(value);
		}

		[Ordinal(4)] 
		[RED("exitLadderParameter")] 
		public CBool ExitLadderParameter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineComponentReplicatedState()
		{
			Enabled = true;
			StateContext = new gamestateMachineStateContext { Snapshot = new gamestateMachineStateSnapshotsContainer { Snapshot = new() }, PermanentParameters = new gamestateMachineStateContextParameters { BoolParameters = new(0), IntParameters = new(0), FloatParameters = new(0), DoubleParameters = new(0), VectorParameters = new(0), CNameParameters = new(0), IScriptableParameters = new(0), TweakDBIDParameters = new(0) } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAINetStateComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("replHighLevelState")] 
		public gameNetAIState ReplHighLevelState
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(3)] 
		[RED("replUpperBodyState")] 
		public gameNetAIState ReplUpperBodyState
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(4)] 
		[RED("replStanceState")] 
		public gameNetAIState ReplStanceState
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(5)] 
		[RED("replHitReactionModeState")] 
		public gameNetAIState ReplHitReactionModeState
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(6)] 
		[RED("replBehaviorState")] 
		public gameNetAIState ReplBehaviorState
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(7)] 
		[RED("replPhaseState")] 
		public gameNetAIState ReplPhaseState
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(8)] 
		[RED("replDefenseMode")] 
		public gameNetAIState ReplDefenseMode
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		[Ordinal(9)] 
		[RED("replLocomotionMode")] 
		public gameNetAIState ReplLocomotionMode
		{
			get => GetPropertyValue<gameNetAIState>();
			set => SetPropertyValue<gameNetAIState>(value);
		}

		public gameAINetStateComponentReplicatedState()
		{
			Enabled = true;
			ReplHighLevelState = new() { Time = -1.000000F };
			ReplUpperBodyState = new() { Time = -1.000000F };
			ReplStanceState = new() { Time = -1.000000F };
			ReplHitReactionModeState = new() { Time = -1.000000F };
			ReplBehaviorState = new() { Time = -1.000000F };
			ReplPhaseState = new() { Time = -1.000000F };
			ReplDefenseMode = new() { Time = -1.000000F };
			ReplLocomotionMode = new() { Time = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

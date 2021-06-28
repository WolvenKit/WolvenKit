using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAINetStateComponentReplicatedState : netIComponentState
	{
		private gameNetAIState _replHighLevelState;
		private gameNetAIState _replUpperBodyState;
		private gameNetAIState _replStanceState;
		private gameNetAIState _replHitReactionModeState;
		private gameNetAIState _replBehaviorState;
		private gameNetAIState _replPhaseState;
		private gameNetAIState _replDefenseMode;
		private gameNetAIState _replLocomotionMode;

		[Ordinal(2)] 
		[RED("replHighLevelState")] 
		public gameNetAIState ReplHighLevelState
		{
			get => GetProperty(ref _replHighLevelState);
			set => SetProperty(ref _replHighLevelState, value);
		}

		[Ordinal(3)] 
		[RED("replUpperBodyState")] 
		public gameNetAIState ReplUpperBodyState
		{
			get => GetProperty(ref _replUpperBodyState);
			set => SetProperty(ref _replUpperBodyState, value);
		}

		[Ordinal(4)] 
		[RED("replStanceState")] 
		public gameNetAIState ReplStanceState
		{
			get => GetProperty(ref _replStanceState);
			set => SetProperty(ref _replStanceState, value);
		}

		[Ordinal(5)] 
		[RED("replHitReactionModeState")] 
		public gameNetAIState ReplHitReactionModeState
		{
			get => GetProperty(ref _replHitReactionModeState);
			set => SetProperty(ref _replHitReactionModeState, value);
		}

		[Ordinal(6)] 
		[RED("replBehaviorState")] 
		public gameNetAIState ReplBehaviorState
		{
			get => GetProperty(ref _replBehaviorState);
			set => SetProperty(ref _replBehaviorState, value);
		}

		[Ordinal(7)] 
		[RED("replPhaseState")] 
		public gameNetAIState ReplPhaseState
		{
			get => GetProperty(ref _replPhaseState);
			set => SetProperty(ref _replPhaseState, value);
		}

		[Ordinal(8)] 
		[RED("replDefenseMode")] 
		public gameNetAIState ReplDefenseMode
		{
			get => GetProperty(ref _replDefenseMode);
			set => SetProperty(ref _replDefenseMode, value);
		}

		[Ordinal(9)] 
		[RED("replLocomotionMode")] 
		public gameNetAIState ReplLocomotionMode
		{
			get => GetProperty(ref _replLocomotionMode);
			set => SetProperty(ref _replLocomotionMode, value);
		}

		public gameAINetStateComponentReplicatedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

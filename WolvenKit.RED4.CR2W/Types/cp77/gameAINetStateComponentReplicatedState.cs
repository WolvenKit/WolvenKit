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
			get
			{
				if (_replHighLevelState == null)
				{
					_replHighLevelState = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replHighLevelState", cr2w, this);
				}
				return _replHighLevelState;
			}
			set
			{
				if (_replHighLevelState == value)
				{
					return;
				}
				_replHighLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("replUpperBodyState")] 
		public gameNetAIState ReplUpperBodyState
		{
			get
			{
				if (_replUpperBodyState == null)
				{
					_replUpperBodyState = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replUpperBodyState", cr2w, this);
				}
				return _replUpperBodyState;
			}
			set
			{
				if (_replUpperBodyState == value)
				{
					return;
				}
				_replUpperBodyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("replStanceState")] 
		public gameNetAIState ReplStanceState
		{
			get
			{
				if (_replStanceState == null)
				{
					_replStanceState = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replStanceState", cr2w, this);
				}
				return _replStanceState;
			}
			set
			{
				if (_replStanceState == value)
				{
					return;
				}
				_replStanceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("replHitReactionModeState")] 
		public gameNetAIState ReplHitReactionModeState
		{
			get
			{
				if (_replHitReactionModeState == null)
				{
					_replHitReactionModeState = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replHitReactionModeState", cr2w, this);
				}
				return _replHitReactionModeState;
			}
			set
			{
				if (_replHitReactionModeState == value)
				{
					return;
				}
				_replHitReactionModeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("replBehaviorState")] 
		public gameNetAIState ReplBehaviorState
		{
			get
			{
				if (_replBehaviorState == null)
				{
					_replBehaviorState = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replBehaviorState", cr2w, this);
				}
				return _replBehaviorState;
			}
			set
			{
				if (_replBehaviorState == value)
				{
					return;
				}
				_replBehaviorState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("replPhaseState")] 
		public gameNetAIState ReplPhaseState
		{
			get
			{
				if (_replPhaseState == null)
				{
					_replPhaseState = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replPhaseState", cr2w, this);
				}
				return _replPhaseState;
			}
			set
			{
				if (_replPhaseState == value)
				{
					return;
				}
				_replPhaseState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("replDefenseMode")] 
		public gameNetAIState ReplDefenseMode
		{
			get
			{
				if (_replDefenseMode == null)
				{
					_replDefenseMode = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replDefenseMode", cr2w, this);
				}
				return _replDefenseMode;
			}
			set
			{
				if (_replDefenseMode == value)
				{
					return;
				}
				_replDefenseMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("replLocomotionMode")] 
		public gameNetAIState ReplLocomotionMode
		{
			get
			{
				if (_replLocomotionMode == null)
				{
					_replLocomotionMode = (gameNetAIState) CR2WTypeManager.Create("gameNetAIState", "replLocomotionMode", cr2w, this);
				}
				return _replLocomotionMode;
			}
			set
			{
				if (_replLocomotionMode == value)
				{
					return;
				}
				_replLocomotionMode = value;
				PropertySet(this);
			}
		}

		public gameAINetStateComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

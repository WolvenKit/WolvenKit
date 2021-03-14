using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeController : IScriptable
	{
		private PlayerVisionModeControllerRefreshPolicy _gameplayActiveFlagsRefreshPolicy;
		private PlayerVisionModeControllerBBIds _blackboardIds;
		private PlayerVisionModeControllerBBValuesIds _blackboardValuesIds;
		private PlayerVisionModeControllerBlackboardListenersFunctions _blackboardListenersFunctions;
		private PlayerVisionModeControllerBBListeners _blackboardListeners;
		private PlayerVisionModeControllerActiveFlags _gameplayActiveFlags;
		private PlayerVisionModeControllerInputActionsNames _inputActionsNames;
		private PlayerVisionModeControllerInputListeners _inputListeners;
		private PlayerVisionModeControllerInputActiveFlags _inputActiveFlags;
		private PlayerVisionModeControllerOtherVars _otherVars;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("gameplayActiveFlagsRefreshPolicy")] 
		public PlayerVisionModeControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy
		{
			get
			{
				if (_gameplayActiveFlagsRefreshPolicy == null)
				{
					_gameplayActiveFlagsRefreshPolicy = (PlayerVisionModeControllerRefreshPolicy) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicy", "gameplayActiveFlagsRefreshPolicy", cr2w, this);
				}
				return _gameplayActiveFlagsRefreshPolicy;
			}
			set
			{
				if (_gameplayActiveFlagsRefreshPolicy == value)
				{
					return;
				}
				_gameplayActiveFlagsRefreshPolicy = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blackboardIds")] 
		public PlayerVisionModeControllerBBIds BlackboardIds
		{
			get
			{
				if (_blackboardIds == null)
				{
					_blackboardIds = (PlayerVisionModeControllerBBIds) CR2WTypeManager.Create("PlayerVisionModeControllerBBIds", "blackboardIds", cr2w, this);
				}
				return _blackboardIds;
			}
			set
			{
				if (_blackboardIds == value)
				{
					return;
				}
				_blackboardIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blackboardValuesIds")] 
		public PlayerVisionModeControllerBBValuesIds BlackboardValuesIds
		{
			get
			{
				if (_blackboardValuesIds == null)
				{
					_blackboardValuesIds = (PlayerVisionModeControllerBBValuesIds) CR2WTypeManager.Create("PlayerVisionModeControllerBBValuesIds", "blackboardValuesIds", cr2w, this);
				}
				return _blackboardValuesIds;
			}
			set
			{
				if (_blackboardValuesIds == value)
				{
					return;
				}
				_blackboardValuesIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blackboardListenersFunctions")] 
		public PlayerVisionModeControllerBlackboardListenersFunctions BlackboardListenersFunctions
		{
			get
			{
				if (_blackboardListenersFunctions == null)
				{
					_blackboardListenersFunctions = (PlayerVisionModeControllerBlackboardListenersFunctions) CR2WTypeManager.Create("PlayerVisionModeControllerBlackboardListenersFunctions", "blackboardListenersFunctions", cr2w, this);
				}
				return _blackboardListenersFunctions;
			}
			set
			{
				if (_blackboardListenersFunctions == value)
				{
					return;
				}
				_blackboardListenersFunctions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blackboardListeners")] 
		public PlayerVisionModeControllerBBListeners BlackboardListeners
		{
			get
			{
				if (_blackboardListeners == null)
				{
					_blackboardListeners = (PlayerVisionModeControllerBBListeners) CR2WTypeManager.Create("PlayerVisionModeControllerBBListeners", "blackboardListeners", cr2w, this);
				}
				return _blackboardListeners;
			}
			set
			{
				if (_blackboardListeners == value)
				{
					return;
				}
				_blackboardListeners = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gameplayActiveFlags")] 
		public PlayerVisionModeControllerActiveFlags GameplayActiveFlags
		{
			get
			{
				if (_gameplayActiveFlags == null)
				{
					_gameplayActiveFlags = (PlayerVisionModeControllerActiveFlags) CR2WTypeManager.Create("PlayerVisionModeControllerActiveFlags", "gameplayActiveFlags", cr2w, this);
				}
				return _gameplayActiveFlags;
			}
			set
			{
				if (_gameplayActiveFlags == value)
				{
					return;
				}
				_gameplayActiveFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("inputActionsNames")] 
		public PlayerVisionModeControllerInputActionsNames InputActionsNames
		{
			get
			{
				if (_inputActionsNames == null)
				{
					_inputActionsNames = (PlayerVisionModeControllerInputActionsNames) CR2WTypeManager.Create("PlayerVisionModeControllerInputActionsNames", "inputActionsNames", cr2w, this);
				}
				return _inputActionsNames;
			}
			set
			{
				if (_inputActionsNames == value)
				{
					return;
				}
				_inputActionsNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inputListeners")] 
		public PlayerVisionModeControllerInputListeners InputListeners
		{
			get
			{
				if (_inputListeners == null)
				{
					_inputListeners = (PlayerVisionModeControllerInputListeners) CR2WTypeManager.Create("PlayerVisionModeControllerInputListeners", "inputListeners", cr2w, this);
				}
				return _inputListeners;
			}
			set
			{
				if (_inputListeners == value)
				{
					return;
				}
				_inputListeners = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inputActiveFlags")] 
		public PlayerVisionModeControllerInputActiveFlags InputActiveFlags
		{
			get
			{
				if (_inputActiveFlags == null)
				{
					_inputActiveFlags = (PlayerVisionModeControllerInputActiveFlags) CR2WTypeManager.Create("PlayerVisionModeControllerInputActiveFlags", "inputActiveFlags", cr2w, this);
				}
				return _inputActiveFlags;
			}
			set
			{
				if (_inputActiveFlags == value)
				{
					return;
				}
				_inputActiveFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("otherVars")] 
		public PlayerVisionModeControllerOtherVars OtherVars
		{
			get
			{
				if (_otherVars == null)
				{
					_otherVars = (PlayerVisionModeControllerOtherVars) CR2WTypeManager.Create("PlayerVisionModeControllerOtherVars", "otherVars", cr2w, this);
				}
				return _otherVars;
			}
			set
			{
				if (_otherVars == value)
				{
					return;
				}
				_otherVars = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public PlayerVisionModeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

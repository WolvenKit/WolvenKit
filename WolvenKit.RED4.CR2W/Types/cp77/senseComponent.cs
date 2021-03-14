using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseComponent : entIPlacedComponent
	{
		private CBool _enableBeingDetectable;
		private CHandle<senseVisibleObject> _visibleObject;
		private CHandle<senseSensorObject> _sensorObject;
		private CBool _isEnabled;
		private CUInt32 _highLevelCb;
		private CUInt32 _reactionCb;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private TweakDBID _mainPreset;
		private TweakDBID _secondaryPreset;
		private CHandle<gameIBlackboard> _puppetBlackboard;
		private CUInt32 _playerTakedownStateCallbackID;
		private CUInt32 _playerUpperBodyStateCallbackID;
		private CUInt32 _playerCarryingStateCallbackID;
		private wCHandle<PlayerPuppet> _playerInPerception;

		[Ordinal(5)] 
		[RED("enableBeingDetectable")] 
		public CBool EnableBeingDetectable
		{
			get
			{
				if (_enableBeingDetectable == null)
				{
					_enableBeingDetectable = (CBool) CR2WTypeManager.Create("Bool", "enableBeingDetectable", cr2w, this);
				}
				return _enableBeingDetectable;
			}
			set
			{
				if (_enableBeingDetectable == value)
				{
					return;
				}
				_enableBeingDetectable = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get
			{
				if (_visibleObject == null)
				{
					_visibleObject = (CHandle<senseVisibleObject>) CR2WTypeManager.Create("handle:senseVisibleObject", "visibleObject", cr2w, this);
				}
				return _visibleObject;
			}
			set
			{
				if (_visibleObject == value)
				{
					return;
				}
				_visibleObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get
			{
				if (_sensorObject == null)
				{
					_sensorObject = (CHandle<senseSensorObject>) CR2WTypeManager.Create("handle:senseSensorObject", "sensorObject", cr2w, this);
				}
				return _sensorObject;
			}
			set
			{
				if (_sensorObject == value)
				{
					return;
				}
				_sensorObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("highLevelCb")] 
		public CUInt32 HighLevelCb
		{
			get
			{
				if (_highLevelCb == null)
				{
					_highLevelCb = (CUInt32) CR2WTypeManager.Create("Uint32", "highLevelCb", cr2w, this);
				}
				return _highLevelCb;
			}
			set
			{
				if (_highLevelCb == value)
				{
					return;
				}
				_highLevelCb = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("reactionCb")] 
		public CUInt32 ReactionCb
		{
			get
			{
				if (_reactionCb == null)
				{
					_reactionCb = (CUInt32) CR2WTypeManager.Create("Uint32", "reactionCb", cr2w, this);
				}
				return _reactionCb;
			}
			set
			{
				if (_reactionCb == value)
				{
					return;
				}
				_reactionCb = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("mainPreset")] 
		public TweakDBID MainPreset
		{
			get
			{
				if (_mainPreset == null)
				{
					_mainPreset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mainPreset", cr2w, this);
				}
				return _mainPreset;
			}
			set
			{
				if (_mainPreset == value)
				{
					return;
				}
				_mainPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("secondaryPreset")] 
		public TweakDBID SecondaryPreset
		{
			get
			{
				if (_secondaryPreset == null)
				{
					_secondaryPreset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "secondaryPreset", cr2w, this);
				}
				return _secondaryPreset;
			}
			set
			{
				if (_secondaryPreset == value)
				{
					return;
				}
				_secondaryPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("puppetBlackboard")] 
		public CHandle<gameIBlackboard> PuppetBlackboard
		{
			get
			{
				if (_puppetBlackboard == null)
				{
					_puppetBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "puppetBlackboard", cr2w, this);
				}
				return _puppetBlackboard;
			}
			set
			{
				if (_puppetBlackboard == value)
				{
					return;
				}
				_puppetBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("playerTakedownStateCallbackID")] 
		public CUInt32 PlayerTakedownStateCallbackID
		{
			get
			{
				if (_playerTakedownStateCallbackID == null)
				{
					_playerTakedownStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerTakedownStateCallbackID", cr2w, this);
				}
				return _playerTakedownStateCallbackID;
			}
			set
			{
				if (_playerTakedownStateCallbackID == value)
				{
					return;
				}
				_playerTakedownStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("playerUpperBodyStateCallbackID")] 
		public CUInt32 PlayerUpperBodyStateCallbackID
		{
			get
			{
				if (_playerUpperBodyStateCallbackID == null)
				{
					_playerUpperBodyStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerUpperBodyStateCallbackID", cr2w, this);
				}
				return _playerUpperBodyStateCallbackID;
			}
			set
			{
				if (_playerUpperBodyStateCallbackID == value)
				{
					return;
				}
				_playerUpperBodyStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("playerCarryingStateCallbackID")] 
		public CUInt32 PlayerCarryingStateCallbackID
		{
			get
			{
				if (_playerCarryingStateCallbackID == null)
				{
					_playerCarryingStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerCarryingStateCallbackID", cr2w, this);
				}
				return _playerCarryingStateCallbackID;
			}
			set
			{
				if (_playerCarryingStateCallbackID == value)
				{
					return;
				}
				_playerCarryingStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playerInPerception")] 
		public wCHandle<PlayerPuppet> PlayerInPerception
		{
			get
			{
				if (_playerInPerception == null)
				{
					_playerInPerception = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "playerInPerception", cr2w, this);
				}
				return _playerInPerception;
			}
			set
			{
				if (_playerInPerception == value)
				{
					return;
				}
				_playerInPerception = value;
				PropertySet(this);
			}
		}

		public senseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

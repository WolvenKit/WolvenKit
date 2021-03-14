using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponent : AICAgent
	{
		private TweakDBID _movementParamsRecord;
		private CHandle<gameIBlackboard> _shootingBlackboard;
		private CHandle<gameIBlackboard> _gadgetBlackboard;
		private CHandle<gameIBlackboard> _coverBlackboard;
		private CHandle<gameIBlackboard> _actionBlackboard;
		private CHandle<gameIBlackboard> _patrolBlackboard;
		private CHandle<gameIBlackboard> _alertedPatrolBlackboard;
		private CUInt32 _friendlyFireCheckID;
		private CHandle<gameIFriendlyFireSystem> _ffs;
		private CUInt32 _loSFinderCheckID;
		private CHandle<gameLoSIFinderSystem> _loSFinderSystem;
		private wCHandle<senseVisibleObject> _loSFinderVisibleObject;
		private CHandle<ActionAnimationScriptProxy> _actionAnimationScriptProxy;
		private gameDelayID _lastOwnerBlockedAttackEventID;
		private gameDelayID _lastOwnerParriedAttackEventID;
		private gameDelayID _lastOwnerDodgedAttackEventID;
		private wCHandle<gameObject> _grenadeThrowQueryTarget;
		private CInt32 _grenadeThrowQueryId;
		private AIbehaviorScriptExecutionContext _scriptContext;
		private CBool _scriptContextInitialized;
		private CUInt32 _highLevelCb;
		private AIbehaviorUniqueActiveCommandList _activeCommands;

		[Ordinal(4)] 
		[RED("movementParamsRecord")] 
		public TweakDBID MovementParamsRecord
		{
			get
			{
				if (_movementParamsRecord == null)
				{
					_movementParamsRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "movementParamsRecord", cr2w, this);
				}
				return _movementParamsRecord;
			}
			set
			{
				if (_movementParamsRecord == value)
				{
					return;
				}
				_movementParamsRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("shootingBlackboard")] 
		public CHandle<gameIBlackboard> ShootingBlackboard
		{
			get
			{
				if (_shootingBlackboard == null)
				{
					_shootingBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "shootingBlackboard", cr2w, this);
				}
				return _shootingBlackboard;
			}
			set
			{
				if (_shootingBlackboard == value)
				{
					return;
				}
				_shootingBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gadgetBlackboard")] 
		public CHandle<gameIBlackboard> GadgetBlackboard
		{
			get
			{
				if (_gadgetBlackboard == null)
				{
					_gadgetBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "gadgetBlackboard", cr2w, this);
				}
				return _gadgetBlackboard;
			}
			set
			{
				if (_gadgetBlackboard == value)
				{
					return;
				}
				_gadgetBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("coverBlackboard")] 
		public CHandle<gameIBlackboard> CoverBlackboard
		{
			get
			{
				if (_coverBlackboard == null)
				{
					_coverBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "coverBlackboard", cr2w, this);
				}
				return _coverBlackboard;
			}
			set
			{
				if (_coverBlackboard == value)
				{
					return;
				}
				_coverBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("actionBlackboard")] 
		public CHandle<gameIBlackboard> ActionBlackboard
		{
			get
			{
				if (_actionBlackboard == null)
				{
					_actionBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "actionBlackboard", cr2w, this);
				}
				return _actionBlackboard;
			}
			set
			{
				if (_actionBlackboard == value)
				{
					return;
				}
				_actionBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("patrolBlackboard")] 
		public CHandle<gameIBlackboard> PatrolBlackboard
		{
			get
			{
				if (_patrolBlackboard == null)
				{
					_patrolBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "patrolBlackboard", cr2w, this);
				}
				return _patrolBlackboard;
			}
			set
			{
				if (_patrolBlackboard == value)
				{
					return;
				}
				_patrolBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("alertedPatrolBlackboard")] 
		public CHandle<gameIBlackboard> AlertedPatrolBlackboard
		{
			get
			{
				if (_alertedPatrolBlackboard == null)
				{
					_alertedPatrolBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "alertedPatrolBlackboard", cr2w, this);
				}
				return _alertedPatrolBlackboard;
			}
			set
			{
				if (_alertedPatrolBlackboard == value)
				{
					return;
				}
				_alertedPatrolBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("friendlyFireCheckID")] 
		public CUInt32 FriendlyFireCheckID
		{
			get
			{
				if (_friendlyFireCheckID == null)
				{
					_friendlyFireCheckID = (CUInt32) CR2WTypeManager.Create("Uint32", "friendlyFireCheckID", cr2w, this);
				}
				return _friendlyFireCheckID;
			}
			set
			{
				if (_friendlyFireCheckID == value)
				{
					return;
				}
				_friendlyFireCheckID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ffs")] 
		public CHandle<gameIFriendlyFireSystem> Ffs
		{
			get
			{
				if (_ffs == null)
				{
					_ffs = (CHandle<gameIFriendlyFireSystem>) CR2WTypeManager.Create("handle:gameIFriendlyFireSystem", "ffs", cr2w, this);
				}
				return _ffs;
			}
			set
			{
				if (_ffs == value)
				{
					return;
				}
				_ffs = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("LoSFinderCheckID")] 
		public CUInt32 LoSFinderCheckID
		{
			get
			{
				if (_loSFinderCheckID == null)
				{
					_loSFinderCheckID = (CUInt32) CR2WTypeManager.Create("Uint32", "LoSFinderCheckID", cr2w, this);
				}
				return _loSFinderCheckID;
			}
			set
			{
				if (_loSFinderCheckID == value)
				{
					return;
				}
				_loSFinderCheckID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("loSFinderSystem")] 
		public CHandle<gameLoSIFinderSystem> LoSFinderSystem
		{
			get
			{
				if (_loSFinderSystem == null)
				{
					_loSFinderSystem = (CHandle<gameLoSIFinderSystem>) CR2WTypeManager.Create("handle:gameLoSIFinderSystem", "loSFinderSystem", cr2w, this);
				}
				return _loSFinderSystem;
			}
			set
			{
				if (_loSFinderSystem == value)
				{
					return;
				}
				_loSFinderSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("LoSFinderVisibleObject")] 
		public wCHandle<senseVisibleObject> LoSFinderVisibleObject
		{
			get
			{
				if (_loSFinderVisibleObject == null)
				{
					_loSFinderVisibleObject = (wCHandle<senseVisibleObject>) CR2WTypeManager.Create("whandle:senseVisibleObject", "LoSFinderVisibleObject", cr2w, this);
				}
				return _loSFinderVisibleObject;
			}
			set
			{
				if (_loSFinderVisibleObject == value)
				{
					return;
				}
				_loSFinderVisibleObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("actionAnimationScriptProxy")] 
		public CHandle<ActionAnimationScriptProxy> ActionAnimationScriptProxy
		{
			get
			{
				if (_actionAnimationScriptProxy == null)
				{
					_actionAnimationScriptProxy = (CHandle<ActionAnimationScriptProxy>) CR2WTypeManager.Create("handle:ActionAnimationScriptProxy", "actionAnimationScriptProxy", cr2w, this);
				}
				return _actionAnimationScriptProxy;
			}
			set
			{
				if (_actionAnimationScriptProxy == value)
				{
					return;
				}
				_actionAnimationScriptProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lastOwnerBlockedAttackEventID")] 
		public gameDelayID LastOwnerBlockedAttackEventID
		{
			get
			{
				if (_lastOwnerBlockedAttackEventID == null)
				{
					_lastOwnerBlockedAttackEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "lastOwnerBlockedAttackEventID", cr2w, this);
				}
				return _lastOwnerBlockedAttackEventID;
			}
			set
			{
				if (_lastOwnerBlockedAttackEventID == value)
				{
					return;
				}
				_lastOwnerBlockedAttackEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("lastOwnerParriedAttackEventID")] 
		public gameDelayID LastOwnerParriedAttackEventID
		{
			get
			{
				if (_lastOwnerParriedAttackEventID == null)
				{
					_lastOwnerParriedAttackEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "lastOwnerParriedAttackEventID", cr2w, this);
				}
				return _lastOwnerParriedAttackEventID;
			}
			set
			{
				if (_lastOwnerParriedAttackEventID == value)
				{
					return;
				}
				_lastOwnerParriedAttackEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lastOwnerDodgedAttackEventID")] 
		public gameDelayID LastOwnerDodgedAttackEventID
		{
			get
			{
				if (_lastOwnerDodgedAttackEventID == null)
				{
					_lastOwnerDodgedAttackEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "lastOwnerDodgedAttackEventID", cr2w, this);
				}
				return _lastOwnerDodgedAttackEventID;
			}
			set
			{
				if (_lastOwnerDodgedAttackEventID == value)
				{
					return;
				}
				_lastOwnerDodgedAttackEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("grenadeThrowQueryTarget")] 
		public wCHandle<gameObject> GrenadeThrowQueryTarget
		{
			get
			{
				if (_grenadeThrowQueryTarget == null)
				{
					_grenadeThrowQueryTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "grenadeThrowQueryTarget", cr2w, this);
				}
				return _grenadeThrowQueryTarget;
			}
			set
			{
				if (_grenadeThrowQueryTarget == value)
				{
					return;
				}
				_grenadeThrowQueryTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("grenadeThrowQueryId")] 
		public CInt32 GrenadeThrowQueryId
		{
			get
			{
				if (_grenadeThrowQueryId == null)
				{
					_grenadeThrowQueryId = (CInt32) CR2WTypeManager.Create("Int32", "grenadeThrowQueryId", cr2w, this);
				}
				return _grenadeThrowQueryId;
			}
			set
			{
				if (_grenadeThrowQueryId == value)
				{
					return;
				}
				_grenadeThrowQueryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("scriptContext")] 
		public AIbehaviorScriptExecutionContext ScriptContext
		{
			get
			{
				if (_scriptContext == null)
				{
					_scriptContext = (AIbehaviorScriptExecutionContext) CR2WTypeManager.Create("AIbehaviorScriptExecutionContext", "scriptContext", cr2w, this);
				}
				return _scriptContext;
			}
			set
			{
				if (_scriptContext == value)
				{
					return;
				}
				_scriptContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("scriptContextInitialized")] 
		public CBool ScriptContextInitialized
		{
			get
			{
				if (_scriptContextInitialized == null)
				{
					_scriptContextInitialized = (CBool) CR2WTypeManager.Create("Bool", "scriptContextInitialized", cr2w, this);
				}
				return _scriptContextInitialized;
			}
			set
			{
				if (_scriptContextInitialized == value)
				{
					return;
				}
				_scriptContextInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("activeCommands")] 
		public AIbehaviorUniqueActiveCommandList ActiveCommands
		{
			get
			{
				if (_activeCommands == null)
				{
					_activeCommands = (AIbehaviorUniqueActiveCommandList) CR2WTypeManager.Create("AIbehaviorUniqueActiveCommandList", "activeCommands", cr2w, this);
				}
				return _activeCommands;
			}
			set
			{
				if (_activeCommands == value)
				{
					return;
				}
				_activeCommands = value;
				PropertySet(this);
			}
		}

		public AIHumanComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

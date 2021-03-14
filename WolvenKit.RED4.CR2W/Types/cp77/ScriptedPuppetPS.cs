using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppetPS : gamePuppetPS
	{
		private wCHandle<PuppetDeviceLinkPS> _deviceLink;
		private CHandle<CooldownStorage> _cooldownStorage;
		private CEnum<EBOOL> _isInitialized;
		private CBool _wasAttached;
		private CBool _wasRevealedInNetworkPing;
		private CInt32 _numberActions;
		private CBool _wasQuickHackAttempt;
		private CBool _hasDirectInteractionChoicesActive;
		private CBool _wasIncapacitated;
		private CBool _isBreached;
		private CBool _isDead;
		private CBool _isIncapacitated;
		private CBool _isAndroidTurnedOff;
		private SecuritySystemData _securitySystemData;
		private CArray<CEnum<gamedeviceRequestType>> _activeContexts;
		private CName _lastInteractionLayerTag;
		private CBool _quickHacksExposed;
		private CUInt32 _currentCooldownID;
		private TweakDBID _reactionPresetID;
		private CBool _isDefeatMechanicActive;
		private gameItemID _leftHandLoadout;
		private gameItemID _rightHandLoadout;

		[Ordinal(4)] 
		[RED("deviceLink")] 
		public wCHandle<PuppetDeviceLinkPS> DeviceLink
		{
			get
			{
				if (_deviceLink == null)
				{
					_deviceLink = (wCHandle<PuppetDeviceLinkPS>) CR2WTypeManager.Create("whandle:PuppetDeviceLinkPS", "deviceLink", cr2w, this);
				}
				return _deviceLink;
			}
			set
			{
				if (_deviceLink == value)
				{
					return;
				}
				_deviceLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cooldownStorage")] 
		public CHandle<CooldownStorage> CooldownStorage
		{
			get
			{
				if (_cooldownStorage == null)
				{
					_cooldownStorage = (CHandle<CooldownStorage>) CR2WTypeManager.Create("handle:CooldownStorage", "cooldownStorage", cr2w, this);
				}
				return _cooldownStorage;
			}
			set
			{
				if (_cooldownStorage == value)
				{
					return;
				}
				_cooldownStorage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isInitialized")] 
		public CEnum<EBOOL> IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CEnum<EBOOL>) CR2WTypeManager.Create("EBOOL", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("wasAttached")] 
		public CBool WasAttached
		{
			get
			{
				if (_wasAttached == null)
				{
					_wasAttached = (CBool) CR2WTypeManager.Create("Bool", "wasAttached", cr2w, this);
				}
				return _wasAttached;
			}
			set
			{
				if (_wasAttached == value)
				{
					return;
				}
				_wasAttached = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get
			{
				if (_wasRevealedInNetworkPing == null)
				{
					_wasRevealedInNetworkPing = (CBool) CR2WTypeManager.Create("Bool", "wasRevealedInNetworkPing", cr2w, this);
				}
				return _wasRevealedInNetworkPing;
			}
			set
			{
				if (_wasRevealedInNetworkPing == value)
				{
					return;
				}
				_wasRevealedInNetworkPing = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numberActions")] 
		public CInt32 NumberActions
		{
			get
			{
				if (_numberActions == null)
				{
					_numberActions = (CInt32) CR2WTypeManager.Create("Int32", "numberActions", cr2w, this);
				}
				return _numberActions;
			}
			set
			{
				if (_numberActions == value)
				{
					return;
				}
				_numberActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get
			{
				if (_wasQuickHackAttempt == null)
				{
					_wasQuickHackAttempt = (CBool) CR2WTypeManager.Create("Bool", "wasQuickHackAttempt", cr2w, this);
				}
				return _wasQuickHackAttempt;
			}
			set
			{
				if (_wasQuickHackAttempt == value)
				{
					return;
				}
				_wasQuickHackAttempt = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hasDirectInteractionChoicesActive")] 
		public CBool HasDirectInteractionChoicesActive
		{
			get
			{
				if (_hasDirectInteractionChoicesActive == null)
				{
					_hasDirectInteractionChoicesActive = (CBool) CR2WTypeManager.Create("Bool", "hasDirectInteractionChoicesActive", cr2w, this);
				}
				return _hasDirectInteractionChoicesActive;
			}
			set
			{
				if (_hasDirectInteractionChoicesActive == value)
				{
					return;
				}
				_hasDirectInteractionChoicesActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("wasIncapacitated")] 
		public CBool WasIncapacitated
		{
			get
			{
				if (_wasIncapacitated == null)
				{
					_wasIncapacitated = (CBool) CR2WTypeManager.Create("Bool", "wasIncapacitated", cr2w, this);
				}
				return _wasIncapacitated;
			}
			set
			{
				if (_wasIncapacitated == value)
				{
					return;
				}
				_wasIncapacitated = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get
			{
				if (_isBreached == null)
				{
					_isBreached = (CBool) CR2WTypeManager.Create("Bool", "isBreached", cr2w, this);
				}
				return _isBreached;
			}
			set
			{
				if (_isBreached == value)
				{
					return;
				}
				_isBreached = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get
			{
				if (_isDead == null)
				{
					_isDead = (CBool) CR2WTypeManager.Create("Bool", "isDead", cr2w, this);
				}
				return _isDead;
			}
			set
			{
				if (_isDead == value)
				{
					return;
				}
				_isDead = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isIncapacitated")] 
		public CBool IsIncapacitated
		{
			get
			{
				if (_isIncapacitated == null)
				{
					_isIncapacitated = (CBool) CR2WTypeManager.Create("Bool", "isIncapacitated", cr2w, this);
				}
				return _isIncapacitated;
			}
			set
			{
				if (_isIncapacitated == value)
				{
					return;
				}
				_isIncapacitated = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isAndroidTurnedOff")] 
		public CBool IsAndroidTurnedOff
		{
			get
			{
				if (_isAndroidTurnedOff == null)
				{
					_isAndroidTurnedOff = (CBool) CR2WTypeManager.Create("Bool", "isAndroidTurnedOff", cr2w, this);
				}
				return _isAndroidTurnedOff;
			}
			set
			{
				if (_isAndroidTurnedOff == value)
				{
					return;
				}
				_isAndroidTurnedOff = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get
			{
				if (_securitySystemData == null)
				{
					_securitySystemData = (SecuritySystemData) CR2WTypeManager.Create("SecuritySystemData", "securitySystemData", cr2w, this);
				}
				return _securitySystemData;
			}
			set
			{
				if (_securitySystemData == value)
				{
					return;
				}
				_securitySystemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get
			{
				if (_activeContexts == null)
				{
					_activeContexts = (CArray<CEnum<gamedeviceRequestType>>) CR2WTypeManager.Create("array:gamedeviceRequestType", "activeContexts", cr2w, this);
				}
				return _activeContexts;
			}
			set
			{
				if (_activeContexts == value)
				{
					return;
				}
				_activeContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lastInteractionLayerTag")] 
		public CName LastInteractionLayerTag
		{
			get
			{
				if (_lastInteractionLayerTag == null)
				{
					_lastInteractionLayerTag = (CName) CR2WTypeManager.Create("CName", "lastInteractionLayerTag", cr2w, this);
				}
				return _lastInteractionLayerTag;
			}
			set
			{
				if (_lastInteractionLayerTag == value)
				{
					return;
				}
				_lastInteractionLayerTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("quickHacksExposed")] 
		public CBool QuickHacksExposed
		{
			get
			{
				if (_quickHacksExposed == null)
				{
					_quickHacksExposed = (CBool) CR2WTypeManager.Create("Bool", "quickHacksExposed", cr2w, this);
				}
				return _quickHacksExposed;
			}
			set
			{
				if (_quickHacksExposed == value)
				{
					return;
				}
				_quickHacksExposed = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currentCooldownID")] 
		public CUInt32 CurrentCooldownID
		{
			get
			{
				if (_currentCooldownID == null)
				{
					_currentCooldownID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentCooldownID", cr2w, this);
				}
				return _currentCooldownID;
			}
			set
			{
				if (_currentCooldownID == value)
				{
					return;
				}
				_currentCooldownID = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("reactionPresetID")] 
		public TweakDBID ReactionPresetID
		{
			get
			{
				if (_reactionPresetID == null)
				{
					_reactionPresetID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "reactionPresetID", cr2w, this);
				}
				return _reactionPresetID;
			}
			set
			{
				if (_reactionPresetID == value)
				{
					return;
				}
				_reactionPresetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isDefeatMechanicActive")] 
		public CBool IsDefeatMechanicActive
		{
			get
			{
				if (_isDefeatMechanicActive == null)
				{
					_isDefeatMechanicActive = (CBool) CR2WTypeManager.Create("Bool", "isDefeatMechanicActive", cr2w, this);
				}
				return _isDefeatMechanicActive;
			}
			set
			{
				if (_isDefeatMechanicActive == value)
				{
					return;
				}
				_isDefeatMechanicActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("leftHandLoadout")] 
		public gameItemID LeftHandLoadout
		{
			get
			{
				if (_leftHandLoadout == null)
				{
					_leftHandLoadout = (gameItemID) CR2WTypeManager.Create("gameItemID", "leftHandLoadout", cr2w, this);
				}
				return _leftHandLoadout;
			}
			set
			{
				if (_leftHandLoadout == value)
				{
					return;
				}
				_leftHandLoadout = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("rightHandLoadout")] 
		public gameItemID RightHandLoadout
		{
			get
			{
				if (_rightHandLoadout == null)
				{
					_rightHandLoadout = (gameItemID) CR2WTypeManager.Create("gameItemID", "rightHandLoadout", cr2w, this);
				}
				return _rightHandLoadout;
			}
			set
			{
				if (_rightHandLoadout == value)
				{
					return;
				}
				_rightHandLoadout = value;
				PropertySet(this);
			}
		}

		public ScriptedPuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

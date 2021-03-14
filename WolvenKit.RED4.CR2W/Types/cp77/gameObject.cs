using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameObject : entGameEntity
	{
		private CHandle<gamePersistentState> _persistentState;
		private gamePlayerSocket _playerSocket;
		private redTagList _tags;
		private LocalizationString _displayName;
		private LocalizationString _displayDescription;
		private CName _audioResourceName;
		private CFloat _visibilityCheckDistance;
		private CBool _forceRegisterInHudManager;
		private CArray<CHandle<GameObjectListener>> _prereqListeners;
		private CArray<CHandle<StatusEffectTriggerListener>> _statusEffectListeners;
		private CHandle<OutlineRequestManager> _outlineRequestsManager;
		private CInt32 _outlineFadeCounter;
		private CBool _fadeOutStarted;
		private CFloat _lastEngineTime;
		private CFloat _accumulatedTimePasssed;
		private CHandle<gameScanningComponent> _scanningComponent;
		private CHandle<gameVisionModeComponent> _visionComponent;
		private CBool _isHighlightedInFocusMode;
		private CHandle<gameStatusEffectComponent> _statusEffectComponent;
		private CHandle<OutlineRequest> _lastFrameGreen;
		private CHandle<OutlineRequest> _lastFrameRed;
		private CBool _markAsQuest;
		private CBool _e3HighlightHackStarted;
		private CBool _e3ObjectRevealed;
		private entEntityID _forceHighlightSource;
		private CHandle<WorkspotMapperComponent> _workspotMapper;
		private CHandle<StimBroadcasterComponent> _stimBroadcaster;
		private CHandle<entSlotComponent> _uiSlotComponent;
		private CHandle<SquadMemberBaseComponent> _squadMemberComponent;
		private CHandle<gameSourceShootComponent> _sourceShootComponent;
		private CHandle<gameTargetShootComponent> _targetShootComponent;
		private CArray<DamageHistoryEntry> _receivedDamageHistory;
		private CBool _forceDefeatReward;
		private CBool _killRewardDisabled;
		private CBool _willDieSoon;
		private CBool _isScannerDataDirty;
		private CBool _hasVisibilityForcedInAnimSystem;
		private CBool _isDead;

		[Ordinal(2)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get
			{
				if (_persistentState == null)
				{
					_persistentState = (CHandle<gamePersistentState>) CR2WTypeManager.Create("handle:gamePersistentState", "persistentState", cr2w, this);
				}
				return _persistentState;
			}
			set
			{
				if (_persistentState == value)
				{
					return;
				}
				_persistentState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerSocket")] 
		public gamePlayerSocket PlayerSocket
		{
			get
			{
				if (_playerSocket == null)
				{
					_playerSocket = (gamePlayerSocket) CR2WTypeManager.Create("gamePlayerSocket", "playerSocket", cr2w, this);
				}
				return _playerSocket;
			}
			set
			{
				if (_playerSocket == value)
				{
					return;
				}
				_playerSocket = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("displayName")] 
		public LocalizationString DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("displayDescription")] 
		public LocalizationString DisplayDescription
		{
			get
			{
				if (_displayDescription == null)
				{
					_displayDescription = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "displayDescription", cr2w, this);
				}
				return _displayDescription;
			}
			set
			{
				if (_displayDescription == value)
				{
					return;
				}
				_displayDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("audioResourceName")] 
		public CName AudioResourceName
		{
			get
			{
				if (_audioResourceName == null)
				{
					_audioResourceName = (CName) CR2WTypeManager.Create("CName", "audioResourceName", cr2w, this);
				}
				return _audioResourceName;
			}
			set
			{
				if (_audioResourceName == value)
				{
					return;
				}
				_audioResourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("visibilityCheckDistance")] 
		public CFloat VisibilityCheckDistance
		{
			get
			{
				if (_visibilityCheckDistance == null)
				{
					_visibilityCheckDistance = (CFloat) CR2WTypeManager.Create("Float", "visibilityCheckDistance", cr2w, this);
				}
				return _visibilityCheckDistance;
			}
			set
			{
				if (_visibilityCheckDistance == value)
				{
					return;
				}
				_visibilityCheckDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("forceRegisterInHudManager")] 
		public CBool ForceRegisterInHudManager
		{
			get
			{
				if (_forceRegisterInHudManager == null)
				{
					_forceRegisterInHudManager = (CBool) CR2WTypeManager.Create("Bool", "forceRegisterInHudManager", cr2w, this);
				}
				return _forceRegisterInHudManager;
			}
			set
			{
				if (_forceRegisterInHudManager == value)
				{
					return;
				}
				_forceRegisterInHudManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("prereqListeners")] 
		public CArray<CHandle<GameObjectListener>> PrereqListeners
		{
			get
			{
				if (_prereqListeners == null)
				{
					_prereqListeners = (CArray<CHandle<GameObjectListener>>) CR2WTypeManager.Create("array:handle:GameObjectListener", "prereqListeners", cr2w, this);
				}
				return _prereqListeners;
			}
			set
			{
				if (_prereqListeners == value)
				{
					return;
				}
				_prereqListeners = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("statusEffectListeners")] 
		public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners
		{
			get
			{
				if (_statusEffectListeners == null)
				{
					_statusEffectListeners = (CArray<CHandle<StatusEffectTriggerListener>>) CR2WTypeManager.Create("array:handle:StatusEffectTriggerListener", "statusEffectListeners", cr2w, this);
				}
				return _statusEffectListeners;
			}
			set
			{
				if (_statusEffectListeners == value)
				{
					return;
				}
				_statusEffectListeners = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("outlineRequestsManager")] 
		public CHandle<OutlineRequestManager> OutlineRequestsManager
		{
			get
			{
				if (_outlineRequestsManager == null)
				{
					_outlineRequestsManager = (CHandle<OutlineRequestManager>) CR2WTypeManager.Create("handle:OutlineRequestManager", "outlineRequestsManager", cr2w, this);
				}
				return _outlineRequestsManager;
			}
			set
			{
				if (_outlineRequestsManager == value)
				{
					return;
				}
				_outlineRequestsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("outlineFadeCounter")] 
		public CInt32 OutlineFadeCounter
		{
			get
			{
				if (_outlineFadeCounter == null)
				{
					_outlineFadeCounter = (CInt32) CR2WTypeManager.Create("Int32", "outlineFadeCounter", cr2w, this);
				}
				return _outlineFadeCounter;
			}
			set
			{
				if (_outlineFadeCounter == value)
				{
					return;
				}
				_outlineFadeCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fadeOutStarted")] 
		public CBool FadeOutStarted
		{
			get
			{
				if (_fadeOutStarted == null)
				{
					_fadeOutStarted = (CBool) CR2WTypeManager.Create("Bool", "fadeOutStarted", cr2w, this);
				}
				return _fadeOutStarted;
			}
			set
			{
				if (_fadeOutStarted == value)
				{
					return;
				}
				_fadeOutStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get
			{
				if (_lastEngineTime == null)
				{
					_lastEngineTime = (CFloat) CR2WTypeManager.Create("Float", "lastEngineTime", cr2w, this);
				}
				return _lastEngineTime;
			}
			set
			{
				if (_lastEngineTime == value)
				{
					return;
				}
				_lastEngineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("accumulatedTimePasssed")] 
		public CFloat AccumulatedTimePasssed
		{
			get
			{
				if (_accumulatedTimePasssed == null)
				{
					_accumulatedTimePasssed = (CFloat) CR2WTypeManager.Create("Float", "accumulatedTimePasssed", cr2w, this);
				}
				return _accumulatedTimePasssed;
			}
			set
			{
				if (_accumulatedTimePasssed == value)
				{
					return;
				}
				_accumulatedTimePasssed = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get
			{
				if (_scanningComponent == null)
				{
					_scanningComponent = (CHandle<gameScanningComponent>) CR2WTypeManager.Create("handle:gameScanningComponent", "scanningComponent", cr2w, this);
				}
				return _scanningComponent;
			}
			set
			{
				if (_scanningComponent == value)
				{
					return;
				}
				_scanningComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("visionComponent")] 
		public CHandle<gameVisionModeComponent> VisionComponent
		{
			get
			{
				if (_visionComponent == null)
				{
					_visionComponent = (CHandle<gameVisionModeComponent>) CR2WTypeManager.Create("handle:gameVisionModeComponent", "visionComponent", cr2w, this);
				}
				return _visionComponent;
			}
			set
			{
				if (_visionComponent == value)
				{
					return;
				}
				_visionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get
			{
				if (_isHighlightedInFocusMode == null)
				{
					_isHighlightedInFocusMode = (CBool) CR2WTypeManager.Create("Bool", "isHighlightedInFocusMode", cr2w, this);
				}
				return _isHighlightedInFocusMode;
			}
			set
			{
				if (_isHighlightedInFocusMode == value)
				{
					return;
				}
				_isHighlightedInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("statusEffectComponent")] 
		public CHandle<gameStatusEffectComponent> StatusEffectComponent
		{
			get
			{
				if (_statusEffectComponent == null)
				{
					_statusEffectComponent = (CHandle<gameStatusEffectComponent>) CR2WTypeManager.Create("handle:gameStatusEffectComponent", "statusEffectComponent", cr2w, this);
				}
				return _statusEffectComponent;
			}
			set
			{
				if (_statusEffectComponent == value)
				{
					return;
				}
				_statusEffectComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("lastFrameGreen")] 
		public CHandle<OutlineRequest> LastFrameGreen
		{
			get
			{
				if (_lastFrameGreen == null)
				{
					_lastFrameGreen = (CHandle<OutlineRequest>) CR2WTypeManager.Create("handle:OutlineRequest", "lastFrameGreen", cr2w, this);
				}
				return _lastFrameGreen;
			}
			set
			{
				if (_lastFrameGreen == value)
				{
					return;
				}
				_lastFrameGreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("lastFrameRed")] 
		public CHandle<OutlineRequest> LastFrameRed
		{
			get
			{
				if (_lastFrameRed == null)
				{
					_lastFrameRed = (CHandle<OutlineRequest>) CR2WTypeManager.Create("handle:OutlineRequest", "lastFrameRed", cr2w, this);
				}
				return _lastFrameRed;
			}
			set
			{
				if (_lastFrameRed == value)
				{
					return;
				}
				_lastFrameRed = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get
			{
				if (_markAsQuest == null)
				{
					_markAsQuest = (CBool) CR2WTypeManager.Create("Bool", "markAsQuest", cr2w, this);
				}
				return _markAsQuest;
			}
			set
			{
				if (_markAsQuest == value)
				{
					return;
				}
				_markAsQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("e3HighlightHackStarted")] 
		public CBool E3HighlightHackStarted
		{
			get
			{
				if (_e3HighlightHackStarted == null)
				{
					_e3HighlightHackStarted = (CBool) CR2WTypeManager.Create("Bool", "e3HighlightHackStarted", cr2w, this);
				}
				return _e3HighlightHackStarted;
			}
			set
			{
				if (_e3HighlightHackStarted == value)
				{
					return;
				}
				_e3HighlightHackStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("e3ObjectRevealed")] 
		public CBool E3ObjectRevealed
		{
			get
			{
				if (_e3ObjectRevealed == null)
				{
					_e3ObjectRevealed = (CBool) CR2WTypeManager.Create("Bool", "e3ObjectRevealed", cr2w, this);
				}
				return _e3ObjectRevealed;
			}
			set
			{
				if (_e3ObjectRevealed == value)
				{
					return;
				}
				_e3ObjectRevealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("forceHighlightSource")] 
		public entEntityID ForceHighlightSource
		{
			get
			{
				if (_forceHighlightSource == null)
				{
					_forceHighlightSource = (entEntityID) CR2WTypeManager.Create("entEntityID", "forceHighlightSource", cr2w, this);
				}
				return _forceHighlightSource;
			}
			set
			{
				if (_forceHighlightSource == value)
				{
					return;
				}
				_forceHighlightSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("workspotMapper")] 
		public CHandle<WorkspotMapperComponent> WorkspotMapper
		{
			get
			{
				if (_workspotMapper == null)
				{
					_workspotMapper = (CHandle<WorkspotMapperComponent>) CR2WTypeManager.Create("handle:WorkspotMapperComponent", "workspotMapper", cr2w, this);
				}
				return _workspotMapper;
			}
			set
			{
				if (_workspotMapper == value)
				{
					return;
				}
				_workspotMapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("stimBroadcaster")] 
		public CHandle<StimBroadcasterComponent> StimBroadcaster
		{
			get
			{
				if (_stimBroadcaster == null)
				{
					_stimBroadcaster = (CHandle<StimBroadcasterComponent>) CR2WTypeManager.Create("handle:StimBroadcasterComponent", "stimBroadcaster", cr2w, this);
				}
				return _stimBroadcaster;
			}
			set
			{
				if (_stimBroadcaster == value)
				{
					return;
				}
				_stimBroadcaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("uiSlotComponent")] 
		public CHandle<entSlotComponent> UiSlotComponent
		{
			get
			{
				if (_uiSlotComponent == null)
				{
					_uiSlotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "uiSlotComponent", cr2w, this);
				}
				return _uiSlotComponent;
			}
			set
			{
				if (_uiSlotComponent == value)
				{
					return;
				}
				_uiSlotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("squadMemberComponent")] 
		public CHandle<SquadMemberBaseComponent> SquadMemberComponent
		{
			get
			{
				if (_squadMemberComponent == null)
				{
					_squadMemberComponent = (CHandle<SquadMemberBaseComponent>) CR2WTypeManager.Create("handle:SquadMemberBaseComponent", "squadMemberComponent", cr2w, this);
				}
				return _squadMemberComponent;
			}
			set
			{
				if (_squadMemberComponent == value)
				{
					return;
				}
				_squadMemberComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("sourceShootComponent")] 
		public CHandle<gameSourceShootComponent> SourceShootComponent
		{
			get
			{
				if (_sourceShootComponent == null)
				{
					_sourceShootComponent = (CHandle<gameSourceShootComponent>) CR2WTypeManager.Create("handle:gameSourceShootComponent", "sourceShootComponent", cr2w, this);
				}
				return _sourceShootComponent;
			}
			set
			{
				if (_sourceShootComponent == value)
				{
					return;
				}
				_sourceShootComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("targetShootComponent")] 
		public CHandle<gameTargetShootComponent> TargetShootComponent
		{
			get
			{
				if (_targetShootComponent == null)
				{
					_targetShootComponent = (CHandle<gameTargetShootComponent>) CR2WTypeManager.Create("handle:gameTargetShootComponent", "targetShootComponent", cr2w, this);
				}
				return _targetShootComponent;
			}
			set
			{
				if (_targetShootComponent == value)
				{
					return;
				}
				_targetShootComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("receivedDamageHistory")] 
		public CArray<DamageHistoryEntry> ReceivedDamageHistory
		{
			get
			{
				if (_receivedDamageHistory == null)
				{
					_receivedDamageHistory = (CArray<DamageHistoryEntry>) CR2WTypeManager.Create("array:DamageHistoryEntry", "receivedDamageHistory", cr2w, this);
				}
				return _receivedDamageHistory;
			}
			set
			{
				if (_receivedDamageHistory == value)
				{
					return;
				}
				_receivedDamageHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get
			{
				if (_forceDefeatReward == null)
				{
					_forceDefeatReward = (CBool) CR2WTypeManager.Create("Bool", "forceDefeatReward", cr2w, this);
				}
				return _forceDefeatReward;
			}
			set
			{
				if (_forceDefeatReward == value)
				{
					return;
				}
				_forceDefeatReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("killRewardDisabled")] 
		public CBool KillRewardDisabled
		{
			get
			{
				if (_killRewardDisabled == null)
				{
					_killRewardDisabled = (CBool) CR2WTypeManager.Create("Bool", "killRewardDisabled", cr2w, this);
				}
				return _killRewardDisabled;
			}
			set
			{
				if (_killRewardDisabled == value)
				{
					return;
				}
				_killRewardDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("willDieSoon")] 
		public CBool WillDieSoon
		{
			get
			{
				if (_willDieSoon == null)
				{
					_willDieSoon = (CBool) CR2WTypeManager.Create("Bool", "willDieSoon", cr2w, this);
				}
				return _willDieSoon;
			}
			set
			{
				if (_willDieSoon == value)
				{
					return;
				}
				_willDieSoon = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("isScannerDataDirty")] 
		public CBool IsScannerDataDirty
		{
			get
			{
				if (_isScannerDataDirty == null)
				{
					_isScannerDataDirty = (CBool) CR2WTypeManager.Create("Bool", "isScannerDataDirty", cr2w, this);
				}
				return _isScannerDataDirty;
			}
			set
			{
				if (_isScannerDataDirty == value)
				{
					return;
				}
				_isScannerDataDirty = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get
			{
				if (_hasVisibilityForcedInAnimSystem == null)
				{
					_hasVisibilityForcedInAnimSystem = (CBool) CR2WTypeManager.Create("Bool", "hasVisibilityForcedInAnimSystem", cr2w, this);
				}
				return _hasVisibilityForcedInAnimSystem;
			}
			set
			{
				if (_hasVisibilityForcedInAnimSystem == value)
				{
					return;
				}
				_hasVisibilityForcedInAnimSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
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

		public gameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

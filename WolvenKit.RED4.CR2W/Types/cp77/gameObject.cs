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
		private CHandle<entSlotComponent> _uiSlotComponent;
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
			get => GetProperty(ref _persistentState);
			set => SetProperty(ref _persistentState, value);
		}

		[Ordinal(3)] 
		[RED("playerSocket")] 
		public gamePlayerSocket PlayerSocket
		{
			get => GetProperty(ref _playerSocket);
			set => SetProperty(ref _playerSocket, value);
		}

		[Ordinal(4)] 
		[RED("uiSlotComponent")] 
		public CHandle<entSlotComponent> UiSlotComponent
		{
			get => GetProperty(ref _uiSlotComponent);
			set => SetProperty(ref _uiSlotComponent, value);
		}

		[Ordinal(5)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(6)] 
		[RED("displayName")] 
		public LocalizationString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(7)] 
		[RED("displayDescription")] 
		public LocalizationString DisplayDescription
		{
			get => GetProperty(ref _displayDescription);
			set => SetProperty(ref _displayDescription, value);
		}

		[Ordinal(8)] 
		[RED("audioResourceName")] 
		public CName AudioResourceName
		{
			get => GetProperty(ref _audioResourceName);
			set => SetProperty(ref _audioResourceName, value);
		}

		[Ordinal(9)] 
		[RED("visibilityCheckDistance")] 
		public CFloat VisibilityCheckDistance
		{
			get => GetProperty(ref _visibilityCheckDistance);
			set => SetProperty(ref _visibilityCheckDistance, value);
		}

		[Ordinal(10)] 
		[RED("forceRegisterInHudManager")] 
		public CBool ForceRegisterInHudManager
		{
			get => GetProperty(ref _forceRegisterInHudManager);
			set => SetProperty(ref _forceRegisterInHudManager, value);
		}

		[Ordinal(11)] 
		[RED("prereqListeners")] 
		public CArray<CHandle<GameObjectListener>> PrereqListeners
		{
			get => GetProperty(ref _prereqListeners);
			set => SetProperty(ref _prereqListeners, value);
		}

		[Ordinal(12)] 
		[RED("statusEffectListeners")] 
		public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners
		{
			get => GetProperty(ref _statusEffectListeners);
			set => SetProperty(ref _statusEffectListeners, value);
		}

		[Ordinal(13)] 
		[RED("outlineRequestsManager")] 
		public CHandle<OutlineRequestManager> OutlineRequestsManager
		{
			get => GetProperty(ref _outlineRequestsManager);
			set => SetProperty(ref _outlineRequestsManager, value);
		}

		[Ordinal(14)] 
		[RED("outlineFadeCounter")] 
		public CInt32 OutlineFadeCounter
		{
			get => GetProperty(ref _outlineFadeCounter);
			set => SetProperty(ref _outlineFadeCounter, value);
		}

		[Ordinal(15)] 
		[RED("fadeOutStarted")] 
		public CBool FadeOutStarted
		{
			get => GetProperty(ref _fadeOutStarted);
			set => SetProperty(ref _fadeOutStarted, value);
		}

		[Ordinal(16)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get => GetProperty(ref _lastEngineTime);
			set => SetProperty(ref _lastEngineTime, value);
		}

		[Ordinal(17)] 
		[RED("accumulatedTimePasssed")] 
		public CFloat AccumulatedTimePasssed
		{
			get => GetProperty(ref _accumulatedTimePasssed);
			set => SetProperty(ref _accumulatedTimePasssed, value);
		}

		[Ordinal(18)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get => GetProperty(ref _scanningComponent);
			set => SetProperty(ref _scanningComponent, value);
		}

		[Ordinal(19)] 
		[RED("visionComponent")] 
		public CHandle<gameVisionModeComponent> VisionComponent
		{
			get => GetProperty(ref _visionComponent);
			set => SetProperty(ref _visionComponent, value);
		}

		[Ordinal(20)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetProperty(ref _isHighlightedInFocusMode);
			set => SetProperty(ref _isHighlightedInFocusMode, value);
		}

		[Ordinal(21)] 
		[RED("statusEffectComponent")] 
		public CHandle<gameStatusEffectComponent> StatusEffectComponent
		{
			get => GetProperty(ref _statusEffectComponent);
			set => SetProperty(ref _statusEffectComponent, value);
		}

		[Ordinal(22)] 
		[RED("lastFrameGreen")] 
		public CHandle<OutlineRequest> LastFrameGreen
		{
			get => GetProperty(ref _lastFrameGreen);
			set => SetProperty(ref _lastFrameGreen, value);
		}

		[Ordinal(23)] 
		[RED("lastFrameRed")] 
		public CHandle<OutlineRequest> LastFrameRed
		{
			get => GetProperty(ref _lastFrameRed);
			set => SetProperty(ref _lastFrameRed, value);
		}

		[Ordinal(24)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get => GetProperty(ref _markAsQuest);
			set => SetProperty(ref _markAsQuest, value);
		}

		[Ordinal(25)] 
		[RED("e3HighlightHackStarted")] 
		public CBool E3HighlightHackStarted
		{
			get => GetProperty(ref _e3HighlightHackStarted);
			set => SetProperty(ref _e3HighlightHackStarted, value);
		}

		[Ordinal(26)] 
		[RED("e3ObjectRevealed")] 
		public CBool E3ObjectRevealed
		{
			get => GetProperty(ref _e3ObjectRevealed);
			set => SetProperty(ref _e3ObjectRevealed, value);
		}

		[Ordinal(27)] 
		[RED("forceHighlightSource")] 
		public entEntityID ForceHighlightSource
		{
			get => GetProperty(ref _forceHighlightSource);
			set => SetProperty(ref _forceHighlightSource, value);
		}

		[Ordinal(28)] 
		[RED("workspotMapper")] 
		public CHandle<WorkspotMapperComponent> WorkspotMapper
		{
			get => GetProperty(ref _workspotMapper);
			set => SetProperty(ref _workspotMapper, value);
		}

		[Ordinal(29)] 
		[RED("stimBroadcaster")] 
		public CHandle<StimBroadcasterComponent> StimBroadcaster
		{
			get => GetProperty(ref _stimBroadcaster);
			set => SetProperty(ref _stimBroadcaster, value);
		}

		[Ordinal(30)] 
		[RED("squadMemberComponent")] 
		public CHandle<SquadMemberBaseComponent> SquadMemberComponent
		{
			get => GetProperty(ref _squadMemberComponent);
			set => SetProperty(ref _squadMemberComponent, value);
		}

		[Ordinal(31)] 
		[RED("sourceShootComponent")] 
		public CHandle<gameSourceShootComponent> SourceShootComponent
		{
			get => GetProperty(ref _sourceShootComponent);
			set => SetProperty(ref _sourceShootComponent, value);
		}

		[Ordinal(32)] 
		[RED("targetShootComponent")] 
		public CHandle<gameTargetShootComponent> TargetShootComponent
		{
			get => GetProperty(ref _targetShootComponent);
			set => SetProperty(ref _targetShootComponent, value);
		}

		[Ordinal(33)] 
		[RED("receivedDamageHistory")] 
		public CArray<DamageHistoryEntry> ReceivedDamageHistory
		{
			get => GetProperty(ref _receivedDamageHistory);
			set => SetProperty(ref _receivedDamageHistory, value);
		}

		[Ordinal(34)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get => GetProperty(ref _forceDefeatReward);
			set => SetProperty(ref _forceDefeatReward, value);
		}

		[Ordinal(35)] 
		[RED("killRewardDisabled")] 
		public CBool KillRewardDisabled
		{
			get => GetProperty(ref _killRewardDisabled);
			set => SetProperty(ref _killRewardDisabled, value);
		}

		[Ordinal(36)] 
		[RED("willDieSoon")] 
		public CBool WillDieSoon
		{
			get => GetProperty(ref _willDieSoon);
			set => SetProperty(ref _willDieSoon, value);
		}

		[Ordinal(37)] 
		[RED("isScannerDataDirty")] 
		public CBool IsScannerDataDirty
		{
			get => GetProperty(ref _isScannerDataDirty);
			set => SetProperty(ref _isScannerDataDirty, value);
		}

		[Ordinal(38)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get => GetProperty(ref _hasVisibilityForcedInAnimSystem);
			set => SetProperty(ref _hasVisibilityForcedInAnimSystem, value);
		}

		[Ordinal(39)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		public gameObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameObject : entGameEntity
	{
		[Ordinal(2)] [RED("persistentState")] public CHandle<gamePersistentState> PersistentState { get; set; }
		[Ordinal(3)] [RED("playerSocket")] public gamePlayerSocket PlayerSocket { get; set; }
		[Ordinal(4)] [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(5)] [RED("displayName")] public LocalizationString DisplayName { get; set; }
		[Ordinal(6)] [RED("displayDescription")] public LocalizationString DisplayDescription { get; set; }
		[Ordinal(7)] [RED("audioResourceName")] public CName AudioResourceName { get; set; }
		[Ordinal(8)] [RED("visibilityCheckDistance")] public CFloat VisibilityCheckDistance { get; set; }
		[Ordinal(9)] [RED("forceRegisterInHudManager")] public CBool ForceRegisterInHudManager { get; set; }
		[Ordinal(10)] [RED("prereqListeners")] public CArray<CHandle<GameObjectListener>> PrereqListeners { get; set; }
		[Ordinal(11)] [RED("statusEffectListeners")] public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners { get; set; }
		[Ordinal(12)] [RED("outlineRequestsManager")] public CHandle<OutlineRequestManager> OutlineRequestsManager { get; set; }
		[Ordinal(13)] [RED("outlineFadeCounter")] public CInt32 OutlineFadeCounter { get; set; }
		[Ordinal(14)] [RED("fadeOutStarted")] public CBool FadeOutStarted { get; set; }
		[Ordinal(15)] [RED("lastEngineTime")] public CFloat LastEngineTime { get; set; }
		[Ordinal(16)] [RED("accumulatedTimePasssed")] public CFloat AccumulatedTimePasssed { get; set; }
		[Ordinal(17)] [RED("scanningComponent")] public CHandle<gameScanningComponent> ScanningComponent { get; set; }
		[Ordinal(18)] [RED("visionComponent")] public CHandle<gameVisionModeComponent> VisionComponent { get; set; }
		[Ordinal(19)] [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(20)] [RED("statusEffectComponent")] public CHandle<gameStatusEffectComponent> StatusEffectComponent { get; set; }
		[Ordinal(21)] [RED("lastFrameGreen")] public CHandle<OutlineRequest> LastFrameGreen { get; set; }
		[Ordinal(22)] [RED("lastFrameRed")] public CHandle<OutlineRequest> LastFrameRed { get; set; }
		[Ordinal(23)] [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(24)] [RED("e3HighlightHackStarted")] public CBool E3HighlightHackStarted { get; set; }
		[Ordinal(25)] [RED("e3ObjectRevealed")] public CBool E3ObjectRevealed { get; set; }
		[Ordinal(26)] [RED("forceHighlightSource")] public entEntityID ForceHighlightSource { get; set; }
		[Ordinal(27)] [RED("workspotMapper")] public CHandle<WorkspotMapperComponent> WorkspotMapper { get; set; }
		[Ordinal(28)] [RED("stimBroadcaster")] public CHandle<StimBroadcasterComponent> StimBroadcaster { get; set; }
		[Ordinal(29)] [RED("uiSlotComponent")] public CHandle<entSlotComponent> UiSlotComponent { get; set; }
		[Ordinal(30)] [RED("squadMemberComponent")] public CHandle<SquadMemberBaseComponent> SquadMemberComponent { get; set; }
		[Ordinal(31)] [RED("sourceShootComponent")] public CHandle<gameSourceShootComponent> SourceShootComponent { get; set; }
		[Ordinal(32)] [RED("targetShootComponent")] public CHandle<gameTargetShootComponent> TargetShootComponent { get; set; }
		[Ordinal(33)] [RED("receivedDamageHistory")] public CArray<DamageHistoryEntry> ReceivedDamageHistory { get; set; }
		[Ordinal(34)] [RED("forceDefeatReward")] public CBool ForceDefeatReward { get; set; }
		[Ordinal(35)] [RED("killRewardDisabled")] public CBool KillRewardDisabled { get; set; }
		[Ordinal(36)] [RED("willDieSoon")] public CBool WillDieSoon { get; set; }
		[Ordinal(37)] [RED("isScannerDataDirty")] public CBool IsScannerDataDirty { get; set; }
		[Ordinal(38)] [RED("hasVisibilityForcedInAnimSystem")] public CBool HasVisibilityForcedInAnimSystem { get; set; }
		[Ordinal(39)] [RED("isDead")] public CBool IsDead { get; set; }

		public gameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

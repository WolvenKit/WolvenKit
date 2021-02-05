using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MineDispenser : gameweaponObject
	{
		[Ordinal(0)]  [RED("e3HighlightHackStarted")] public CBool E3HighlightHackStarted { get; set; }
		[Ordinal(1)]  [RED("e3ObjectRevealed")] public CBool E3ObjectRevealed { get; set; }
		[Ordinal(2)]  [RED("forceRegisterInHudManager")] public CBool ForceRegisterInHudManager { get; set; }
		[Ordinal(3)]  [RED("prereqListeners")] public CArray<CHandle<GameObjectListener>> PrereqListeners { get; set; }
		[Ordinal(4)]  [RED("statusEffectListeners")] public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners { get; set; }
		[Ordinal(5)]  [RED("outlineRequestsManager")] public CHandle<OutlineRequestManager> OutlineRequestsManager { get; set; }
		[Ordinal(6)]  [RED("outlineFadeCounter")] public CInt32 OutlineFadeCounter { get; set; }
		[Ordinal(7)]  [RED("fadeOutStarted")] public CBool FadeOutStarted { get; set; }
		[Ordinal(8)]  [RED("lastEngineTime")] public CFloat LastEngineTime { get; set; }
		[Ordinal(9)]  [RED("accumulatedTimePasssed")] public CFloat AccumulatedTimePasssed { get; set; }
		[Ordinal(10)]  [RED("scanningComponent")] public CHandle<gameScanningComponent> ScanningComponent { get; set; }
		[Ordinal(11)]  [RED("visionComponent")] public CHandle<gameVisionModeComponent> VisionComponent { get; set; }
		[Ordinal(12)]  [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(13)]  [RED("statusEffectComponent")] public CHandle<gameStatusEffectComponent> StatusEffectComponent { get; set; }
		[Ordinal(14)]  [RED("lastFrameGreen")] public CHandle<OutlineRequest> LastFrameGreen { get; set; }
		[Ordinal(15)]  [RED("lastFrameRed")] public CHandle<OutlineRequest> LastFrameRed { get; set; }
		[Ordinal(16)]  [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(17)]  [RED("forceHighlightSource")] public entEntityID ForceHighlightSource { get; set; }
		[Ordinal(18)]  [RED("workspotMapper")] public CHandle<WorkspotMapperComponent> WorkspotMapper { get; set; }
		[Ordinal(19)]  [RED("stimBroadcaster")] public CHandle<StimBroadcasterComponent> StimBroadcaster { get; set; }
		[Ordinal(20)]  [RED("uiSlotComponent")] public CHandle<entSlotComponent> UiSlotComponent { get; set; }
		[Ordinal(21)]  [RED("squadMemberComponent")] public CHandle<SquadMemberBaseComponent> SquadMemberComponent { get; set; }
		[Ordinal(22)]  [RED("sourceShootComponent")] public CHandle<gameSourceShootComponent> SourceShootComponent { get; set; }
		[Ordinal(23)]  [RED("targetShootComponent")] public CHandle<gameTargetShootComponent> TargetShootComponent { get; set; }
		[Ordinal(24)]  [RED("receivedDamageHistory")] public CArray<DamageHistoryEntry> ReceivedDamageHistory { get; set; }
		[Ordinal(25)]  [RED("forceDefeatReward")] public CBool ForceDefeatReward { get; set; }
		[Ordinal(26)]  [RED("killRewardDisabled")] public CBool KillRewardDisabled { get; set; }
		[Ordinal(27)]  [RED("willDieSoon")] public CBool WillDieSoon { get; set; }
		[Ordinal(28)]  [RED("isScannerDataDirty")] public CBool IsScannerDataDirty { get; set; }
		[Ordinal(29)]  [RED("hasVisibilityForcedInAnimSystem")] public CBool HasVisibilityForcedInAnimSystem { get; set; }
		[Ordinal(30)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(31)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(32)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(33)]  [RED("hasOverheat")] public CBool HasOverheat { get; set; }
		[Ordinal(34)]  [RED("overheatEffectBlackboard")] public CHandle<worldEffectBlackboard> OverheatEffectBlackboard { get; set; }
		[Ordinal(35)]  [RED("overheatListener")] public CHandle<OverheatStatListener> OverheatListener { get; set; }
		[Ordinal(36)]  [RED("overheatDelaySent")] public CBool OverheatDelaySent { get; set; }
		[Ordinal(37)]  [RED("chargeEffectBlackboard")] public CHandle<worldEffectBlackboard> ChargeEffectBlackboard { get; set; }
		[Ordinal(38)]  [RED("chargeStatListener")] public CHandle<WeaponChargeStatListener> ChargeStatListener { get; set; }
		[Ordinal(39)]  [RED("meleeHitEffectBlackboard")] public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard { get; set; }
		[Ordinal(40)]  [RED("meleeHitEffectValue")] public CFloat MeleeHitEffectValue { get; set; }
		[Ordinal(41)]  [RED("damageTypeListener")] public CHandle<DamageStatListener> DamageTypeListener { get; set; }
		[Ordinal(42)]  [RED("trailName")] public CString TrailName { get; set; }
		[Ordinal(43)]  [RED("maxChargeThreshold")] public CFloat MaxChargeThreshold { get; set; }
		[Ordinal(44)]  [RED("lowAmmoEffectActive")] public CBool LowAmmoEffectActive { get; set; }
		[Ordinal(45)]  [RED("AIBlackboard")] public CHandle<gameIBlackboard> AIBlackboard { get; set; }

		public MineDispenser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

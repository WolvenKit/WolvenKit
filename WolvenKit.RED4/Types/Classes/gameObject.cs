using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameObject : entGameEntity
	{
		[Ordinal(2)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get => GetPropertyValue<CHandle<gamePersistentState>>();
			set => SetPropertyValue<CHandle<gamePersistentState>>(value);
		}

		[Ordinal(3)] 
		[RED("playerSocket")] 
		public gamePlayerSocket PlayerSocket
		{
			get => GetPropertyValue<gamePlayerSocket>();
			set => SetPropertyValue<gamePlayerSocket>(value);
		}

		[Ordinal(4)] 
		[RED("uiSlotComponent")] 
		public CHandle<entSlotComponent> UiSlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(5)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(6)] 
		[RED("displayName")] 
		public LocalizationString DisplayName
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(7)] 
		[RED("displayDescription")] 
		public LocalizationString DisplayDescription
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(8)] 
		[RED("audioResourceName")] 
		public CName AudioResourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("visibilityCheckDistance")] 
		public CFloat VisibilityCheckDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("forceRegisterInHudManager")] 
		public CBool ForceRegisterInHudManager
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("prereqListeners")] 
		public CArray<CHandle<GameObjectListener>> PrereqListeners
		{
			get => GetPropertyValue<CArray<CHandle<GameObjectListener>>>();
			set => SetPropertyValue<CArray<CHandle<GameObjectListener>>>(value);
		}

		[Ordinal(12)] 
		[RED("statusEffectListeners")] 
		public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners
		{
			get => GetPropertyValue<CArray<CHandle<StatusEffectTriggerListener>>>();
			set => SetPropertyValue<CArray<CHandle<StatusEffectTriggerListener>>>(value);
		}

		[Ordinal(13)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("accumulatedTimePasssed")] 
		public CFloat AccumulatedTimePasssed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get => GetPropertyValue<CHandle<gameScanningComponent>>();
			set => SetPropertyValue<CHandle<gameScanningComponent>>(value);
		}

		[Ordinal(16)] 
		[RED("visionComponent")] 
		public CHandle<gameVisionModeComponent> VisionComponent
		{
			get => GetPropertyValue<CHandle<gameVisionModeComponent>>();
			set => SetPropertyValue<CHandle<gameVisionModeComponent>>(value);
		}

		[Ordinal(17)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("statusEffectComponent")] 
		public CHandle<gameStatusEffectComponent> StatusEffectComponent
		{
			get => GetPropertyValue<CHandle<gameStatusEffectComponent>>();
			set => SetPropertyValue<CHandle<gameStatusEffectComponent>>(value);
		}

		[Ordinal(19)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("e3ObjectRevealed")] 
		public CBool E3ObjectRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("workspotMapper")] 
		public CHandle<WorkspotMapperComponent> WorkspotMapper
		{
			get => GetPropertyValue<CHandle<WorkspotMapperComponent>>();
			set => SetPropertyValue<CHandle<WorkspotMapperComponent>>(value);
		}

		[Ordinal(22)] 
		[RED("stimBroadcaster")] 
		public CHandle<StimBroadcasterComponent> StimBroadcaster
		{
			get => GetPropertyValue<CHandle<StimBroadcasterComponent>>();
			set => SetPropertyValue<CHandle<StimBroadcasterComponent>>(value);
		}

		[Ordinal(23)] 
		[RED("squadMemberComponent")] 
		public CHandle<SquadMemberBaseComponent> SquadMemberComponent
		{
			get => GetPropertyValue<CHandle<SquadMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<SquadMemberBaseComponent>>(value);
		}

		[Ordinal(24)] 
		[RED("sourceShootComponent")] 
		public CHandle<gameSourceShootComponent> SourceShootComponent
		{
			get => GetPropertyValue<CHandle<gameSourceShootComponent>>();
			set => SetPropertyValue<CHandle<gameSourceShootComponent>>(value);
		}

		[Ordinal(25)] 
		[RED("targetShootComponent")] 
		public CHandle<gameTargetShootComponent> TargetShootComponent
		{
			get => GetPropertyValue<CHandle<gameTargetShootComponent>>();
			set => SetPropertyValue<CHandle<gameTargetShootComponent>>(value);
		}

		[Ordinal(26)] 
		[RED("receivedDamageHistory")] 
		public CArray<DamageHistoryEntry> ReceivedDamageHistory
		{
			get => GetPropertyValue<CArray<DamageHistoryEntry>>();
			set => SetPropertyValue<CArray<DamageHistoryEntry>>(value);
		}

		[Ordinal(27)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("killRewardDisabled")] 
		public CBool KillRewardDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("willDieSoon")] 
		public CBool WillDieSoon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isScannerDataDirty")] 
		public CBool IsScannerDataDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("lastHitInstigatorID")] 
		public entEntityID LastHitInstigatorID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(34)] 
		[RED("hitInstigatorCooldownID")] 
		public gameDelayID HitInstigatorCooldownID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(35)] 
		[RED("isTargetedWithSmartWeapon")] 
		public CBool IsTargetedWithSmartWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameObject()
		{
			PlayerSocket = new gamePlayerSocket();
			Tags = new redTagList { Tags = new() };
			DisplayName = new() { Unk1 = 0, Value = "" };
			DisplayDescription = new() { Unk1 = 0, Value = "" };
			VisibilityCheckDistance = 16000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

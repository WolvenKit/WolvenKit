using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPuppet : ScriptedPuppet
	{
		[Ordinal(92)] 
		[RED("quickSlotsManager")] 
		public CHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(93)] 
		[RED("inspectionComponent")] 
		public CHandle<InspectionComponent> InspectionComponent
		{
			get => GetPropertyValue<CHandle<InspectionComponent>>();
			set => SetPropertyValue<CHandle<InspectionComponent>>(value);
		}

		[Ordinal(94)] 
		[RED("Phone")] 
		public CHandle<PlayerPhone> Phone
		{
			get => GetPropertyValue<CHandle<PlayerPhone>>();
			set => SetPropertyValue<CHandle<PlayerPhone>>(value);
		}

		[Ordinal(95)] 
		[RED("fppCameraComponent")] 
		public CHandle<gameFPPCameraComponent> FppCameraComponent
		{
			get => GetPropertyValue<CHandle<gameFPPCameraComponent>>();
			set => SetPropertyValue<CHandle<gameFPPCameraComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("primaryTargetingComponent")] 
		public CHandle<gameTargetingComponent> PrimaryTargetingComponent
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("DEBUG_Visualizer")] 
		public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer
		{
			get => GetPropertyValue<CHandle<DEBUG_VisualizerComponent>>();
			set => SetPropertyValue<CHandle<DEBUG_VisualizerComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("Debug_DamageInputRec")] 
		public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec
		{
			get => GetPropertyValue<CHandle<DEBUG_DamageInputReceiver>>();
			set => SetPropertyValue<CHandle<DEBUG_DamageInputReceiver>>(value);
		}

		[Ordinal(99)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(100)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(101)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(102)] 
		[RED("meleeHighDamageThreshold")] 
		public CFloat MeleeHighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(103)] 
		[RED("meleeMedDamageThreshold")] 
		public CFloat MeleeMedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(104)] 
		[RED("meleeLowDamageThreshold")] 
		public CFloat MeleeLowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(105)] 
		[RED("explosionHighDamageThreshold")] 
		public CFloat ExplosionHighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(106)] 
		[RED("explosionMedDamageThreshold")] 
		public CFloat ExplosionMedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(107)] 
		[RED("explosionLowDamageThreshold")] 
		public CFloat ExplosionLowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(109)] 
		[RED("curInventoryWeight")] 
		public CFloat CurInventoryWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("healthVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> HealthVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(111)] 
		[RED("laserTargettingVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(112)] 
		[RED("itemLogBlackboard")] 
		public CWeakHandle<gameIBlackboard> ItemLogBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(113)] 
		[RED("interactionDataListener")] 
		public CHandle<redCallbackObject> InteractionDataListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(114)] 
		[RED("popupIsModalListener")] 
		public CHandle<redCallbackObject> PopupIsModalListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(115)] 
		[RED("uiVendorContextListener")] 
		public CHandle<redCallbackObject> UiVendorContextListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(116)] 
		[RED("uiRadialContextistener")] 
		public CHandle<redCallbackObject> UiRadialContextistener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(117)] 
		[RED("contactsActiveListener")] 
		public CHandle<redCallbackObject> ContactsActiveListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(118)] 
		[RED("currentVisibleTargetListener")] 
		public CHandle<redCallbackObject> CurrentVisibleTargetListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(119)] 
		[RED("lastScanTarget")] 
		public CWeakHandle<gameObject> LastScanTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(120)] 
		[RED("meleeSelectInputProcessed")] 
		public CBool MeleeSelectInputProcessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("waitingForDelayEvent")] 
		public CBool WaitingForDelayEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(122)] 
		[RED("randomizedTime")] 
		public CFloat RandomizedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(123)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(124)] 
		[RED("delayEventID")] 
		public gameDelayID DelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(125)] 
		[RED("resetTickID")] 
		public gameDelayID ResetTickID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(126)] 
		[RED("katanaAnimProgression")] 
		public CFloat KatanaAnimProgression
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(127)] 
		[RED("coverModifierActive")] 
		public CBool CoverModifierActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(128)] 
		[RED("workspotDamageReductionActive")] 
		public CBool WorkspotDamageReductionActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(129)] 
		[RED("workspotVisibilityReductionActive")] 
		public CBool WorkspotVisibilityReductionActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(130)] 
		[RED("currentPlayerWorkspotTags")] 
		public CArray<CName> CurrentPlayerWorkspotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(131)] 
		[RED("incapacitated")] 
		public CBool Incapacitated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(132)] 
		[RED("remoteMappinId")] 
		public gameNewMappinID RemoteMappinId
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(133)] 
		[RED("CPOMissionDataState")] 
		public CHandle<CPOMissionDataState> CPOMissionDataState
		{
			get => GetPropertyValue<CHandle<CPOMissionDataState>>();
			set => SetPropertyValue<CHandle<CPOMissionDataState>>(value);
		}

		[Ordinal(134)] 
		[RED("CPOMissionDataBbId")] 
		public CHandle<redCallbackObject> CPOMissionDataBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(135)] 
		[RED("visibilityListener")] 
		public CHandle<VisibilityStatListener> VisibilityListener
		{
			get => GetPropertyValue<CHandle<VisibilityStatListener>>();
			set => SetPropertyValue<CHandle<VisibilityStatListener>>(value);
		}

		[Ordinal(136)] 
		[RED("secondHeartListener")] 
		public CHandle<SecondHeartStatListener> SecondHeartListener
		{
			get => GetPropertyValue<CHandle<SecondHeartStatListener>>();
			set => SetPropertyValue<CHandle<SecondHeartStatListener>>(value);
		}

		[Ordinal(137)] 
		[RED("armorStatListener")] 
		public CHandle<ArmorStatListener> ArmorStatListener
		{
			get => GetPropertyValue<CHandle<ArmorStatListener>>();
			set => SetPropertyValue<CHandle<ArmorStatListener>>(value);
		}

		[Ordinal(138)] 
		[RED("healthStatListener")] 
		public CHandle<HealthStatListener> HealthStatListener
		{
			get => GetPropertyValue<CHandle<HealthStatListener>>();
			set => SetPropertyValue<CHandle<HealthStatListener>>(value);
		}

		[Ordinal(139)] 
		[RED("oxygenStatListener")] 
		public CHandle<OxygenStatListener> OxygenStatListener
		{
			get => GetPropertyValue<CHandle<OxygenStatListener>>();
			set => SetPropertyValue<CHandle<OxygenStatListener>>(value);
		}

		[Ordinal(140)] 
		[RED("aimAssistListener")] 
		public CHandle<AimAssistSettingsListener> AimAssistListener
		{
			get => GetPropertyValue<CHandle<AimAssistSettingsListener>>();
			set => SetPropertyValue<CHandle<AimAssistSettingsListener>>(value);
		}

		[Ordinal(141)] 
		[RED("autoRevealListener")] 
		public CHandle<AutoRevealStatListener> AutoRevealListener
		{
			get => GetPropertyValue<CHandle<AutoRevealStatListener>>();
			set => SetPropertyValue<CHandle<AutoRevealStatListener>>(value);
		}

		[Ordinal(142)] 
		[RED("allStatsListener")] 
		public CHandle<PlayerPuppetAllStatListener> AllStatsListener
		{
			get => GetPropertyValue<CHandle<PlayerPuppetAllStatListener>>();
			set => SetPropertyValue<CHandle<PlayerPuppetAllStatListener>>(value);
		}

		[Ordinal(143)] 
		[RED("rightHandAttachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> RightHandAttachmentSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(144)] 
		[RED("isTalkingOnPhone")] 
		public CBool IsTalkingOnPhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(145)] 
		[RED("DataDamageUpdateID")] 
		public gameDelayID DataDamageUpdateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(146)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(147)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(148)] 
		[RED("callbackHandles")] 
		public CArray<CHandle<redCallbackObject>> CallbackHandles
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		[Ordinal(149)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(150)] 
		[RED("equipmentMeshOverlayEffectName")] 
		public CName EquipmentMeshOverlayEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(151)] 
		[RED("equipmentMeshOverlayEffectTag")] 
		public CName EquipmentMeshOverlayEffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(152)] 
		[RED("equipmentMeshOverlaySlots")] 
		public CArray<TweakDBID> EquipmentMeshOverlaySlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(153)] 
		[RED("coverVisibilityPerkBlocked")] 
		public CBool CoverVisibilityPerkBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(154)] 
		[RED("behindCover")] 
		public CBool BehindCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(155)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(156)] 
		[RED("hasBeenDetected")] 
		public CBool HasBeenDetected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(157)] 
		[RED("inCrouch")] 
		public CBool InCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(158)] 
		[RED("canWeaponSnapToLimbs")] 
		public CBool CanWeaponSnapToLimbs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(159)] 
		[RED("doingQuickMelee")] 
		public CBool DoingQuickMelee
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(160)] 
		[RED("inVehicleCombat")] 
		public CBool InVehicleCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(161)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(162)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(163)] 
		[RED("equippedRightHandWeapon")] 
		public CWeakHandle<gameweaponObject> EquippedRightHandWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(164)] 
		[RED("aimAssistUpdateQueued")] 
		public CBool AimAssistUpdateQueued
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(165)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(166)] 
		[RED("leftHandCyberwareState")] 
		public CInt32 LeftHandCyberwareState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(167)] 
		[RED("meleeWeaponState")] 
		public CInt32 MeleeWeaponState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(168)] 
		[RED("controllingDeviceID")] 
		public entEntityID ControllingDeviceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(169)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(170)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(171)] 
		[RED("nextBufferModifier")] 
		public CInt32 NextBufferModifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(172)] 
		[RED("attackingNetrunnerID")] 
		public entEntityID AttackingNetrunnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(173)] 
		[RED("NPCDeathInstigator")] 
		public CWeakHandle<NPCPuppet> NPCDeathInstigator
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(174)] 
		[RED("bestTargettingWeapon")] 
		public CWeakHandle<gameweaponObject> BestTargettingWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(175)] 
		[RED("bestTargettingDot")] 
		public CFloat BestTargettingDot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(176)] 
		[RED("targettingEnemies")] 
		public CInt32 TargettingEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(177)] 
		[RED("isAimingAtFriendly")] 
		public CBool IsAimingAtFriendly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(178)] 
		[RED("isAimingAtChild")] 
		public CBool IsAimingAtChild
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(179)] 
		[RED("coverRecordID")] 
		public TweakDBID CoverRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(180)] 
		[RED("damageReductionRecordID")] 
		public TweakDBID DamageReductionRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(181)] 
		[RED("visReductionRecordID")] 
		public TweakDBID VisReductionRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(182)] 
		[RED("lastDmgInflicted")] 
		public EngineTime LastDmgInflicted
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(183)] 
		[RED("critHealthRumblePlayed")] 
		public CBool CritHealthRumblePlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(184)] 
		[RED("critHealthRumbleDurationID")] 
		public gameDelayID CritHealthRumbleDurationID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(185)] 
		[RED("staminaListener")] 
		public CHandle<StaminaListener> StaminaListener
		{
			get => GetPropertyValue<CHandle<StaminaListener>>();
			set => SetPropertyValue<CHandle<StaminaListener>>(value);
		}

		[Ordinal(186)] 
		[RED("memoryListener")] 
		public CHandle<MemoryListener> MemoryListener
		{
			get => GetPropertyValue<CHandle<MemoryListener>>();
			set => SetPropertyValue<CHandle<MemoryListener>>(value);
		}

		[Ordinal(187)] 
		[RED("securityAreaTypeE3HACK")] 
		public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(188)] 
		[RED("overlappedSecurityZones")] 
		public CArray<gamePersistentID> OverlappedSecurityZones
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(189)] 
		[RED("interestingFacts")] 
		public InterestingFacts InterestingFacts
		{
			get => GetPropertyValue<InterestingFacts>();
			set => SetPropertyValue<InterestingFacts>(value);
		}

		[Ordinal(190)] 
		[RED("interestingFactsListenersIds")] 
		public InterestingFactsListenersIds InterestingFactsListenersIds
		{
			get => GetPropertyValue<InterestingFactsListenersIds>();
			set => SetPropertyValue<InterestingFactsListenersIds>(value);
		}

		[Ordinal(191)] 
		[RED("interestingFactsListenersFunctions")] 
		public InterestingFactsListenersFunctions InterestingFactsListenersFunctions
		{
			get => GetPropertyValue<InterestingFactsListenersFunctions>();
			set => SetPropertyValue<InterestingFactsListenersFunctions>(value);
		}

		[Ordinal(192)] 
		[RED("visionModeController")] 
		public CHandle<PlayerVisionModeController> VisionModeController
		{
			get => GetPropertyValue<CHandle<PlayerVisionModeController>>();
			set => SetPropertyValue<CHandle<PlayerVisionModeController>>(value);
		}

		[Ordinal(193)] 
		[RED("combatController")] 
		public CHandle<PlayerCombatController> CombatController
		{
			get => GetPropertyValue<CHandle<PlayerCombatController>>();
			set => SetPropertyValue<CHandle<PlayerCombatController>>(value);
		}

		[Ordinal(194)] 
		[RED("cachedGameplayRestrictions")] 
		public CArray<TweakDBID> CachedGameplayRestrictions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(195)] 
		[RED("delayEndGracePeriodAfterSpawnEventID")] 
		public gameDelayID DelayEndGracePeriodAfterSpawnEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(196)] 
		[RED("bossThatTargetsPlayer")] 
		public entEntityID BossThatTargetsPlayer
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(197)] 
		[RED("choiceTokenTextLayerId")] 
		public CUInt32 ChoiceTokenTextLayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(198)] 
		[RED("choiceTokenTextDrawn")] 
		public CBool ChoiceTokenTextDrawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerPuppet()
		{
			DelayEventID = new();
			ResetTickID = new();
			CurrentPlayerWorkspotTags = new();
			RemoteMappinId = new();
			DataDamageUpdateID = new();
			CallbackHandles = new();
			EquipmentMeshOverlaySlots = new();
			ControllingDeviceID = new();
			AttackingNetrunnerID = new();
			LastDmgInflicted = new();
			CritHealthRumbleDurationID = new();
			OverlappedSecurityZones = new();
			InterestingFacts = new();
			InterestingFactsListenersIds = new();
			InterestingFactsListenersFunctions = new();
			CachedGameplayRestrictions = new();
			DelayEndGracePeriodAfterSpawnEventID = new();
			BossThatTargetsPlayer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

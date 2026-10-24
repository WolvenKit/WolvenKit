using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPuppet : ScriptedPuppet
	{
		[Ordinal(101)] 
		[RED("quickSlotsManager")] 
		public CHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(102)] 
		[RED("inspectionComponent")] 
		public CHandle<InspectionComponent> InspectionComponent
		{
			get => GetPropertyValue<CHandle<InspectionComponent>>();
			set => SetPropertyValue<CHandle<InspectionComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("enviroDamageRcvComponent")] 
		public CHandle<gameEnvironmentDamageReceiverComponent> EnviroDamageRcvComponent
		{
			get => GetPropertyValue<CHandle<gameEnvironmentDamageReceiverComponent>>();
			set => SetPropertyValue<CHandle<gameEnvironmentDamageReceiverComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("mountedVehicle")] 
		public CWeakHandle<vehicleBaseObject> MountedVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(105)] 
		[RED("vehicleKnockdownTimestamp")] 
		public CFloat VehicleKnockdownTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(106)] 
		[RED("Phone")] 
		public CHandle<PlayerPhone> Phone
		{
			get => GetPropertyValue<CHandle<PlayerPhone>>();
			set => SetPropertyValue<CHandle<PlayerPhone>>(value);
		}

		[Ordinal(107)] 
		[RED("fppCameraComponent")] 
		public CHandle<gameFPPCameraComponent> FppCameraComponent
		{
			get => GetPropertyValue<CHandle<gameFPPCameraComponent>>();
			set => SetPropertyValue<CHandle<gameFPPCameraComponent>>(value);
		}

		[Ordinal(108)] 
		[RED("primaryTargetingComponent")] 
		public CHandle<gameTargetingComponent> PrimaryTargetingComponent
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(109)] 
		[RED("breachFinderComponent")] 
		public CHandle<gameBreachFinderComponent> BreachFinderComponent
		{
			get => GetPropertyValue<CHandle<gameBreachFinderComponent>>();
			set => SetPropertyValue<CHandle<gameBreachFinderComponent>>(value);
		}

		[Ordinal(110)] 
		[RED("chaseSpawnComponent")] 
		public CHandle<gameChaseSpawnComponent> ChaseSpawnComponent
		{
			get => GetPropertyValue<CHandle<gameChaseSpawnComponent>>();
			set => SetPropertyValue<CHandle<gameChaseSpawnComponent>>(value);
		}

		[Ordinal(111)] 
		[RED("isInFinisher")] 
		public CBool IsInFinisher
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("DEBUG_Visualizer")] 
		public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer
		{
			get => GetPropertyValue<CHandle<DEBUG_VisualizerComponent>>();
			set => SetPropertyValue<CHandle<DEBUG_VisualizerComponent>>(value);
		}

		[Ordinal(113)] 
		[RED("Debug_DamageInputRec")] 
		public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec
		{
			get => GetPropertyValue<CHandle<DEBUG_DamageInputReceiver>>();
			set => SetPropertyValue<CHandle<DEBUG_DamageInputReceiver>>(value);
		}

		[Ordinal(114)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(115)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(116)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(117)] 
		[RED("meleeHighDamageThreshold")] 
		public CFloat MeleeHighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(118)] 
		[RED("meleeMedDamageThreshold")] 
		public CFloat MeleeMedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(119)] 
		[RED("meleeLowDamageThreshold")] 
		public CFloat MeleeLowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(120)] 
		[RED("explosionHighDamageThreshold")] 
		public CFloat ExplosionHighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(121)] 
		[RED("explosionMedDamageThreshold")] 
		public CFloat ExplosionMedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(122)] 
		[RED("explosionLowDamageThreshold")] 
		public CFloat ExplosionLowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(123)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(124)] 
		[RED("curInventoryWeight")] 
		public CFloat CurInventoryWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(125)] 
		[RED("healthVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> HealthVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(126)] 
		[RED("laserTargettingVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(127)] 
		[RED("itemLogBlackboard")] 
		public CWeakHandle<gameIBlackboard> ItemLogBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(128)] 
		[RED("interactionDataListener")] 
		public CHandle<redCallbackObject> InteractionDataListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(129)] 
		[RED("popupIsModalListener")] 
		public CHandle<redCallbackObject> PopupIsModalListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(130)] 
		[RED("uiVendorContextListener")] 
		public CHandle<redCallbackObject> UiVendorContextListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(131)] 
		[RED("uiRadialContextistener")] 
		public CHandle<redCallbackObject> UiRadialContextistener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(132)] 
		[RED("contactsActiveListener")] 
		public CHandle<redCallbackObject> ContactsActiveListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(133)] 
		[RED("smsMessengerActiveListener")] 
		public CHandle<redCallbackObject> SmsMessengerActiveListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(134)] 
		[RED("currentVisibleTargetListener")] 
		public CHandle<redCallbackObject> CurrentVisibleTargetListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(135)] 
		[RED("joyconDualStyleChangedListener")] 
		public CHandle<redCallbackObject> JoyconDualStyleChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(136)] 
		[RED("onInputStyleChangedListener")] 
		public CHandle<redCallbackObject> OnInputStyleChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(137)] 
		[RED("chargeAttackPatternListener")] 
		public CHandle<redCallbackObject> ChargeAttackPatternListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(138)] 
		[RED("patternMatchingMeleeEnabledListener")] 
		public CHandle<redCallbackObject> PatternMatchingMeleeEnabledListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(139)] 
		[RED("isInsideOfChargePattern")] 
		public CBool IsInsideOfChargePattern
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(140)] 
		[RED("isPatternMatchingMeleeEnabled")] 
		public CBool IsPatternMatchingMeleeEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(141)] 
		[RED("lastScanTarget")] 
		public CWeakHandle<gameObject> LastScanTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(142)] 
		[RED("meleeSelectInputProcessed")] 
		public CBool MeleeSelectInputProcessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(143)] 
		[RED("waitingForDelayEvent")] 
		public CBool WaitingForDelayEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(144)] 
		[RED("randomizedTime")] 
		public CFloat RandomizedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(145)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(146)] 
		[RED("delayEventID")] 
		public gameDelayID DelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(147)] 
		[RED("resetTickID")] 
		public gameDelayID ResetTickID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(148)] 
		[RED("katanaAnimProgression")] 
		public CFloat KatanaAnimProgression
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(149)] 
		[RED("coverModifierActive")] 
		public CBool CoverModifierActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(150)] 
		[RED("workspotDamageReductionActive")] 
		public CBool WorkspotDamageReductionActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(151)] 
		[RED("workspotVisibilityReductionActive")] 
		public CBool WorkspotVisibilityReductionActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(152)] 
		[RED("currentPlayerWorkspotTags")] 
		public CArray<CName> CurrentPlayerWorkspotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(153)] 
		[RED("incapacitated")] 
		public CBool Incapacitated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(154)] 
		[RED("remoteMappinId")] 
		public gameNewMappinID RemoteMappinId
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(155)] 
		[RED("CPOMissionDataState")] 
		public CHandle<CPOMissionDataState> CPOMissionDataState
		{
			get => GetPropertyValue<CHandle<CPOMissionDataState>>();
			set => SetPropertyValue<CHandle<CPOMissionDataState>>(value);
		}

		[Ordinal(156)] 
		[RED("CPOMissionDataBbId")] 
		public CHandle<redCallbackObject> CPOMissionDataBbId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(157)] 
		[RED("visibilityListener")] 
		public CHandle<VisibilityStatListener> VisibilityListener
		{
			get => GetPropertyValue<CHandle<VisibilityStatListener>>();
			set => SetPropertyValue<CHandle<VisibilityStatListener>>(value);
		}

		[Ordinal(158)] 
		[RED("secondHeartListener")] 
		public CHandle<SecondHeartStatListener> SecondHeartListener
		{
			get => GetPropertyValue<CHandle<SecondHeartStatListener>>();
			set => SetPropertyValue<CHandle<SecondHeartStatListener>>(value);
		}

		[Ordinal(159)] 
		[RED("armorStatListener")] 
		public CHandle<ArmorStatListener> ArmorStatListener
		{
			get => GetPropertyValue<CHandle<ArmorStatListener>>();
			set => SetPropertyValue<CHandle<ArmorStatListener>>(value);
		}

		[Ordinal(160)] 
		[RED("healthStatListener")] 
		public CHandle<HealthStatListener> HealthStatListener
		{
			get => GetPropertyValue<CHandle<HealthStatListener>>();
			set => SetPropertyValue<CHandle<HealthStatListener>>(value);
		}

		[Ordinal(161)] 
		[RED("oxygenStatListener")] 
		public CHandle<OxygenStatListener> OxygenStatListener
		{
			get => GetPropertyValue<CHandle<OxygenStatListener>>();
			set => SetPropertyValue<CHandle<OxygenStatListener>>(value);
		}

		[Ordinal(162)] 
		[RED("aimAssistListener")] 
		public CHandle<AimAssistSettingsListener> AimAssistListener
		{
			get => GetPropertyValue<CHandle<AimAssistSettingsListener>>();
			set => SetPropertyValue<CHandle<AimAssistSettingsListener>>(value);
		}

		[Ordinal(163)] 
		[RED("autoRevealListener")] 
		public CHandle<AutoRevealStatListener> AutoRevealListener
		{
			get => GetPropertyValue<CHandle<AutoRevealStatListener>>();
			set => SetPropertyValue<CHandle<AutoRevealStatListener>>(value);
		}

		[Ordinal(164)] 
		[RED("allStatsListener")] 
		public CHandle<PlayerPuppetAllStatListener> AllStatsListener
		{
			get => GetPropertyValue<CHandle<PlayerPuppetAllStatListener>>();
			set => SetPropertyValue<CHandle<PlayerPuppetAllStatListener>>(value);
		}

		[Ordinal(165)] 
		[RED("rightHandAttachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> RightHandAttachmentSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(166)] 
		[RED("leftHandAttachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> LeftHandAttachmentSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(167)] 
		[RED("HealingItemsChargeStatListener")] 
		public CHandle<HealingItemsChargeStatListener> HealingItemsChargeStatListener
		{
			get => GetPropertyValue<CHandle<HealingItemsChargeStatListener>>();
			set => SetPropertyValue<CHandle<HealingItemsChargeStatListener>>(value);
		}

		[Ordinal(168)] 
		[RED("GrenadesChargeStatListener")] 
		public CHandle<GrenadesChargeStatListener> GrenadesChargeStatListener
		{
			get => GetPropertyValue<CHandle<GrenadesChargeStatListener>>();
			set => SetPropertyValue<CHandle<GrenadesChargeStatListener>>(value);
		}

		[Ordinal(169)] 
		[RED("ProjectileLauncherChargeStatListener")] 
		public CHandle<ProjectileLauncherChargeStatListener> ProjectileLauncherChargeStatListener
		{
			get => GetPropertyValue<CHandle<ProjectileLauncherChargeStatListener>>();
			set => SetPropertyValue<CHandle<ProjectileLauncherChargeStatListener>>(value);
		}

		[Ordinal(170)] 
		[RED("OpticalCamoChargeStatListener")] 
		public CHandle<OpticalCamoChargeStatListener> OpticalCamoChargeStatListener
		{
			get => GetPropertyValue<CHandle<OpticalCamoChargeStatListener>>();
			set => SetPropertyValue<CHandle<OpticalCamoChargeStatListener>>(value);
		}

		[Ordinal(171)] 
		[RED("OverclockChargeListener")] 
		public CHandle<OverclockChargeListener> OverclockChargeListener
		{
			get => GetPropertyValue<CHandle<OverclockChargeListener>>();
			set => SetPropertyValue<CHandle<OverclockChargeListener>>(value);
		}

		[Ordinal(172)] 
		[RED("accessibilityControlsListener")] 
		public CHandle<AccessibilityControlsListener> AccessibilityControlsListener
		{
			get => GetPropertyValue<CHandle<AccessibilityControlsListener>>();
			set => SetPropertyValue<CHandle<AccessibilityControlsListener>>(value);
		}

		[Ordinal(173)] 
		[RED("isTalkingOnPhone")] 
		public CBool IsTalkingOnPhone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(174)] 
		[RED("DataDamageUpdateID")] 
		public gameDelayID DataDamageUpdateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(175)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(176)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(177)] 
		[RED("callbackHandles")] 
		public CArray<CHandle<redCallbackObject>> CallbackHandles
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		[Ordinal(178)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(179)] 
		[RED("equipmentMeshOverlayEffectName")] 
		public CName EquipmentMeshOverlayEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(180)] 
		[RED("equipmentMeshOverlayEffectTag")] 
		public CName EquipmentMeshOverlayEffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(181)] 
		[RED("equipmentMeshOverlaySlots")] 
		public CArray<TweakDBID> EquipmentMeshOverlaySlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(182)] 
		[RED("coverVisibilityPerkBlocked")] 
		public CBool CoverVisibilityPerkBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(183)] 
		[RED("behindCover")] 
		public CBool BehindCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(184)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(185)] 
		[RED("isBeingRevealed")] 
		public CBool IsBeingRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(186)] 
		[RED("hasBeenDetected")] 
		public CBool HasBeenDetected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(187)] 
		[RED("inCrouch")] 
		public CBool InCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(188)] 
		[RED("hasKiroshiOpticsFragment")] 
		public CBool HasKiroshiOpticsFragment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(189)] 
		[RED("doingQuickMelee")] 
		public CBool DoingQuickMelee
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(190)] 
		[RED("vehicleState")] 
		public CEnum<gamePSMVehicle> VehicleState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(191)] 
		[RED("inMountedWeaponVehicle")] 
		public CBool InMountedWeaponVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(192)] 
		[RED("inDriverCombatTPP")] 
		public CBool InDriverCombatTPP
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(193)] 
		[RED("driverCombatWeaponType")] 
		public CEnum<gamedataItemType> DriverCombatWeaponType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(194)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(195)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(196)] 
		[RED("customFastForwardPossible")] 
		public CBool CustomFastForwardPossible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(197)] 
		[RED("equippedRightHandWeapon")] 
		public CWeakHandle<gameweaponObject> EquippedRightHandWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(198)] 
		[RED("equippedLeftHandWeapon")] 
		public CWeakHandle<gameweaponObject> EquippedLeftHandWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(199)] 
		[RED("aimAssistUpdateQueued")] 
		public CBool AimAssistUpdateQueued
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(200)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(201)] 
		[RED("leftHandCyberwareState")] 
		public CInt32 LeftHandCyberwareState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(202)] 
		[RED("meleeWeaponState")] 
		public CInt32 MeleeWeaponState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(203)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(204)] 
		[RED("controllingDeviceID")] 
		public entEntityID ControllingDeviceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(205)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(206)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(207)] 
		[RED("isInBodySlam")] 
		public CBool IsInBodySlam
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(208)] 
		[RED("combatGadgetState")] 
		public CInt32 CombatGadgetState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(209)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(210)] 
		[RED("nextBufferModifier")] 
		public CInt32 NextBufferModifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(211)] 
		[RED("attackingNetrunnerID")] 
		public entEntityID AttackingNetrunnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(212)] 
		[RED("NPCDeathInstigator")] 
		public CWeakHandle<NPCPuppet> NPCDeathInstigator
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(213)] 
		[RED("bestTargettingWeapon")] 
		public CWeakHandle<gameweaponObject> BestTargettingWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(214)] 
		[RED("bestTargettingDot")] 
		public CFloat BestTargettingDot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(215)] 
		[RED("targettingEnemies")] 
		public CInt32 TargettingEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(216)] 
		[RED("isAimingAtFriendly")] 
		public CBool IsAimingAtFriendly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(217)] 
		[RED("isAimingAtChild")] 
		public CBool IsAimingAtChild
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(218)] 
		[RED("distanceFromTargetSquared")] 
		public CFloat DistanceFromTargetSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(219)] 
		[RED("coverRecordID")] 
		public TweakDBID CoverRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(220)] 
		[RED("damageReductionRecordID")] 
		public TweakDBID DamageReductionRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(221)] 
		[RED("visReductionRecordID")] 
		public TweakDBID VisReductionRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(222)] 
		[RED("lastDmgInflicted")] 
		public EngineTime LastDmgInflicted
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(223)] 
		[RED("critHealthRumblePlayed")] 
		public CBool CritHealthRumblePlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(224)] 
		[RED("critHealthRumbleDurationID")] 
		public gameDelayID CritHealthRumbleDurationID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(225)] 
		[RED("lastHealthUpdate")] 
		public CFloat LastHealthUpdate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(226)] 
		[RED("staminaListener")] 
		public CHandle<StaminaListener> StaminaListener
		{
			get => GetPropertyValue<CHandle<StaminaListener>>();
			set => SetPropertyValue<CHandle<StaminaListener>>(value);
		}

		[Ordinal(227)] 
		[RED("memoryListener")] 
		public CHandle<MemoryListener> MemoryListener
		{
			get => GetPropertyValue<CHandle<MemoryListener>>();
			set => SetPropertyValue<CHandle<MemoryListener>>(value);
		}

		[Ordinal(228)] 
		[RED("securityAreaTypeE3HACK")] 
		public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(229)] 
		[RED("overlappedSecurityZones")] 
		public CArray<gamePersistentID> OverlappedSecurityZones
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(230)] 
		[RED("interestingFacts")] 
		public InterestingFacts InterestingFacts
		{
			get => GetPropertyValue<InterestingFacts>();
			set => SetPropertyValue<InterestingFacts>(value);
		}

		[Ordinal(231)] 
		[RED("interestingFactsListenersIds")] 
		public InterestingFactsListenersIds InterestingFactsListenersIds
		{
			get => GetPropertyValue<InterestingFactsListenersIds>();
			set => SetPropertyValue<InterestingFactsListenersIds>(value);
		}

		[Ordinal(232)] 
		[RED("interestingFactsListenersFunctions")] 
		public InterestingFactsListenersFunctions InterestingFactsListenersFunctions
		{
			get => GetPropertyValue<InterestingFactsListenersFunctions>();
			set => SetPropertyValue<InterestingFactsListenersFunctions>(value);
		}

		[Ordinal(233)] 
		[RED("visionModeController")] 
		public CHandle<PlayerVisionModeController> VisionModeController
		{
			get => GetPropertyValue<CHandle<PlayerVisionModeController>>();
			set => SetPropertyValue<CHandle<PlayerVisionModeController>>(value);
		}

		[Ordinal(234)] 
		[RED("combatController")] 
		public CHandle<PlayerCombatController> CombatController
		{
			get => GetPropertyValue<CHandle<PlayerCombatController>>();
			set => SetPropertyValue<CHandle<PlayerCombatController>>(value);
		}

		[Ordinal(235)] 
		[RED("weaponHandlingModifiers")] 
		public CHandle<PlayerWeaponHandlingModifiers> WeaponHandlingModifiers
		{
			get => GetPropertyValue<CHandle<PlayerWeaponHandlingModifiers>>();
			set => SetPropertyValue<CHandle<PlayerWeaponHandlingModifiers>>(value);
		}

		[Ordinal(236)] 
		[RED("cachedGameplayRestrictions")] 
		public CArray<TweakDBID> CachedGameplayRestrictions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(237)] 
		[RED("delayEndGracePeriodAfterSpawnEventID")] 
		public gameDelayID DelayEndGracePeriodAfterSpawnEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(238)] 
		[RED("CWMaskInVehicleInputHeld")] 
		public CBool CWMaskInVehicleInputHeld
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(239)] 
		[RED("friendlyDevicesHostileToEnemiesLock")] 
		public ScriptReentrantRWLock FriendlyDevicesHostileToEnemiesLock
		{
			get => GetPropertyValue<ScriptReentrantRWLock>();
			set => SetPropertyValue<ScriptReentrantRWLock>(value);
		}

		[Ordinal(240)] 
		[RED("friendlyDevicesHostileToEnemies")] 
		public CArray<entEntityID> FriendlyDevicesHostileToEnemies
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(241)] 
		[RED("pocketRadio")] 
		public CHandle<PocketRadio> PocketRadio
		{
			get => GetPropertyValue<CHandle<PocketRadio>>();
			set => SetPropertyValue<CHandle<PocketRadio>>(value);
		}

		[Ordinal(242)] 
		[RED("patternManager")] 
		public CHandle<PatternManager> PatternManager
		{
			get => GetPropertyValue<CHandle<PatternManager>>();
			set => SetPropertyValue<CHandle<PatternManager>>(value);
		}

		[Ordinal(243)] 
		[RED("patternMatchingIsOn")] 
		public CBool PatternMatchingIsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(244)] 
		[RED("isJoyConStyleDual")] 
		public CBool IsJoyConStyleDual
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(245)] 
		[RED("noMovementModifierData")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> NoMovementModifierData
		{
			get => GetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(246)] 
		[RED("registeredFactListeners")] 
		public CArray<FactCallbackData> RegisteredFactListeners
		{
			get => GetPropertyValue<CArray<FactCallbackData>>();
			set => SetPropertyValue<CArray<FactCallbackData>>(value);
		}

		[Ordinal(247)] 
		[RED("bossThatTargetsPlayer")] 
		public entEntityID BossThatTargetsPlayer
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(248)] 
		[RED("choiceTokenTextLayerId")] 
		public CUInt32 ChoiceTokenTextLayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(249)] 
		[RED("choiceTokenTextDrawn")] 
		public CBool ChoiceTokenTextDrawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerPuppet()
		{
			DelayEventID = new gameDelayID();
			ResetTickID = new gameDelayID();
			CurrentPlayerWorkspotTags = new();
			RemoteMappinId = new gameNewMappinID();
			DataDamageUpdateID = new gameDelayID();
			CallbackHandles = new();
			EquipmentMeshOverlaySlots = new();
			ControllingDeviceID = new entEntityID();
			AttackingNetrunnerID = new entEntityID();
			LastDmgInflicted = new EngineTime();
			CritHealthRumbleDurationID = new gameDelayID();
			OverlappedSecurityZones = new();
			InterestingFacts = new InterestingFacts();
			InterestingFactsListenersIds = new InterestingFactsListenersIds();
			InterestingFactsListenersFunctions = new InterestingFactsListenersFunctions();
			CachedGameplayRestrictions = new();
			DelayEndGracePeriodAfterSpawnEventID = new gameDelayID();
			FriendlyDevicesHostileToEnemiesLock = new ScriptReentrantRWLock();
			FriendlyDevicesHostileToEnemies = new();
			NoMovementModifierData = new();
			RegisteredFactListeners = new();
			BossThatTargetsPlayer = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
